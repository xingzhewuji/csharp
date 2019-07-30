using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;

namespace 导调控制系统
{
    class SQLiteHelper
    {
        static public string dbName = @"Order.db";
        static public string SQLiteConnString = null;

        private SQLiteHelper()
        {
        }

        /// <summary>
        /// 新建数据库文件
        /// </summary>
        /// <returns>新建成功，返回true，否则返回false</returns>
        static public Boolean NewDbFile()
        {
            try
            {
                SQLiteConnection.CreateFile(dbName);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("新建数据库文件" + dbName + "失败：" + ex.Message);
            }
        }

        static public void NewTable(string tableName)
        {

            SQLiteConnection sqliteConn = new SQLiteConnection("data source=" + dbName);
            if (sqliteConn.State != System.Data.ConnectionState.Open)
            {
                sqliteConn.Open();
                SQLiteCommand cmd = new SQLiteCommand
                {
                    Connection = sqliteConn,
                    CommandText = "CREATE TABLE " + tableName + "(ID INT,time DATETIME, instruct STRING)"
                };
                cmd.ExecuteNonQuery();
            }
            sqliteConn.Close();
        }

        static public ulong MaxID(string tableName)
        {
            ulong id = 0;
            SQLiteConnection sqliteConn = new SQLiteConnection("data source=" + dbName);
            if (sqliteConn.State != System.Data.ConnectionState.Open)
            {
                sqliteConn.Open();
                SQLiteCommand cmd = new SQLiteCommand
                {
                    Connection = sqliteConn,
                    CommandText = "SELECT MAX(ID) FROM " + tableName
                };
                object obj = cmd.ExecuteScalar();
                try
                {
                    id = Convert.ToUInt64(obj);
                }
                catch{ }
            }
            sqliteConn.Close();
            return id;
        }

        static public void Append(string tableName, ulong id, DateTime dt, string instruct)
        {

            SQLiteConnection sqliteConn = new SQLiteConnection("data source=" + dbName);
            if (sqliteConn.State != System.Data.ConnectionState.Open)
            {
                sqliteConn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqliteConn);
                cmd.CommandText = "INSERT INTO "+ tableName +"(ID,time,instruct) VALUES(@id,@time,@instruct)";
                cmd.Parameters.Add("id", DbType.UInt64).Value = id;
                cmd.Parameters.Add("time", DbType.DateTime).Value = dt;
                cmd.Parameters.Add("instruct", DbType.String).Value = instruct;
                cmd.ExecuteNonQuery();
            }
            sqliteConn.Close();
        }
        /// <summary>
        /// 执行SQL语句，无返回值
        /// </summary>
        /// <returns>无</returns>
        static public void ExecuteNoRetrun(string sql)
        {

            SQLiteConnection sqliteConn = new SQLiteConnection("data source=" + dbName);
            if (sqliteConn.State != System.Data.ConnectionState.Open)
            {
                sqliteConn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqliteConn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            sqliteConn.Close();
        }
        /// <summary>
        /// 执行SQL语句，返回DataReader对象
        /// </summary>
        /// <returns>DataReader对象</returns>
        static public SQLiteDataReader ExecuteWithRetrun(string sql)
        {
            SQLiteDataReader rd = null;
            SQLiteConnection sqliteConn = new SQLiteConnection("data source=" + dbName);
            if (sqliteConn.State != System.Data.ConnectionState.Open)
            {
                sqliteConn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqliteConn);
                cmd.CommandText = sql;
                rd = cmd.ExecuteReader();
            }
            sqliteConn.Close();
            return rd;
        }
        /// <summary>
        /// 执行SQL语句，返回结果的第一行第一列对象
        /// </summary>
        /// <returns>Object对象</returns>
        static public object ExecuteWithFRFC(string sql)
        {
            object obj = null;
            SQLiteConnection sqliteConn = new SQLiteConnection("data source=" + dbName);
            if (sqliteConn.State != System.Data.ConnectionState.Open)
            {
                sqliteConn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sqliteConn);
                cmd.CommandText = sql;
                obj = cmd.ExecuteScalar();
            }
            sqliteConn.Close();
            return obj;
        }
    }
}

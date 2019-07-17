using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ProgressBarTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath("back.png"));
            //string[] log_mess = new[] { "1号文书", "2号人员", "3号人员", "4号人员", "5号人员", "6号人员" };
            Changelabel();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.FormClosing += Frm_FormClosing;//主窗体里订阅子窗体关闭事件
            f.Show();
 


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        /**
        private void label2_MouseHover(object sender, EventArgs e)
        {
            //移动变化颜色
            this.label2.BackColor = Color.Red;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //离开变化颜色
            this.label2.BackColor = Color.White;
        }
        **/
        private void label4_Click_1(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }
        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int x = 12;
            int y = 154;
            label10.Text = "成功发送文书：1号文书---->1号人员";
            label10.Location = new Point(x, y);
            label11.Text = "时间：2019年7月15日 18:49";
            label11.Location = new Point(x, y = y + 22);
            label12.Text = "查看详情";
            label12.Location = new Point(335,154);

            label1.Location = new Point(x, y = y + 33);
            label3.Location = new Point(x, y = y + 22);
            label2.Location = new Point(335, 211);

            label6.Location = new Point(x, y = y + 33);
            label5.Location = new Point(x, y = y + 22);
            label4.Location = new Point(335, 266);

            label9.Location = new Point(x, y = y + 33);
            label8.Location = new Point(x, y = y + 22);
            label7.Location = new Point(335, 321);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void Changelabel()
        {
            timer1.Enabled = false;
            label13.Text = "";
            timer1.Interval = 3000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label13.Text = "收到新文书，清查看";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }
    }
}

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
    public partial class wenshu : Form
    {
        public wenshu()
        {
            InitializeComponent();
           // this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath("back.png"));
            //string[] log_mess = new[] { "1号文书", "2号人员", "3号人员", "4号人员", "5号人员", "6号人员" };
            Changelabel();
        }

        public string date_send;
        
        private void button1_Click(object sender, EventArgs e)
        {
            search b1 = new search();
            b1.TopLevel = false;
            b1.Dock = DockStyle.Fill;
            b1.Parent = this.panel1;
            b1.ControlBox = false;
            b1.Show();
            this.panel1.Visible = true;
            b1.FormClosing += Frm_FormClosingb1;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosingb1(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            send b2 = new send();
            b2.TopLevel = false;
            b2.Dock = DockStyle.Fill;
            b2.Parent = this.panel1;
            b2.Show();
            this.panel1.Visible = true;
            b2.FormClosing += Frm_FormClosingb2;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosingb2(object sender, FormClosingEventArgs e)
        {
            int x = 12;
            int y = 154;
            label10.Text = "成功发送文书：1号文书---->1号人员";
            label10.Location = new Point(x, y);
            date_send = DateTime.Now.ToString("F");
            label11.Text = "时间：" + date_send;
            label11.Location = new Point(x, y = y + 22);
            label12.Text = "查看详情";
            label12.Location = new Point(335, 154);

            label1.Location = new Point(x, y = y + 33);
            label3.Location = new Point(x, y = y + 22);
            label2.Location = new Point(335, 211);

            label6.Location = new Point(x, y = y + 33);
            label5.Location = new Point(x, y = y + 22);
            label4.Location = new Point(335, 266);

            label9.Location = new Point(x, y = y + 33);
            label8.Location = new Point(x, y = y + 22);
            label7.Location = new Point(335, 321);
            this.panel1.Visible = false;
        }


        private void label2_Click(object sender, EventArgs e)
        {
            mess1 f1 = new mess1();
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            f1.Parent = this.panel1;
            f1.Show();
            this.panel1.Visible = true;
            f1.FormClosing += Frm_FormClosing1;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing1(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
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
        private void label4_Click(object sender, EventArgs e)
        {
            mess2 f2 = new mess2();
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            f2.Parent = this.panel1;
            f2.Show();
            this.panel1.Visible = true;
            f2.FormClosing += Frm_FormClosing2;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing2(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mess3 f3 = new mess3();
            f3.TopLevel = false;
            f3.Dock = DockStyle.Fill;
            f3.Parent = this.panel1;
            f3.Show();
            this.panel1.Visible = true;
            f3.FormClosing += Frm_FormClosing3;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing3(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            mess4 f4 = new mess4();
            f4.TopLevel = false;
            f4.Dock = DockStyle.Fill;
            f4.Parent = this.panel1;
            f4.Show();
            this.panel1.Visible = true;
            f4.FormClosing += Frm_FormClosing4;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing4(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void Changelabel()
        {
            timer1.Enabled = false;
            label13.Text = "";
            timer1.Interval = 10000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label13.Text = "收到新文书，清查看";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            mess_rec f5 = new mess_rec();
            f5.TopLevel = false;
            f5.Dock = DockStyle.Fill;
            f5.Parent = this.panel1;
            f5.Show();
            this.panel1.Visible = true;
            f5.FormClosing += Frm_FormClosing5;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing5(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
            label13.Text = "";

            int x = 12;
            int y = 154+55;


            label14.Text = "成功接收文书：2号文书---->3号人员";
            label14.Location = new Point(x, 154);

            label15.Text = "时间：" + DateTime.Now.ToString("F");
            label15.Location = new Point(x, 154 + 22);
            label16.Text = "查看详情";
            label16.Location = new Point(335,154);



            label10.Text = "成功发送文书：1号文书---->1号人员";
            label10.Location = new Point(x, y);
            
            label11.Text = "时间：" + date_send;
            label11.Location = new Point(x, y = y + 22);
            label12.Text = "查看详情";
            label12.Location = new Point(335, 211);

            label1.Location = new Point(x, y = y + 33);
            label3.Location = new Point(x, y = y + 22);
            label2.Location = new Point(335, 266);

            label6.Location = new Point(x, y = y + 33);
            label5.Location = new Point(x, y = y + 22);
            label4.Location = new Point(335, 321);

            label9.Location = new Point(x, y = y + 33);
            label8.Location = new Point(x, y = y + 22);
            label7.Location = new Point(335, 376);

        }

        private void wenshu_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            mess_rec f5 = new mess_rec();
            f5.TopLevel = false;
            f5.Dock = DockStyle.Fill;
            f5.Parent = this.panel1;
            f5.Show();
            this.panel1.Visible = true;
            f5.FormClosing += Frm_FormClosing5r;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing5r(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }

    }
}

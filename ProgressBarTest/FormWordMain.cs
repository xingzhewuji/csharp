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
    public partial class FormWordMain : Form
    {
        public FormWordMain()
        {
            InitializeComponent();
           // this.BackgroundImage = Image.FromFile(System.IO.Path.GetFullPath("back.png"));
            //string[] log_mess = new[] { "1号文书", "2号人员", "3号人员", "4号人员", "5号人员", "6号人员" };
            Changelabel();
        }

        public string date_send;
        public string date_rec;

        private void button1_Click(object sender, EventArgs e)
        {
            FormSearch b1 = new FormSearch();
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

            FormSend b2 = new FormSend();
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
            label10.Text = "成功发送文书：2号文书---->4号人员";
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
            FormMess f1 = new FormMess("文书标题：4号文书","下发单位:1号人员","接收单位:2号人员", "时间：2019年7月14日 18:49:02");
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
            FormMess f2 = new FormMess("文书标题：1号文书", "下发单位:1号人员", "接收单位:2号人员，3号人员", "时间：2019年7月14日 17:29:16");
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
            FormMess f3 = new FormMess("文书标题：2号文书", "下发单位:3号人员", "接收单位:1号人员", "时间：2019年7月14日 14:29:26");
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
            FormMess f4 = new FormMess("文书标题：2号文书", "下发单位:1号人员", "接收单位:4号人员", "时间"+date_send);
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
            label13.Text = "收到新文书，请查看";
            date_rec = DateTime.Now.ToString("F");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            FormMess f5 = new FormMess("文书标题：2号文书", "下发单位:1号人员", "接收单位:3号人员", "时间:"+ date_rec);
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

            label15.Text = "时间：" + date_rec;
            label15.Location = new Point(x, 154 + 22);
            label16.Text = "查看详情";
            label16.Location = new Point(335,154);



            label10.Text = "成功发送文书：2号文书---->4号人员";
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
            FormMess f5 = new FormMess("文书标题：4号文书", "下发单位:1号人员", "接收单位:3号人员", "时间:2019年7月11号 19:10:20");
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

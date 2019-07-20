using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ProgressBarTest
{
    public partial class FormMess : Form
    {
        public FormMess()
        {
            InitializeComponent();
        }
        public FormMess(string mess_title,string mess_send_location,string mess_rec_location,string mess_rec_time )
        {
            InitializeComponent();
            label1.Text = mess_title;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
            label2.Text = mess_send_location;
            label3.Text = mess_rec_location;
            label4.Text = mess_rec_time;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowWord f = new FormShowWord("word\\web.docx");
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Parent = this.panel1;
            f.Show();
            this.panel1.Visible = true;
            f.FormClosing += Frm_FormClosing1;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing1(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowWord f = new FormShowWord("word\\web2.docx");
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Parent = this.panel1;
            f.Show();
            this.panel1.Visible = true;
            f.FormClosing += Frm_FormClosing2;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing2(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }


    }
}

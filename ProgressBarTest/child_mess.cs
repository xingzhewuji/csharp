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
    public partial class child_mess : Form
    {
        public child_mess()
        {
            InitializeComponent();
        }
        public child_mess(string str)
        {
            InitializeComponent();
            label1.Text = str;//这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
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
            word_test f = new word_test();
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
            word_test f = new word_test();
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

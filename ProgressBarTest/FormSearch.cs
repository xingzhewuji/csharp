using System;
using System.Collections.Generic;
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
    public partial class FormSearch : Form
    {
        public string date_rec;
        public FormSearch()
        {
            InitializeComponent();
        }
        public FormSearch(string str)
        {
            InitializeComponent();
            date_rec = str;
            checkedListBox1.Items.Insert(0, "3号人员         "+"2号文书                 "+str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            
            label1.Text = "开始建立连接";
            FormSend.MySleep(2000);
            label2.Text = "连接中.";
            FormSend.MySleep(500);
            label2.Text = "连接中..";
            FormSend.MySleep(500);
            label2.Text = "连接中...";
            FormSend.MySleep(500);
            label3.Text = "开始扫描";
            FormSend.MySleep(2000);
            label4.Text = "扫描中.";
            FormSend.MySleep(2000);
            label4.Text = "扫描中..";
            FormSend.MySleep(500);
            label4.Text = "扫描中...";
            FormSend.MySleep(500);
            label4.Text = "扫描中....";
            FormSend.MySleep(500);
            label4.Text = "扫描中.....";
            FormSend.MySleep(500);
            label4.Text = "扫描中......";
            FormSend.MySleep(500);
            label5.Text = "扫描结束";
            FormSend.MySleep(2000);

            //MessageBox.Show("尚未发现新文书");
            label6.Text = "尚未发现新文书";
            label6.Visible = true;
            button3.Visible = true;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormMess f5 = new FormMess("文书标题：2号文书", "下发单位:3号人员", "接收单位:1号人员", "时间:" + date_rec);
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

        private void label8_Click(object sender, EventArgs e)
        {
            FormMess f5 = new FormMess("文书标题：2号文书", "下发单位:3号人员", "接收单位:1号人员", "时间：2019年7月14日 14:29:26");
            f5.TopLevel = false;
            f5.Dock = DockStyle.Fill;
            f5.Parent = this.panel1;
            f5.Show();
            this.panel1.Visible = true;
            f5.FormClosing += Frm_FormClosing8r;//主窗体里订阅子窗体关闭事件
        }
        private void Frm_FormClosing8r(object sender, FormClosingEventArgs e)
        {
            this.panel1.Visible = false;
        }
    }


}

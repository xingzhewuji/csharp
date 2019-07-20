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
        public FormSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible =false;
            button3.Visible = false;
        }
    }


}

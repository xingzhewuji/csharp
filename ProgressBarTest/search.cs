﻿using System;
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
    public partial class search : Form
    {
        public search()
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
            send.MySleep(2000);
            label2.Text = "连接中.";
            send.MySleep(500);
            label2.Text = "连接中..";
            send.MySleep(500);
            label2.Text = "连接中...";
            send.MySleep(500);
            label3.Text = "开始扫描";
            send.MySleep(2000);
            label4.Text = "扫描中.";
            send.MySleep(2000);
            label4.Text = "扫描中..";
            send.MySleep(500);
            label4.Text = "扫描中...";
            send.MySleep(500);
            label4.Text = "扫描中....";
            send.MySleep(500);
            label4.Text = "扫描中.....";
            send.MySleep(500);
            label4.Text = "扫描中......";
            send.MySleep(500);
            label5.Text = "扫描结束";
            send.MySleep(2000);

            MessageBox.Show("尚未发现新文书");
        }
    }


}
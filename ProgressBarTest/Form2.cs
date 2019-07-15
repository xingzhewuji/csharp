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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string[] word_process = new[] { "1号文书", "2号文书", "3号文书" };
            string[] dir_person = new[] { "1号人员", "2号人员", "3号人员", "4号人员", "5号人员", "6号人员" };
            // 初始化cmb
            comboBox1.Items.Add(word_process[0]);
            comboBox1.Items.Add(word_process[1]);
            comboBox1.Items.Add(word_process[2]);

            checkedListBox1.Items.Add(dir_person[0]);
            checkedListBox1.Items.Add(dir_person[1]);
            checkedListBox1.Items.Add(dir_person[2]);
            checkedListBox1.Items.Add(dir_person[3]);
            checkedListBox1.Items.Add(dir_person[4]);
            checkedListBox1.Items.Add(dir_person[5]);
        }
        ProBar pb;
        private delegate bool delegateForProgressBar(int i);
        private delegateForProgressBar dfp;
        public delegate void lab_action();
        //private string[] dir_person=new string[4];
        private string mess;
        public string log;
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern uint GetTickCount();

        private void ShowPB()
        {
            pb = new ProBar();
            dfp = new delegateForProgressBar(pb.IsShowProgressBar);
            pb.StartPosition = FormStartPosition.CenterParent;
            pb.Location = new Point(this.Location.X, this.Location.Y);
            pb.ShowDialog();


        }

        private void ThreadFun()
        {
            object obj = null;
            bool isBool = true;
            while (isBool)
            {
                Thread.Sleep(20);
                obj = this.Invoke(this.dfp, new object[] { 1 });
                isBool = (bool)obj;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mess = null;
            if (comboBox1.SelectedItem == null)
                MessageBox.Show("请选择文书类型");
            else if (Sele())
                MessageBox.Show("请选择接受人员");
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        mess = mess + comboBox1.SelectedItem.ToString() + "----->" + checkedListBox1.GetItemText(checkedListBox1.Items[i]) + "\r\n";
                    }
                }
                DialogResult result = MessageBox.Show(mess, "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    //lab_action a = new lab_action(Lab_action);
                    //Invoke(a);
                    SetLabel();
                    this.BeginInvoke(new MethodInvoker(ShowPB));
                    Thread th = new Thread(new ThreadStart(ThreadFun));
                    th.Start();

                    Lab_action();
                    MessageBox.Show("文件下发成功");

                }
            }
        }
        public bool Sele()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    return false;
                }

            }
            return true;
        }
        private void SetLabel()
        {

            //log =null;
            this.label1.Text = "开始加载文书";
            this.label1.Refresh();
            //log=log+ "开始加载文书-------"+ DateTime.Now.ToString("F")+ "\r\n";
            MySleep(1000);
            this.label2.Text = "加载中.";
            this.label2.Refresh();
            MySleep(200);
            this.label2.Text = "加载中..";
            this.label2.Refresh();
            MySleep(200);
            this.label2.Text = "加载中...";
            this.label2.Refresh();
            MySleep(200);
            this.label2.Text = "加载中....";
            this.label2.Refresh();
            MySleep(200);
            this.label2.Text = "加载中.....";
            this.label2.Refresh();
            MySleep(200);
            this.label2.Text = "加载中......";
            this.label2.Refresh();
            MySleep(1000);
            this.label3.Text = "文书加载完成";
            this.label3.Refresh();
            //log = log + "文书加载完成-------" + DateTime.Now.ToString("F")+ "\r\n";
            MySleep(1000);
            this.label4.Text = "开始建立远程连接";
            this.label4.Refresh();
            // log = log + "开始建立远程连接---" + DateTime.Now.ToString("F")+ "\r\n";
            MySleep(1000);
            this.label5.Text = "连接中.";
            this.label5.Refresh();
            MySleep(200);
            this.label5.Text = "连接中..";
            this.label5.Refresh();
            MySleep(200);
            this.label5.Text = "连接中...";
            this.label5.Refresh();
            MySleep(1000);
            this.label6.Text = "连接成功";
            this.label6.Refresh();
            // log = log + "连接成功-----------" + DateTime.Now.ToString("F") + "\r\n";
            MySleep(1000);
            this.label7.Text = "开始传输";
            this.label7.Refresh();
            // log = log + "开始传输-----------" + DateTime.Now.ToString("F") + "\r\n";
            MySleep(1000);

        }
        public void Lab_action()
        {
            //str = comboBox1.SelectedItem.ToString()+"----->"+ comboBox2.SelectedItem.ToString()+str;
            //this.label8.Text = "传输成功";
            //this.label8.Refresh();
            log = log + "传输成功-----------" + DateTime.Now.ToString("F") + "\r\n";
            MySleep(1000);
            this.label1.Text = null;
            this.label2.Text = null;
            this.label3.Text = null;
            this.label4.Text = null;
            this.label5.Text = null;
            this.label6.Text = null;
            this.label7.Text = null;
            this.label8.Text = null;


            //this.textBox1.AppendText(log + mess + "下发成功-----------" + DateTime.Now.ToString("F") + "\r\n");
            //MessageBox.Show(mess);

            //this.label1.ForeColor = Color.Red;
            //labResult.Refresh();
        }
        static void MySleep(uint ms)
        {
            uint start = GetTickCount();
            while (GetTickCount() - start < ms)
            {
                Application.DoEvents();
            }
        }
    }

}

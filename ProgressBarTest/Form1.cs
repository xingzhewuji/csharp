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
            //string[] log_mess = new[] { "1号文书", "2号人员", "3号人员", "4号人员", "5号人员", "6号人员" };
            
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
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
    }
}

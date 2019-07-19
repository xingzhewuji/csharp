using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}

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
    public partial class ProBar : Form
    {
        public ProBar()
        {
            InitializeComponent();
        }

        private void ProBar_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        public bool IsShowProgressBar(int i)
        {
            if (i > 0)
            {

                if (this.progressBar1.Value +i <= progressBar1.Maximum)
                {
                    this.progressBar1.Value += i;
                    this.label2.Text = this.progressBar1.Value.ToString()+"%";

                    return true;
                }
                else
                {

                    this.progressBar1.Value = progressBar1.Maximum;
                    Thread.Sleep(2000);
                    this.Close();
                    return false;

                }

            }
            else
                return false;

        }
    }
}

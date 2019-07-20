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
    public partial class word_test : Form
    {
        public word_test()
        {
            InitializeComponent();
        }

        private void word_test_Load(object sender, EventArgs e)
        {
            string fullPath = AppDomain.CurrentDomain.BaseDirectory + @"word\web.docx";
            
            OpenWord(fullPath);
        }
        public void OpenWord(string fileName)
        {
            Word.Application app = new Word.Application();//可以打开word
            Word.Document doc = null;      //需要记录打开的word

            object missing = System.Reflection.Missing.Value;
            object File = fileName;
            object readOnly = false;//不是只读
            object isVisible = true;

            object unknow = Type.Missing;

            try
            {
                doc = app.Documents.Open(ref File, ref missing, ref readOnly,
                 ref missing, ref missing, ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing, ref isVisible, ref missing,
                 ref missing, ref missing, ref missing);

                doc.ActiveWindow.Selection.WholeStory();//全选word文档中的数据
                doc.ActiveWindow.Selection.Copy();//复制数据到剪切板
                richTextBox1.Paste();//richTextBox粘贴数据
                                    //richTextBox1.Text = doc.Content.Text;//显示无格式数据
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(ref missing, ref missing, ref missing);
                    doc = null;
                }

                if (app != null)
                {
                    app.Quit(ref missing, ref missing, ref missing);
                    app = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

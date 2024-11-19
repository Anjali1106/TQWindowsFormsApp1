using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void op3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = ".txt";
                DialogResult result = saveFileDialog.ShowDialog();
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                if (result == DialogResult.OK) 
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void op2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text document|*.txt|Word|*.docx|All Files|*.*";
                DialogResult result = openFileDialog.ShowDialog();
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

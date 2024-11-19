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
    public partial class Formdemo3 : Form
    {
        public Formdemo3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // BinaryWriter
                string path = @"D:\DotNet-10AmBatch\emp.dat";  // data file
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtId.Text));
                bw.Write(txtName.Text);
                bw.Write(Convert.ToDouble(txtSalary.Text));
                bw.Close();
                fs.Close(); // fs always open a file in buffer, once we close fs, file will be stored back to secondary storage

                MessageBox.Show("Data added to file");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string path = @"D:\DotNet-10AMBatch";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-10AMBatch\Test.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("Folder is exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-10AMBatch\emp.dat";   // .dat - data file
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString(); // Id
                txtName.Text = br.ReadString(); // Name
                txtSalary.Text = br.ReadDouble().ToString();// Salary
                br.Close();
                fs.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

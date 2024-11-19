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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class ProductFormAssignment : Form
    {
        public ProductFormAssignment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-ProductAssignment";
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtPid.Text));
                bw.Write(txtPname.Text);
                bw.Write(Convert.ToDouble(txtPprice.Text));

                bw.Close();
                fs.Close();
                MessageBox.Show("Data added");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-ProductDemo";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtPid.Text = br.ReadInt32().ToString(); // Id
                txtPname.Text = br.ReadString(); // Name
                txtPprice.Text = br.ReadDouble().ToString();// Salary
                br.Close();
                fs.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-productdemo\Test.txt";
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

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-Productdemo\Test.txt";
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
    }
}

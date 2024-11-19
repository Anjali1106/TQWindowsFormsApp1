using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FindEmpSalary : Form
    {
        public FindEmpSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(boxId.Text);
            string name = boxName.Text;
            decimal basicsalary = decimal.Parse(boxBasicsal.Text);

            decimal hra = basicsalary * 0.2m;
            decimal pf = basicsalary * 0.12m;
            decimal da = basicsalary * 0.15m;
            decimal pt = 200;
            decimal ta = basicsalary * 0.1m;

            decimal grosssalary = basicsalary + hra + da + ta - pf - pt;

            boxHra.Text=hra.ToString();
            boxDa.Text = da.ToString();
            boxPf.Text = pf.ToString();
            boxPt.Text = pt.ToString();
            boxTa.Text = ta.ToString();
            boxGS.Text = grosssalary.ToString();

        }

        private void boxGS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

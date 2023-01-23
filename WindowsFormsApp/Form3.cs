using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtBasic.Text+" "+txtName.Text+" "+txtNumber );
        }

        private void btnCalculatesalary_Click(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(txtBasic.Text);
            double hra = basic * 0.15;
            double Da = basic * 0.17;
            double ta = basic * 0.20;
            double pf = basic * 0.14;
            double total = (basic + hra + ta + Da);
            txtHRA.Text = hra.ToString();
            txtDA.Text = Da.ToString();
            txtTA.Text = ta.ToString();
            txtTotal.Text = total.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtNumber.Clear();
            txtBasic.Clear();
            txtHRA.Clear();
            txtDA.Clear();
            txtTA.Clear();
            txtTotal.Clear();

        }
    }
}

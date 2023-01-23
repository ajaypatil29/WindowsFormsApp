using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsFormsApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\Employee.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtSalary.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Record added to file");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryread_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\Employee.dat", FileMode.Open, FileAccess.Read );
                Employee emp = new Employee();
               
                BinaryFormatter binaryFormatter = new BinaryFormatter();
               emp=(Employee) binaryFormatter.Deserialize(fs);
                
                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtSalary.Text);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();

                SoapFormatter soap = new SoapFormatter();
                emp = (Employee)soap.Deserialize(fs);

                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtSalary.Text);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btlXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\EmployeeXML.xml", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();

                XmlSerializer xml = new XmlSerializer(typeof(Employee));

                emp = (Employee)xml.Deserialize(fs);

                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWRITE_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\EmployeeJson.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtSalary.Text);
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSNread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\EmployeeJson.json", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();

               emp= JsonSerializer.Deserialize<Employee>(fs);

                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

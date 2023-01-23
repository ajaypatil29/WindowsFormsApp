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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillmineDoc\Student.dat",FileMode.Create,FileAccess.Write );
                Student std = new Student();
                std.Id = Convert.ToInt32(txtId.Text);
                std.Name = txtName.Text;
                std.percentage = Convert.ToDouble(txtpercentage.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Record added");



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
                FileStream fs = new FileStream(@"D:\SkillmineDoc\Student.dat", FileMode.Open, FileAccess.Read );
                Student std = new Student();
               

                BinaryFormatter binaryFormatter = new BinaryFormatter();
               std= (Student)binaryFormatter.Deserialize( fs);
                fs.Close();
                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtpercentage.Text = std.percentage.ToString();



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
                FileStream fs = new FileStream(@"D:\SkillmineDoc\StudentSOAP.soap", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Id = Convert.ToInt32(txtId.Text);
                std.Name = txtName.Text;
                std.percentage = Convert.ToDouble(txtpercentage.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Record added");



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
                FileStream fs = new FileStream(@"D:\SkillmineDoc\StudentSOAP.soap", FileMode.Open, FileAccess.Read);
                Student std = new Student();
                

                SoapFormatter soapFormatter = new SoapFormatter();
                std=(Student)soapFormatter.Deserialize(fs);
                fs.Close();
                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtpercentage.Text = std.percentage.ToString();



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
                FileStream fs = new FileStream(@"D:\SkillmineDoc\StudentXML.xml", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Id = Convert.ToInt32(txtId.Text);
                std.Name = txtName.Text;
                std.percentage = Convert.ToDouble(txtpercentage.Text);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof (Student));
                xmlSerializer.Serialize(fs, std);
                fs.Close();
                MessageBox.Show("Record added");
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
                FileStream fs = new FileStream(@"D:\SkillmineDoc\StudentXML.xml", FileMode.Open, FileAccess.Read);
                Student std = new Student();
               

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                std=(Student)xmlSerializer.Deserialize(fs);
                fs.Close(); 
                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtpercentage.Text = std.percentage.ToString();




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
                FileStream fs = new FileStream(@"D:\SkillmineDoc\StudentJSON.json", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.Id = Convert.ToInt32(txtId.Text);
                std.Name = txtName.Text;
                std.percentage = Convert.ToDouble(txtpercentage.Text);
                JsonSerializer.Serialize<Student>(fs, std);
                fs.Close();
                MessageBox.Show("Record added");
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
                FileStream fs = new FileStream(@"D:\SkillmineDoc\StudentJSON.json", FileMode.Open, FileAccess.Read);
                Student std = new Student();
               std= JsonSerializer.Deserialize<Student>(fs);
                fs.Close();
                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtpercentage.Text = std.percentage.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtpercentage.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillmineDoc";
            try
            {
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Directory Already");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created succesfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\skillmineDoc\test1.text";
            try
            {
                if(File.Exists(path))
                {
                    MessageBox.Show("File already exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\skillmineDoc\test1.text";
            try
            {
                if(File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("File deleted Succesfully");
                }
                else
                {
                    MessageBox.Show("File not exist");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\skillmineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtID.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtSal.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\skillmineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtID.Text));
                bw.Write(txtName.Text);
                bw.Write(Convert.ToDouble(txtSal.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("data saved succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"D:\skillminedoc2");

            try
            {
                if (info.Exists)
                {
                    MessageBox.Show("Directory Already");
                }
                else
                {
                    info.Create();
                    MessageBox.Show("Directory created succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@"D:\skillminedoc2\test3.txt");

            try
            {
                if (fileInfo.Exists)
                {
                    MessageBox.Show("Directory Already");
                }
                else
                {
                    fileInfo.Create();
                    MessageBox.Show("Directory created succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@"D:\skillminedoc2\test3.txt");

            try
            {
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                    MessageBox.Show("file deleted successfully");
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

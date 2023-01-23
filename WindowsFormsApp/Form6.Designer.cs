
namespace WindowsFormsApp
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btlXMLRead = new System.Windows.Forms.Button();
            this.btnXMLwrite = new System.Windows.Forms.Button();
            this.btnBinaryread = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapread = new System.Windows.Forms.Button();
            this.btnJSONWRITE = new System.Windows.Forms.Button();
            this.btnJSNread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Enter Employee Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(217, 157);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(166, 22);
            this.txtSalary.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(217, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(166, 22);
            this.txtId.TabIndex = 10;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(51, 157);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(124, 17);
            this.lblsalary.TabIndex = 11;
            this.lblsalary.Text = "Enter Basic Salary";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(51, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(123, 17);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Enter Employee Id";
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(158, 251);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(103, 50);
            this.btnBinaryWrite.TabIndex = 13;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btlXMLRead
            // 
            this.btlXMLRead.Location = new System.Drawing.Point(308, 319);
            this.btlXMLRead.Name = "btlXMLRead";
            this.btlXMLRead.Size = new System.Drawing.Size(106, 47);
            this.btlXMLRead.TabIndex = 14;
            this.btlXMLRead.Text = "XML Read";
            this.btlXMLRead.UseVisualStyleBackColor = true;
            this.btlXMLRead.Click += new System.EventHandler(this.btlXMLRead_Click);
            // 
            // btnXMLwrite
            // 
            this.btnXMLwrite.Location = new System.Drawing.Point(158, 319);
            this.btnXMLwrite.Name = "btnXMLwrite";
            this.btnXMLwrite.Size = new System.Drawing.Size(103, 47);
            this.btnXMLwrite.TabIndex = 15;
            this.btnXMLwrite.Text = "XML write";
            this.btnXMLwrite.UseVisualStyleBackColor = true;
            this.btnXMLwrite.Click += new System.EventHandler(this.btnXMLwrite_Click);
            // 
            // btnBinaryread
            // 
            this.btnBinaryread.Location = new System.Drawing.Point(308, 251);
            this.btnBinaryread.Name = "btnBinaryread";
            this.btnBinaryread.Size = new System.Drawing.Size(106, 50);
            this.btnBinaryread.TabIndex = 16;
            this.btnBinaryread.Text = "Binary read";
            this.btnBinaryread.UseVisualStyleBackColor = true;
            this.btnBinaryread.Click += new System.EventHandler(this.btnBinaryread_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(521, 23);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(103, 47);
            this.btnSoapWrite.TabIndex = 18;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapread
            // 
            this.btnSoapread.Location = new System.Drawing.Point(671, 23);
            this.btnSoapread.Name = "btnSoapread";
            this.btnSoapread.Size = new System.Drawing.Size(106, 47);
            this.btnSoapread.TabIndex = 17;
            this.btnSoapread.Text = "SOAP Read";
            this.btnSoapread.UseVisualStyleBackColor = true;
            this.btnSoapread.Click += new System.EventHandler(this.btnSoapread_Click);
            // 
            // btnJSONWRITE
            // 
            this.btnJSONWRITE.Location = new System.Drawing.Point(521, 98);
            this.btnJSONWRITE.Name = "btnJSONWRITE";
            this.btnJSONWRITE.Size = new System.Drawing.Size(103, 47);
            this.btnJSONWRITE.TabIndex = 20;
            this.btnJSONWRITE.Text = "JSON Write";
            this.btnJSONWRITE.UseVisualStyleBackColor = true;
            this.btnJSONWRITE.Click += new System.EventHandler(this.btnJSONWRITE_Click);
            // 
            // btnJSNread
            // 
            this.btnJSNread.Location = new System.Drawing.Point(671, 98);
            this.btnJSNread.Name = "btnJSNread";
            this.btnJSNread.Size = new System.Drawing.Size(106, 47);
            this.btnJSNread.TabIndex = 19;
            this.btnJSNread.Text = "JSON Read";
            this.btnJSNread.UseVisualStyleBackColor = true;
            this.btnJSNread.Click += new System.EventHandler(this.btnJSNread_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONWRITE);
            this.Controls.Add(this.btnJSNread);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnSoapread);
            this.Controls.Add(this.btnBinaryread);
            this.Controls.Add(this.btnXMLwrite);
            this.Controls.Add(this.btlXMLRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form6";
            this.Text = "SERIALIZATION DEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btlXMLRead;
        private System.Windows.Forms.Button btnXMLwrite;
        private System.Windows.Forms.Button btnBinaryread;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapread;
        private System.Windows.Forms.Button btnJSONWRITE;
        private System.Windows.Forms.Button btnJSNread;
    }
}
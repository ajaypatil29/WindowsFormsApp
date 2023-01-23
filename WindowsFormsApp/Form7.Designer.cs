
namespace WindowsFormsApp
{
    partial class Form7
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBinaryread = new System.Windows.Forms.Button();
            this.btnXMLwrite = new System.Windows.Forms.Button();
            this.btlXMLRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnJSONWRITE = new System.Windows.Forms.Button();
            this.btnJSNread = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapread = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(88, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(110, 17);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Enter Student Id";
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Location = new System.Drawing.Point(88, 158);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(119, 17);
            this.lblpercentage.TabIndex = 17;
            this.lblpercentage.Text = "Enter Percentage";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(254, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(166, 22);
            this.txtId.TabIndex = 16;
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(254, 158);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(166, 22);
            this.txtpercentage.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(254, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 17);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Enter Student Name";
            // 
            // btnBinaryread
            // 
            this.btnBinaryread.Location = new System.Drawing.Point(290, 258);
            this.btnBinaryread.Name = "btnBinaryread";
            this.btnBinaryread.Size = new System.Drawing.Size(106, 50);
            this.btnBinaryread.TabIndex = 22;
            this.btnBinaryread.Text = "Binary read";
            this.btnBinaryread.UseVisualStyleBackColor = true;
            this.btnBinaryread.Click += new System.EventHandler(this.btnBinaryread_Click);
            // 
            // btnXMLwrite
            // 
            this.btnXMLwrite.Location = new System.Drawing.Point(140, 326);
            this.btnXMLwrite.Name = "btnXMLwrite";
            this.btnXMLwrite.Size = new System.Drawing.Size(103, 47);
            this.btnXMLwrite.TabIndex = 21;
            this.btnXMLwrite.Text = "XML write";
            this.btnXMLwrite.UseVisualStyleBackColor = true;
            this.btnXMLwrite.Click += new System.EventHandler(this.btnXMLwrite_Click);
            // 
            // btlXMLRead
            // 
            this.btlXMLRead.Location = new System.Drawing.Point(290, 326);
            this.btlXMLRead.Name = "btlXMLRead";
            this.btlXMLRead.Size = new System.Drawing.Size(106, 47);
            this.btlXMLRead.TabIndex = 20;
            this.btlXMLRead.Text = "XML Read";
            this.btlXMLRead.UseVisualStyleBackColor = true;
            this.btlXMLRead.Click += new System.EventHandler(this.btlXMLRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(140, 258);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(103, 50);
            this.btnBinaryWrite.TabIndex = 19;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnJSONWRITE
            // 
            this.btnJSONWRITE.Location = new System.Drawing.Point(522, 124);
            this.btnJSONWRITE.Name = "btnJSONWRITE";
            this.btnJSONWRITE.Size = new System.Drawing.Size(103, 47);
            this.btnJSONWRITE.TabIndex = 26;
            this.btnJSONWRITE.Text = "JSON Write";
            this.btnJSONWRITE.UseVisualStyleBackColor = true;
            this.btnJSONWRITE.Click += new System.EventHandler(this.btnJSONWRITE_Click);
            // 
            // btnJSNread
            // 
            this.btnJSNread.Location = new System.Drawing.Point(672, 124);
            this.btnJSNread.Name = "btnJSNread";
            this.btnJSNread.Size = new System.Drawing.Size(106, 47);
            this.btnJSNread.TabIndex = 25;
            this.btnJSNread.Text = "JSON Read";
            this.btnJSNread.UseVisualStyleBackColor = true;
            this.btnJSNread.Click += new System.EventHandler(this.btnJSNread_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(522, 49);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(103, 47);
            this.btnSoapWrite.TabIndex = 24;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapread
            // 
            this.btnSoapread.Location = new System.Drawing.Point(672, 49);
            this.btnSoapread.Name = "btnSoapread";
            this.btnSoapread.Size = new System.Drawing.Size(106, 47);
            this.btnSoapread.TabIndex = 23;
            this.btnSoapread.Text = "SOAP Read";
            this.btnSoapread.UseVisualStyleBackColor = true;
            this.btnSoapread.Click += new System.EventHandler(this.btnSoapread_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Location = new System.Drawing.Point(642, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 47);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnJSONWRITE);
            this.Controls.Add(this.btnJSNread);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnSoapread);
            this.Controls.Add(this.btnBinaryread);
            this.Controls.Add(this.btnXMLwrite);
            this.Controls.Add(this.btlXMLRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblpercentage);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBinaryread;
        private System.Windows.Forms.Button btnXMLwrite;
        private System.Windows.Forms.Button btlXMLRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnJSONWRITE;
        private System.Windows.Forms.Button btnJSNread;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapread;
        private System.Windows.Forms.Button btnClear;
    }
}
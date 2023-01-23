
namespace WindowsFormsApp
{
    partial class Form3
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBasicsal = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDa = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblTotalsal = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCalculatesalary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(410, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(283, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter Name";
            // 
            // lblBasicsal
            // 
            this.lblBasicsal.AutoSize = true;
            this.lblBasicsal.Location = new System.Drawing.Point(283, 158);
            this.lblBasicsal.Name = "lblBasicsal";
            this.lblBasicsal.Size = new System.Drawing.Size(124, 17);
            this.lblBasicsal.TabIndex = 3;
            this.lblBasicsal.Text = "Enter Basic Salary";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(283, 111);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(96, 17);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Enter Number";
            // 
            // lblDa
            // 
            this.lblDa.AutoSize = true;
            this.lblDa.Enabled = false;
            this.lblDa.Location = new System.Drawing.Point(283, 325);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(27, 17);
            this.lblDa.TabIndex = 5;
            this.lblDa.Text = "DA";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Enabled = false;
            this.lblHRA.Location = new System.Drawing.Point(283, 283);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(37, 17);
            this.lblHRA.TabIndex = 6;
            this.lblHRA.Text = "HRA";
            this.lblHRA.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Location = new System.Drawing.Point(283, 370);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(26, 17);
            this.lblTA.TabIndex = 7;
            this.lblTA.Text = "TA";
            // 
            // lblTotalsal
            // 
            this.lblTotalsal.AutoSize = true;
            this.lblTotalsal.Enabled = false;
            this.lblTotalsal.Location = new System.Drawing.Point(283, 434);
            this.lblTotalsal.Name = "lblTotalsal";
            this.lblTotalsal.Size = new System.Drawing.Size(84, 17);
            this.lblTotalsal.TabIndex = 8;
            this.lblTotalsal.Text = "Total Salary";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(410, 111);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(168, 22);
            this.txtNumber.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(410, 429);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(168, 22);
            this.txtTotal.TabIndex = 10;
            // 
            // txtTA
            // 
            this.txtTA.Enabled = false;
            this.txtTA.Location = new System.Drawing.Point(410, 365);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(168, 22);
            this.txtTA.TabIndex = 11;
            // 
            // txtDA
            // 
            this.txtDA.Enabled = false;
            this.txtDA.Location = new System.Drawing.Point(410, 320);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(168, 22);
            this.txtDA.TabIndex = 12;
            // 
            // txtHRA
            // 
            this.txtHRA.Enabled = false;
            this.txtHRA.Location = new System.Drawing.Point(410, 278);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(168, 22);
            this.txtHRA.TabIndex = 13;
            this.txtHRA.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtBasic
            // 
            this.txtBasic.AcceptsReturn = true;
            this.txtBasic.Location = new System.Drawing.Point(410, 158);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(168, 22);
            this.txtBasic.TabIndex = 14;
            this.txtBasic.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(708, 63);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalculatesalary
            // 
            this.btnCalculatesalary.Location = new System.Drawing.Point(708, 158);
            this.btnCalculatesalary.Name = "btnCalculatesalary";
            this.btnCalculatesalary.Size = new System.Drawing.Size(75, 23);
            this.btnCalculatesalary.TabIndex = 17;
            this.btnCalculatesalary.Text = "Calculate Salary";
            this.btnCalculatesalary.UseVisualStyleBackColor = true;
            this.btnCalculatesalary.Click += new System.EventHandler(this.btnCalculatesalary_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(878, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 605);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculatesalary);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblTotalsal);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.lblDa);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblBasicsal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBasicsal;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblTotalsal;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCalculatesalary;
        private System.Windows.Forms.Button btnClear;
    }
}
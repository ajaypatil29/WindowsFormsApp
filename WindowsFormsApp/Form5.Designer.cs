
namespace WindowsFormsApp
{
    partial class Form5
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lblDeptLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRead.Location = new System.Drawing.Point(313, 367);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(138, 39);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Binary Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblDeptLocation
            // 
            this.lblDeptLocation.AutoSize = true;
            this.lblDeptLocation.Location = new System.Drawing.Point(142, 228);
            this.lblDeptLocation.Name = "lblDeptLocation";
            this.lblDeptLocation.Size = new System.Drawing.Size(132, 17);
            this.lblDeptLocation.TabIndex = 1;
            this.lblDeptLocation.Text = "Departmet Location";
            this.lblDeptLocation.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(313, 228);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(174, 22);
            this.txtLocation.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(313, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(313, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 22);
            this.txtID.TabIndex = 4;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(139, 146);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(161, 17);
            this.lblDeptName.TabIndex = 5;
            this.lblDeptName.Text = "Enter Department Name";
            this.lblDeptName.Click += new System.EventHandler(this.lblDeptName_Click);
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(139, 76);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(135, 17);
            this.lblDeptId.TabIndex = 6;
            this.lblDeptId.Text = "Enter Department Id";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWrite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWrite.Location = new System.Drawing.Point(313, 306);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(138, 38);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.Text = "Binary Write";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Department Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(618, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblDeptLocation);
            this.Controls.Add(this.btnRead);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblDeptLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
    }
}
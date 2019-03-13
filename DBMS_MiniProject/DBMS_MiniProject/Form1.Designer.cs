namespace DBMS_MiniProject
{
    partial class Form1
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
            this.lbl_StudentForm = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_StudentForm
            // 
            this.lbl_StudentForm.AutoSize = true;
            this.lbl_StudentForm.Location = new System.Drawing.Point(87, 132);
            this.lbl_StudentForm.Name = "lbl_StudentForm";
            this.lbl_StudentForm.Size = new System.Drawing.Size(70, 13);
            this.lbl_StudentForm.TabIndex = 0;
            this.lbl_StudentForm.TabStop = true;
            this.lbl_StudentForm.Text = "Student Form";
            this.lbl_StudentForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_StudentForm_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_StudentForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl_StudentForm;
    }
}


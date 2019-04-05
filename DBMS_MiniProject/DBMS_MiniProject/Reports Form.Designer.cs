namespace DBMS_MiniProject
{
    partial class Reports_Form
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
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_CLO = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Assessment = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.lbl_Validation1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(197, 27);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_CLO
            // 
            this.btn_CLO.Location = new System.Drawing.Point(23, 93);
            this.btn_CLO.Name = "btn_CLO";
            this.btn_CLO.Size = new System.Drawing.Size(75, 23);
            this.btn_CLO.TabIndex = 1;
            this.btn_CLO.Text = "CLO Report";
            this.btn_CLO.UseVisualStyleBackColor = true;
            this.btn_CLO.Click += new System.EventHandler(this.btn_CLO_Click);
            // 
            // btn_Assessment
            // 
            this.btn_Assessment.Location = new System.Drawing.Point(104, 93);
            this.btn_Assessment.Name = "btn_Assessment";
            this.btn_Assessment.Size = new System.Drawing.Size(75, 23);
            this.btn_Assessment.TabIndex = 2;
            this.btn_Assessment.Text = "Assessment Report";
            this.btn_Assessment.UseVisualStyleBackColor = true;
            this.btn_Assessment.Click += new System.EventHandler(this.btn_Assessment_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(23, 27);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.ReadOnly = true;
            this.txt_Path.Size = new System.Drawing.Size(168, 20);
            this.txt_Path.TabIndex = 3;
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(23, 54);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(100, 20);
            this.txt_FileName.TabIndex = 4;
            this.txt_FileName.TextChanged += new System.EventHandler(this.txt_FileName_TextChanged);
            // 
            // lbl_Validation1
            // 
            this.lbl_Validation1.AutoSize = true;
            this.lbl_Validation1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Validation1.Location = new System.Drawing.Point(129, 57);
            this.lbl_Validation1.Name = "lbl_Validation1";
            this.lbl_Validation1.Size = new System.Drawing.Size(38, 13);
            this.lbl_Validation1.TabIndex = 5;
            this.lbl_Validation1.Text = "Invalid";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(63, 133);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(93, 13);
            this.lbl_Status.TabIndex = 6;
            this.lbl_Status.Text = "Choose An Option";
            // 
            // Reports_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Validation1);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.btn_Assessment);
            this.Controls.Add(this.btn_CLO);
            this.Controls.Add(this.btn_Browse);
            this.Name = "Reports_Form";
            this.Text = "Reports_Form";
            this.Load += new System.EventHandler(this.Reports_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_CLO;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Assessment;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Label lbl_Validation1;
        private System.Windows.Forms.Label lbl_Status;
    }
}
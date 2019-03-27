namespace DBMS_MiniProject
{
    partial class Assessment_Form
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_TotalMarks = new System.Windows.Forms.Label();
            this.lbl_TotalWeightage = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_TotalMarks = new System.Windows.Forms.TextBox();
            this.txt_TotalWeightage = new System.Windows.Forms.TextBox();
            this.dgv_Assessment = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Assessment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(31, 52);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_TotalMarks
            // 
            this.lbl_TotalMarks.AutoSize = true;
            this.lbl_TotalMarks.Location = new System.Drawing.Point(31, 84);
            this.lbl_TotalMarks.Name = "lbl_TotalMarks";
            this.lbl_TotalMarks.Size = new System.Drawing.Size(63, 13);
            this.lbl_TotalMarks.TabIndex = 1;
            this.lbl_TotalMarks.Text = "Total Marks";
            // 
            // lbl_TotalWeightage
            // 
            this.lbl_TotalWeightage.AutoSize = true;
            this.lbl_TotalWeightage.Location = new System.Drawing.Point(31, 117);
            this.lbl_TotalWeightage.Name = "lbl_TotalWeightage";
            this.lbl_TotalWeightage.Size = new System.Drawing.Size(86, 13);
            this.lbl_TotalWeightage.TabIndex = 2;
            this.lbl_TotalWeightage.Text = "Total Weightage";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(161, 52);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(100, 20);
            this.txt_Title.TabIndex = 3;
            this.txt_Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_TotalMarks
            // 
            this.txt_TotalMarks.Location = new System.Drawing.Point(161, 84);
            this.txt_TotalMarks.Name = "txt_TotalMarks";
            this.txt_TotalMarks.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalMarks.TabIndex = 4;
            // 
            // txt_TotalWeightage
            // 
            this.txt_TotalWeightage.Location = new System.Drawing.Point(161, 117);
            this.txt_TotalWeightage.Name = "txt_TotalWeightage";
            this.txt_TotalWeightage.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalWeightage.TabIndex = 5;
            // 
            // dgv_Assessment
            // 
            this.dgv_Assessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Assessment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_Assessment.Location = new System.Drawing.Point(21, 155);
            this.dgv_Assessment.Name = "dgv_Assessment";
            this.dgv_Assessment.Size = new System.Drawing.Size(653, 117);
            this.dgv_Assessment.TabIndex = 6;
            this.dgv_Assessment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(326, 52);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(326, 84);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(326, 117);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date Created";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Marks";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Weightage";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Modify";
            this.Column6.Name = "Column6";
            this.Column6.Text = "Edit/Delete";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(488, 110);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(96, 23);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit To Home";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Assessment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 314);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Assessment);
            this.Controls.Add(this.txt_TotalWeightage);
            this.Controls.Add(this.txt_TotalMarks);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.lbl_TotalWeightage);
            this.Controls.Add(this.lbl_TotalMarks);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Assessment_Form";
            this.Text = "Assessment_Form";
            this.Load += new System.EventHandler(this.Assessment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Assessment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_TotalMarks;
        private System.Windows.Forms.Label lbl_TotalWeightage;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_TotalMarks;
        private System.Windows.Forms.TextBox txt_TotalWeightage;
        private System.Windows.Forms.DataGridView dgv_Assessment;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Button btn_Exit;
    }
}
namespace DBMS_MiniProject
{
    partial class AssessmentComponent_Form
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_TotalMarks = new System.Windows.Forms.Label();
            this.lbl_Rubric = new System.Windows.Forms.Label();
            this.lbl_Assessment = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_TotalMarks = new System.Windows.Forms.TextBox();
            this.cb_Rubric = new System.Windows.Forms.ComboBox();
            this.cb_Assessment = new System.Windows.Forms.ComboBox();
            this.dgv_AssessmentComponent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_RubricDetails = new System.Windows.Forms.Label();
            this.txt_RubricDetails = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssessmentComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(25, 47);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_TotalMarks
            // 
            this.lbl_TotalMarks.AutoSize = true;
            this.lbl_TotalMarks.Location = new System.Drawing.Point(25, 70);
            this.lbl_TotalMarks.Name = "lbl_TotalMarks";
            this.lbl_TotalMarks.Size = new System.Drawing.Size(63, 13);
            this.lbl_TotalMarks.TabIndex = 1;
            this.lbl_TotalMarks.Text = "Total Marks";
            // 
            // lbl_Rubric
            // 
            this.lbl_Rubric.AutoSize = true;
            this.lbl_Rubric.Location = new System.Drawing.Point(25, 102);
            this.lbl_Rubric.Name = "lbl_Rubric";
            this.lbl_Rubric.Size = new System.Drawing.Size(47, 13);
            this.lbl_Rubric.TabIndex = 2;
            this.lbl_Rubric.Text = "RubricId";
            // 
            // lbl_Assessment
            // 
            this.lbl_Assessment.AutoSize = true;
            this.lbl_Assessment.Location = new System.Drawing.Point(25, 128);
            this.lbl_Assessment.Name = "lbl_Assessment";
            this.lbl_Assessment.Size = new System.Drawing.Size(63, 13);
            this.lbl_Assessment.TabIndex = 3;
            this.lbl_Assessment.Text = "Assessment";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(142, 47);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_TotalMarks
            // 
            this.txt_TotalMarks.Location = new System.Drawing.Point(142, 70);
            this.txt_TotalMarks.Name = "txt_TotalMarks";
            this.txt_TotalMarks.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalMarks.TabIndex = 5;
            // 
            // cb_Rubric
            // 
            this.cb_Rubric.FormattingEnabled = true;
            this.cb_Rubric.Location = new System.Drawing.Point(142, 99);
            this.cb_Rubric.Name = "cb_Rubric";
            this.cb_Rubric.Size = new System.Drawing.Size(121, 21);
            this.cb_Rubric.TabIndex = 6;
            this.cb_Rubric.SelectedIndexChanged += new System.EventHandler(this.cb_Rubric_SelectedIndexChanged);
            // 
            // cb_Assessment
            // 
            this.cb_Assessment.FormattingEnabled = true;
            this.cb_Assessment.Location = new System.Drawing.Point(142, 128);
            this.cb_Assessment.Name = "cb_Assessment";
            this.cb_Assessment.Size = new System.Drawing.Size(121, 21);
            this.cb_Assessment.TabIndex = 7;
            // 
            // dgv_AssessmentComponent
            // 
            this.dgv_AssessmentComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AssessmentComponent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_AssessmentComponent.Location = new System.Drawing.Point(23, 155);
            this.dgv_AssessmentComponent.Name = "dgv_AssessmentComponent";
            this.dgv_AssessmentComponent.Size = new System.Drawing.Size(844, 94);
            this.dgv_AssessmentComponent.TabIndex = 8;
            this.dgv_AssessmentComponent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AssessmentComponent_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RubricId";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TotalMarks";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DateCreated";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DateUpdated";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "AssessmentId";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Modify";
            this.Column8.Name = "Column8";
            this.Column8.Text = "Edit/Delete";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // lbl_RubricDetails
            // 
            this.lbl_RubricDetails.AutoSize = true;
            this.lbl_RubricDetails.Location = new System.Drawing.Point(351, 98);
            this.lbl_RubricDetails.Name = "lbl_RubricDetails";
            this.lbl_RubricDetails.Size = new System.Drawing.Size(39, 13);
            this.lbl_RubricDetails.TabIndex = 9;
            this.lbl_RubricDetails.Text = "Details";
            this.lbl_RubricDetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_RubricDetails
            // 
            this.txt_RubricDetails.Location = new System.Drawing.Point(396, 95);
            this.txt_RubricDetails.Name = "txt_RubricDetails";
            this.txt_RubricDetails.Size = new System.Drawing.Size(100, 20);
            this.txt_RubricDetails.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(531, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(531, 47);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(531, 76);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(663, 76);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(85, 23);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Exit To Home";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // AssessmentComponent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 310);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_RubricDetails);
            this.Controls.Add(this.lbl_RubricDetails);
            this.Controls.Add(this.dgv_AssessmentComponent);
            this.Controls.Add(this.cb_Assessment);
            this.Controls.Add(this.cb_Rubric);
            this.Controls.Add(this.txt_TotalMarks);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Assessment);
            this.Controls.Add(this.lbl_Rubric);
            this.Controls.Add(this.lbl_TotalMarks);
            this.Controls.Add(this.lbl_Name);
            this.Name = "AssessmentComponent_Form";
            this.Text = "AssessmentComponent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssessmentComponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_TotalMarks;
        private System.Windows.Forms.Label lbl_Rubric;
        private System.Windows.Forms.Label lbl_Assessment;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_TotalMarks;
        private System.Windows.Forms.ComboBox cb_Rubric;
        private System.Windows.Forms.ComboBox cb_Assessment;
        private System.Windows.Forms.DataGridView dgv_AssessmentComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.Label lbl_RubricDetails;
        private System.Windows.Forms.TextBox txt_RubricDetails;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
    }
}
namespace DBMS_MiniProject
{
    partial class StudentResult_Form
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
            this.lbl_Assessment = new System.Windows.Forms.Label();
            this.lbl_Student = new System.Windows.Forms.Label();
            this.cb_Assessment = new System.Windows.Forms.ComboBox();
            this.cb_Student = new System.Windows.Forms.ComboBox();
            this.flp_Student = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.dgv_StudentResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Assessment
            // 
            this.lbl_Assessment.AutoSize = true;
            this.lbl_Assessment.Location = new System.Drawing.Point(30, 32);
            this.lbl_Assessment.Name = "lbl_Assessment";
            this.lbl_Assessment.Size = new System.Drawing.Size(63, 13);
            this.lbl_Assessment.TabIndex = 0;
            this.lbl_Assessment.Text = "Assessment";
            // 
            // lbl_Student
            // 
            this.lbl_Student.AutoSize = true;
            this.lbl_Student.Location = new System.Drawing.Point(30, 71);
            this.lbl_Student.Name = "lbl_Student";
            this.lbl_Student.Size = new System.Drawing.Size(44, 13);
            this.lbl_Student.TabIndex = 1;
            this.lbl_Student.Text = "Student";
            // 
            // cb_Assessment
            // 
            this.cb_Assessment.FormattingEnabled = true;
            this.cb_Assessment.Location = new System.Drawing.Point(113, 32);
            this.cb_Assessment.Name = "cb_Assessment";
            this.cb_Assessment.Size = new System.Drawing.Size(121, 21);
            this.cb_Assessment.TabIndex = 2;
            this.cb_Assessment.SelectedIndexChanged += new System.EventHandler(this.cb_Assessment_SelectedIndexChanged);
            // 
            // cb_Student
            // 
            this.cb_Student.FormattingEnabled = true;
            this.cb_Student.Location = new System.Drawing.Point(113, 71);
            this.cb_Student.Name = "cb_Student";
            this.cb_Student.Size = new System.Drawing.Size(121, 21);
            this.cb_Student.TabIndex = 3;
            this.cb_Student.SelectedIndexChanged += new System.EventHandler(this.cb_Student_SelectedIndexChanged);
            // 
            // flp_Student
            // 
            this.flp_Student.Location = new System.Drawing.Point(12, 140);
            this.flp_Student.Name = "flp_Student";
            this.flp_Student.Size = new System.Drawing.Size(505, 162);
            this.flp_Student.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(337, 32);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(86, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit To Home";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(348, 94);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dgv_StudentResult
            // 
            this.dgv_StudentResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5});
            this.dgv_StudentResult.Location = new System.Drawing.Point(523, 32);
            this.dgv_StudentResult.Name = "dgv_StudentResult";
            this.dgv_StudentResult.Size = new System.Drawing.Size(745, 270);
            this.dgv_StudentResult.TabIndex = 7;
            this.dgv_StudentResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentResult_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "StudentId";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Assessment";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Component";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rubric";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Level";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "EvaluationDate";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Modify";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Edit/Delete";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(348, 65);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // StudentResult_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 314);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_StudentResult);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.flp_Student);
            this.Controls.Add(this.cb_Student);
            this.Controls.Add(this.cb_Assessment);
            this.Controls.Add(this.lbl_Student);
            this.Controls.Add(this.lbl_Assessment);
            this.Name = "StudentResult_Form";
            this.Text = "StudentResult_Form";
            this.Load += new System.EventHandler(this.StudentResult_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Assessment;
        private System.Windows.Forms.Label lbl_Student;
        private System.Windows.Forms.ComboBox cb_Assessment;
        private System.Windows.Forms.ComboBox cb_Student;
        private System.Windows.Forms.FlowLayoutPanel flp_Student;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridView dgv_StudentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button btn_Delete;
    }
}
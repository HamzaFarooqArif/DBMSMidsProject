namespace DBMS_MiniProject
{
    partial class StudentAttendance_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.cb_ClassAttendance = new System.Windows.Forms.ComboBox();
            this.lbl_Attendance = new System.Windows.Forms.Label();
            this.dgv_StudentAttendance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flp_StudentAttendance = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Manually = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get For Today";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_ClassAttendance
            // 
            this.cb_ClassAttendance.FormattingEnabled = true;
            this.cb_ClassAttendance.Location = new System.Drawing.Point(100, 12);
            this.cb_ClassAttendance.Name = "cb_ClassAttendance";
            this.cb_ClassAttendance.Size = new System.Drawing.Size(121, 21);
            this.cb_ClassAttendance.TabIndex = 1;
            this.cb_ClassAttendance.SelectedIndexChanged += new System.EventHandler(this.cb_ClassAttendance_SelectedIndexChanged);
            // 
            // lbl_Attendance
            // 
            this.lbl_Attendance.AutoSize = true;
            this.lbl_Attendance.Location = new System.Drawing.Point(12, 12);
            this.lbl_Attendance.Name = "lbl_Attendance";
            this.lbl_Attendance.Size = new System.Drawing.Size(62, 13);
            this.lbl_Attendance.TabIndex = 2;
            this.lbl_Attendance.Text = "Attendance";
            // 
            // dgv_StudentAttendance
            // 
            this.dgv_StudentAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_StudentAttendance.Location = new System.Drawing.Point(414, 12);
            this.dgv_StudentAttendance.Name = "dgv_StudentAttendance";
            this.dgv_StudentAttendance.Size = new System.Drawing.Size(448, 237);
            this.dgv_StudentAttendance.TabIndex = 3;
            this.dgv_StudentAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentAttendance_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AttendanceId";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "StudentId";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modify";
            this.Column4.Name = "Column4";
            this.Column4.Text = "Edit/Delete";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // flp_StudentAttendance
            // 
            this.flp_StudentAttendance.Location = new System.Drawing.Point(12, 93);
            this.flp_StudentAttendance.Name = "flp_StudentAttendance";
            this.flp_StudentAttendance.Size = new System.Drawing.Size(396, 156);
            this.flp_StudentAttendance.TabIndex = 4;
            // 
            // btn_Manually
            // 
            this.btn_Manually.Location = new System.Drawing.Point(278, 39);
            this.btn_Manually.Name = "btn_Manually";
            this.btn_Manually.Size = new System.Drawing.Size(100, 23);
            this.btn_Manually.TabIndex = 5;
            this.btn_Manually.Text = "Create Now";
            this.btn_Manually.UseVisualStyleBackColor = true;
            this.btn_Manually.Click += new System.EventHandler(this.btn_Manually_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(278, 64);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(100, 23);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(106, 67);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(84, 23);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit To Home";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(197, 67);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // StudentAttendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 261);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Manually);
            this.Controls.Add(this.flp_StudentAttendance);
            this.Controls.Add(this.dgv_StudentAttendance);
            this.Controls.Add(this.lbl_Attendance);
            this.Controls.Add(this.cb_ClassAttendance);
            this.Controls.Add(this.button1);
            this.Name = "StudentAttendance_Form";
            this.Text = "StudentAttendance_Form";
            this.Load += new System.EventHandler(this.StudentAttendance_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_ClassAttendance;
        private System.Windows.Forms.Label lbl_Attendance;
        private System.Windows.Forms.DataGridView dgv_StudentAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.FlowLayoutPanel flp_StudentAttendance;
        private System.Windows.Forms.Button btn_Manually;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
    }
}
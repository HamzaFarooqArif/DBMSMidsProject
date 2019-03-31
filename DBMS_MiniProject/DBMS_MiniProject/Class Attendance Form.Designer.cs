namespace DBMS_MiniProject
{
    partial class Class_Attendance_Form
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
            this.dtp_ClassAttendance = new System.Windows.Forms.DateTimePicker();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_ClassAttendance = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ClassAttendance
            // 
            this.dtp_ClassAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ClassAttendance.Location = new System.Drawing.Point(134, 12);
            this.dtp_ClassAttendance.Name = "dtp_ClassAttendance";
            this.dtp_ClassAttendance.Size = new System.Drawing.Size(105, 20);
            this.dtp_ClassAttendance.TabIndex = 2;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(182, 47);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "Add";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 47);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // dgv_ClassAttendance
            // 
            this.dgv_ClassAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClassAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_ClassAttendance.Location = new System.Drawing.Point(12, 99);
            this.dgv_ClassAttendance.Name = "dgv_ClassAttendance";
            this.dgv_ClassAttendance.Size = new System.Drawing.Size(352, 150);
            this.dgv_ClassAttendance.TabIndex = 5;
            this.dgv_ClassAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ClassAttendance_CellContentClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(263, 47);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit To Home";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(93, 47);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modify";
            this.Column3.Name = "Column3";
            this.Column3.Text = "Edit/Delete";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // Class_Attendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dgv_ClassAttendance);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.dtp_ClassAttendance);
            this.Name = "Class_Attendance_Form";
            this.Text = "Class_Attendance_Form";
            this.Load += new System.EventHandler(this.Class_Attendance_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ClassAttendance;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_ClassAttendance;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}
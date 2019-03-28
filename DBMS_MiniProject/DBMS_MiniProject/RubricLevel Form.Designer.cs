namespace DBMS_MiniProject
{
    partial class RubricLevel_Form
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
            this.lbl_Details = new System.Windows.Forms.Label();
            this.lbl_MeasurementLevel = new System.Windows.Forms.Label();
            this.txt_Details = new System.Windows.Forms.TextBox();
            this.txt_MeasurementLevel = new System.Windows.Forms.TextBox();
            this.lbl_Rubric = new System.Windows.Forms.Label();
            this.cb_Rubric = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RubricDetails = new System.Windows.Forms.TextBox();
            this.dgv_RubricLevel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RubricLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Location = new System.Drawing.Point(12, 44);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(39, 13);
            this.lbl_Details.TabIndex = 0;
            this.lbl_Details.Text = "Details";
            // 
            // lbl_MeasurementLevel
            // 
            this.lbl_MeasurementLevel.AutoSize = true;
            this.lbl_MeasurementLevel.Location = new System.Drawing.Point(12, 73);
            this.lbl_MeasurementLevel.Name = "lbl_MeasurementLevel";
            this.lbl_MeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lbl_MeasurementLevel.TabIndex = 1;
            this.lbl_MeasurementLevel.Text = "Measurement Level";
            // 
            // txt_Details
            // 
            this.txt_Details.Location = new System.Drawing.Point(144, 37);
            this.txt_Details.Name = "txt_Details";
            this.txt_Details.Size = new System.Drawing.Size(100, 20);
            this.txt_Details.TabIndex = 2;
            // 
            // txt_MeasurementLevel
            // 
            this.txt_MeasurementLevel.Location = new System.Drawing.Point(144, 73);
            this.txt_MeasurementLevel.Name = "txt_MeasurementLevel";
            this.txt_MeasurementLevel.Size = new System.Drawing.Size(100, 20);
            this.txt_MeasurementLevel.TabIndex = 3;
            // 
            // lbl_Rubric
            // 
            this.lbl_Rubric.AutoSize = true;
            this.lbl_Rubric.Location = new System.Drawing.Point(16, 108);
            this.lbl_Rubric.Name = "lbl_Rubric";
            this.lbl_Rubric.Size = new System.Drawing.Size(38, 13);
            this.lbl_Rubric.TabIndex = 4;
            this.lbl_Rubric.Text = "Rubric";
            // 
            // cb_Rubric
            // 
            this.cb_Rubric.FormattingEnabled = true;
            this.cb_Rubric.Location = new System.Drawing.Point(144, 105);
            this.cb_Rubric.Name = "cb_Rubric";
            this.cb_Rubric.Size = new System.Drawing.Size(121, 21);
            this.cb_Rubric.TabIndex = 5;
            this.cb_Rubric.SelectedIndexChanged += new System.EventHandler(this.cb_Rubric_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Details";
            // 
            // txt_RubricDetails
            // 
            this.txt_RubricDetails.Location = new System.Drawing.Point(350, 113);
            this.txt_RubricDetails.Name = "txt_RubricDetails";
            this.txt_RubricDetails.Size = new System.Drawing.Size(100, 20);
            this.txt_RubricDetails.TabIndex = 7;
            // 
            // dgv_RubricLevel
            // 
            this.dgv_RubricLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RubricLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_RubricLevel.Location = new System.Drawing.Point(15, 153);
            this.dgv_RubricLevel.Name = "dgv_RubricLevel";
            this.dgv_RubricLevel.Size = new System.Drawing.Size(556, 150);
            this.dgv_RubricLevel.TabIndex = 8;
            this.dgv_RubricLevel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RubricLevel_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RubricId";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Details";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Measurement Level";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Modify";
            this.Column5.Name = "Column5";
            this.Column5.Text = "Edit/Delete";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(350, 25);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(350, 54);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(350, 83);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(477, 73);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 23);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit To Home";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // RubricLevel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 322);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_RubricLevel);
            this.Controls.Add(this.txt_RubricDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Rubric);
            this.Controls.Add(this.lbl_Rubric);
            this.Controls.Add(this.txt_MeasurementLevel);
            this.Controls.Add(this.txt_Details);
            this.Controls.Add(this.lbl_MeasurementLevel);
            this.Controls.Add(this.lbl_Details);
            this.Name = "RubricLevel_Form";
            this.Text = "RubricLevel_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RubricLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_MeasurementLevel;
        private System.Windows.Forms.TextBox txt_Details;
        private System.Windows.Forms.TextBox txt_MeasurementLevel;
        private System.Windows.Forms.Label lbl_Rubric;
        private System.Windows.Forms.ComboBox cb_Rubric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RubricDetails;
        private System.Windows.Forms.DataGridView dgv_RubricLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
    }
}
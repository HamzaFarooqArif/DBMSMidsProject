namespace DBMS_MiniProject
{
    partial class Rubric_Form
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
            this.lbl_Clo = new System.Windows.Forms.Label();
            this.txt_Details = new System.Windows.Forms.TextBox();
            this.cb_Clo = new System.Windows.Forms.ComboBox();
            this.dgv_Rubric = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rubric)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Details
            // 
            this.lbl_Details.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Location = new System.Drawing.Point(3, 6);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(39, 13);
            this.lbl_Details.TabIndex = 0;
            this.lbl_Details.Text = "Details";
            // 
            // lbl_Clo
            // 
            this.lbl_Clo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Clo.AutoSize = true;
            this.lbl_Clo.Location = new System.Drawing.Point(3, 31);
            this.lbl_Clo.Name = "lbl_Clo";
            this.lbl_Clo.Size = new System.Drawing.Size(28, 13);
            this.lbl_Clo.TabIndex = 1;
            this.lbl_Clo.Text = "CLO";
            // 
            // txt_Details
            // 
            this.txt_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Details.Location = new System.Drawing.Point(53, 3);
            this.txt_Details.Name = "txt_Details";
            this.txt_Details.Size = new System.Drawing.Size(313, 20);
            this.txt_Details.TabIndex = 2;
            // 
            // cb_Clo
            // 
            this.cb_Clo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_Clo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Clo.FormattingEnabled = true;
            this.cb_Clo.Location = new System.Drawing.Point(53, 28);
            this.cb_Clo.Name = "cb_Clo";
            this.cb_Clo.Size = new System.Drawing.Size(313, 21);
            this.cb_Clo.TabIndex = 3;
            this.cb_Clo.SelectedIndexChanged += new System.EventHandler(this.cb_Clo_SelectedIndexChanged);
            // 
            // dgv_Rubric
            // 
            this.dgv_Rubric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Rubric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Rubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rubric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_Rubric.Location = new System.Drawing.Point(12, 132);
            this.dgv_Rubric.Name = "dgv_Rubric";
            this.dgv_Rubric.Size = new System.Drawing.Size(369, 225);
            this.dgv_Rubric.TabIndex = 4;
            this.dgv_Rubric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Rubric_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Details";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CLO Detail";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modify";
            this.Column4.Name = "Column4";
            this.Column4.Text = "Edit/Delete";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(86, 26);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Update.Location = new System.Drawing.Point(95, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 26);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.Location = new System.Drawing.Point(187, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 26);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Exit.Location = new System.Drawing.Point(279, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(87, 26);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit To Home";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Details, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Clo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Details, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Clo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 51);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Exit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Update, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Delete, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 94);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 32);
            this.tableLayoutPanel2.TabIndex = 10;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.Location = new System.Drawing.Point(121, 9);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(144, 25);
            this.lbl_Heading.TabIndex = 11;
            this.lbl_Heading.Text = "Manage Rubric";
            // 
            // Rubric_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 369);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv_Rubric);
            this.MinimumSize = new System.Drawing.Size(409, 408);
            this.Name = "Rubric_Form";
            this.Text = "Rubric_Form";
            this.Load += new System.EventHandler(this.Rubric_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rubric)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_Clo;
        private System.Windows.Forms.TextBox txt_Details;
        private System.Windows.Forms.ComboBox cb_Clo;
        private System.Windows.Forms.DataGridView dgv_Rubric;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Heading;
    }
}
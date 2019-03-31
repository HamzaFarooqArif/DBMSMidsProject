﻿namespace DBMS_MiniProject
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
            this.lbl_Clo = new System.Windows.Forms.LinkLabel();
            this.lbl_RubricForm = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_AssessmentForm = new System.Windows.Forms.LinkLabel();
            this.lnk_AssessmentComponent = new System.Windows.Forms.LinkLabel();
            this.lnk_RubricLevel = new System.Windows.Forms.LinkLabel();
            this.lbl_StudentResult = new System.Windows.Forms.LinkLabel();
            this.lnk_StudentAttendance = new System.Windows.Forms.LinkLabel();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.lnk_ClassAttendance = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_StudentForm
            // 
            this.lbl_StudentForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_StudentForm.AutoSize = true;
            this.lbl_StudentForm.Location = new System.Drawing.Point(95, 7);
            this.lbl_StudentForm.Name = "lbl_StudentForm";
            this.lbl_StudentForm.Size = new System.Drawing.Size(70, 13);
            this.lbl_StudentForm.TabIndex = 0;
            this.lbl_StudentForm.TabStop = true;
            this.lbl_StudentForm.Text = "Student Form";
            this.lbl_StudentForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_StudentForm_LinkClicked);
            // 
            // lbl_Clo
            // 
            this.lbl_Clo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Clo.AutoSize = true;
            this.lbl_Clo.Location = new System.Drawing.Point(103, 175);
            this.lbl_Clo.Name = "lbl_Clo";
            this.lbl_Clo.Size = new System.Drawing.Size(54, 13);
            this.lbl_Clo.TabIndex = 1;
            this.lbl_Clo.TabStop = true;
            this.lbl_Clo.Text = "CLO Form";
            this.lbl_Clo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Clo_LinkClicked);
            // 
            // lbl_RubricForm
            // 
            this.lbl_RubricForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_RubricForm.AutoSize = true;
            this.lbl_RubricForm.Location = new System.Drawing.Point(98, 203);
            this.lbl_RubricForm.Name = "lbl_RubricForm";
            this.lbl_RubricForm.Size = new System.Drawing.Size(64, 13);
            this.lbl_RubricForm.TabIndex = 2;
            this.lbl_RubricForm.TabStop = true;
            this.lbl_RubricForm.Text = "Rubric Form";
            this.lbl_RubricForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_RubricForm_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_StudentForm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnk_AssessmentComponent, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_AssessmentForm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Clo, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_StudentResult, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_RubricForm, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lnk_StudentAttendance, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lnk_RubricLevel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lnk_ClassAttendance, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 257);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_AssessmentForm
            // 
            this.lbl_AssessmentForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AssessmentForm.AutoSize = true;
            this.lbl_AssessmentForm.Location = new System.Drawing.Point(85, 119);
            this.lbl_AssessmentForm.Name = "lbl_AssessmentForm";
            this.lbl_AssessmentForm.Size = new System.Drawing.Size(89, 13);
            this.lbl_AssessmentForm.TabIndex = 3;
            this.lbl_AssessmentForm.TabStop = true;
            this.lbl_AssessmentForm.Text = "Assessment Form";
            this.lbl_AssessmentForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_AssessmentForm_LinkClicked);
            // 
            // lnk_AssessmentComponent
            // 
            this.lnk_AssessmentComponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnk_AssessmentComponent.AutoSize = true;
            this.lnk_AssessmentComponent.Location = new System.Drawing.Point(57, 147);
            this.lnk_AssessmentComponent.Name = "lnk_AssessmentComponent";
            this.lnk_AssessmentComponent.Size = new System.Drawing.Size(146, 13);
            this.lnk_AssessmentComponent.TabIndex = 4;
            this.lnk_AssessmentComponent.TabStop = true;
            this.lnk_AssessmentComponent.Text = "Assessment Component Form";
            this.lnk_AssessmentComponent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_AssessmentComponent_LinkClicked);
            // 
            // lnk_RubricLevel
            // 
            this.lnk_RubricLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnk_RubricLevel.AutoSize = true;
            this.lnk_RubricLevel.Location = new System.Drawing.Point(83, 234);
            this.lnk_RubricLevel.Name = "lnk_RubricLevel";
            this.lnk_RubricLevel.Size = new System.Drawing.Size(93, 13);
            this.lnk_RubricLevel.TabIndex = 5;
            this.lnk_RubricLevel.TabStop = true;
            this.lnk_RubricLevel.Text = "Rubric Level Form";
            this.lnk_RubricLevel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_RubricLevel_LinkClicked);
            // 
            // lbl_StudentResult
            // 
            this.lbl_StudentResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_StudentResult.AutoSize = true;
            this.lbl_StudentResult.Location = new System.Drawing.Point(78, 35);
            this.lbl_StudentResult.Name = "lbl_StudentResult";
            this.lbl_StudentResult.Size = new System.Drawing.Size(103, 13);
            this.lbl_StudentResult.TabIndex = 6;
            this.lbl_StudentResult.TabStop = true;
            this.lbl_StudentResult.Text = "Student Result Form";
            this.lbl_StudentResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_StudentResult_LinkClicked);
            // 
            // lnk_StudentAttendance
            // 
            this.lnk_StudentAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnk_StudentAttendance.AutoSize = true;
            this.lnk_StudentAttendance.Location = new System.Drawing.Point(79, 63);
            this.lnk_StudentAttendance.Name = "lnk_StudentAttendance";
            this.lnk_StudentAttendance.Size = new System.Drawing.Size(102, 13);
            this.lnk_StudentAttendance.TabIndex = 7;
            this.lnk_StudentAttendance.TabStop = true;
            this.lnk_StudentAttendance.Text = "Student Attendance";
            this.lnk_StudentAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_StudentAttendance_LinkClicked);
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.Location = new System.Drawing.Point(72, 9);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(154, 25);
            this.lbl_Heading.TabIndex = 12;
            this.lbl_Heading.Text = "Navigation Form";
            // 
            // lnk_ClassAttendance
            // 
            this.lnk_ClassAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnk_ClassAttendance.AutoSize = true;
            this.lnk_ClassAttendance.Location = new System.Drawing.Point(72, 91);
            this.lnk_ClassAttendance.Name = "lnk_ClassAttendance";
            this.lnk_ClassAttendance.Size = new System.Drawing.Size(116, 13);
            this.lnk_ClassAttendance.TabIndex = 8;
            this.lnk_ClassAttendance.TabStop = true;
            this.lnk_ClassAttendance.Text = "Class Attendance Form";
            this.lnk_ClassAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ClassAttendance_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "Form1";
            this.Text = "Index_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl_StudentForm;
        private System.Windows.Forms.LinkLabel lbl_Clo;
        private System.Windows.Forms.LinkLabel lbl_RubricForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.LinkLabel lbl_AssessmentForm;
        private System.Windows.Forms.LinkLabel lnk_AssessmentComponent;
        private System.Windows.Forms.LinkLabel lnk_RubricLevel;
        private System.Windows.Forms.LinkLabel lbl_StudentResult;
        private System.Windows.Forms.LinkLabel lnk_StudentAttendance;
        private System.Windows.Forms.LinkLabel lnk_ClassAttendance;
    }
}


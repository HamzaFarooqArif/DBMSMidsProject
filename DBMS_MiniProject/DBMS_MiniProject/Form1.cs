﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_MiniProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lbl_StudentForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Form.getInstance().Show();
            this.Hide();
        }

        private void lbl_Clo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLO_Form.getInstance().Show();
            this.Hide();
        }
    }
}

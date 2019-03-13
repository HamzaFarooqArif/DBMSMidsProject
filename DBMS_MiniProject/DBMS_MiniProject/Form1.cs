using System;
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
        public static Form1 index_Form = null;
        public static Form1 getInstance()
        {
            if (index_Form == null)
            {
                index_Form = new Form1();
            }
            ClearControls(index_Form);
            return index_Form;
        }
        private static void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

                if (c.HasChildren)
                    ClearControls(c);
            }
        }
        private Form1()
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

        private void lbl_RubricForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubric_Form.getInstance().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

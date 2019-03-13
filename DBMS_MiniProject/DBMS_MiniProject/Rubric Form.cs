﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_MiniProject
{
    public partial class Rubric_Form : Form
    {
        private static Rubric_Form rubric_Form = null;
        private static Rubric currentObject = new Rubric("Empty", -1);

        public static Rubric_Form getInstance()
        {
            if (rubric_Form == null)
            {
                Rubric_Form result = new Rubric_Form();
                return result;
            }
            else
            {
                return rubric_Form;
            }
        }
        private Rubric_Form()
        {
            InitializeComponent();
        }

        private void updateDGVRubric()
        {
            dgv_Rubric.Rows.Clear();
            List<Rubric> rubricList = Rubric.retrieveRubrics();
            foreach (Rubric rb in rubricList)
            {
                int n = dgv_Rubric.Rows.Add();
                dgv_Rubric.Rows[n].Cells[0].Value = rb.Id;
                dgv_Rubric.Rows[n].Cells[1].Value = rb.Details;
                dgv_Rubric.Rows[n].Cells[2].Value = Clo.getClobyId(rb.CloId).Name;
            }
        }

        private void cb_Clo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rubric_Form_Load(object sender, EventArgs e)
        {
            updateDGVRubric();
            List<Clo> cloList = Clo.retrieveClos();
            foreach (Clo cl in cloList)
            {
                cb_Clo.Items.Add(cl.Name);
            }
        }
        private void loadCurrentObject()
        {
            txt_Details.Text = currentObject.Details;
            cb_Clo.Text = Clo.getClobyId(currentObject.CloId).Name;
        }
        private void setCurrentObject()
        {
            currentObject.Details = txt_Details.Text;
            currentObject.CloId = Clo.getClo(cb_Clo.Text).Id;
        }
        private void loadBlank()
        {
            txt_Details.Clear();
        }
        private bool isBlank()
        {
            if (
                string.IsNullOrWhiteSpace(txt_Details.Text) ||
                string.IsNullOrWhiteSpace(cb_Clo.Text)
               ) return true;
            else return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (isBlank())
            {
                MessageBox.Show("Warning: Check Input Fields");
                return;
            }
            currentObject.Id = -1;
            currentObject.Details = txt_Details.Text;
            currentObject.CloId = Clo.getClo(cb_Clo.Text).Id;

            if (currentObject.CloId == -1) MessageBox.Show("Warning: Select a valid CLO!");
            else
            {
                if (Rubric.addRubric(currentObject) == 1) MessageBox.Show("Added Successfully");
                else MessageBox.Show("Error: Add Failed");
            }
            updateDGVRubric();
            loadBlank();
            currentObject.Id = -1;
        }

        private void dgv_Rubric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                currentObject.Id = Convert.ToInt32(dgv_Rubric.Rows[e.RowIndex].Cells["Column1"].Value);
                currentObject.Details = dgv_Rubric.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                currentObject.CloId = Clo.getClo(dgv_Rubric.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString()).Id;

                loadCurrentObject();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (isBlank())
            {
                MessageBox.Show("Warning: Check Input Fields");
                return;
            }
            if (currentObject.Id == -1) MessageBox.Show("Warning: Select An Object First!");
            else
            {
                if (currentObject.CloId == -1) MessageBox.Show("Warning: Select a valid CLO!");
                setCurrentObject();
                int msg = Rubric.addRubric(currentObject);
                if (msg == 0) MessageBox.Show("Error: Update Unsuccessful!");
                if (msg == 1) MessageBox.Show("Added Successfully!");
                if (msg == 2) MessageBox.Show("Updated Successfully!");
                updateDGVRubric();
                loadBlank();
                currentObject.Id = -1;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (currentObject.Id == -1)
            {
                MessageBox.Show("Warning: Select An Object First!");
                return;
            }
            if (isBlank())
            {
                MessageBox.Show("Warning: Check Input Fields");
                return;
            }
            if (Rubric.deleteRubricById(currentObject.Id)) MessageBox.Show("Deleted Successfully");
            else MessageBox.Show("Error: Delete Failed");
            updateDGVRubric();
            loadBlank();
            currentObject.Id = -1;
        }
    }
}
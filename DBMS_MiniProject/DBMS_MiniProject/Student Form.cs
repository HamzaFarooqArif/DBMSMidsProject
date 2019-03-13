using System;
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
    public partial class Student_Form : Form
    {
        private static Student_Form student_Form = null;
        private static Student currentObject = new Student("Empty", "Empty", "Empty", "Empty", "Empty", -1);
        public static Student_Form getInstance()
        {
            if(student_Form == null)
            {
                Student_Form result = new Student_Form();
                return result;
            }
            else
            {
                return student_Form;
            }
        }
        private Student_Form()
        {
            InitializeComponent();
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            updateDGVStudent();
            List<Lookup> lookupList = Lookup.retrieveLookupsByCategory("STUDENT_STATUS");
            foreach(Lookup lk in lookupList)
            {
                cb_status.Items.Add(lk.Name);
            }
        }

        private void updateDGVStudent()
        {
            dgv_Student.Rows.Clear();
            List<Student> studentList = Student.retrieveStudents();
            foreach(Student st in studentList)
            {
                int n = dgv_Student.Rows.Add();
                dgv_Student.Rows[n].Cells[0].Value = st.Id;
                dgv_Student.Rows[n].Cells[1].Value = st.FirstName;
                dgv_Student.Rows[n].Cells[2].Value = st.LastName;
                dgv_Student.Rows[n].Cells[3].Value = st.Contact;
                dgv_Student.Rows[n].Cells[4].Value = st.Email;
                dgv_Student.Rows[n].Cells[5].Value = st.RegistrationNumber;
                dgv_Student.Rows[n].Cells[6].Value = Lookup.getLookupById(st.Status).Name;
            }
        }

        private void loadCurrentObject()
        {
            txt_FirstName.Text = currentObject.FirstName;
            txt_LastName.Text = currentObject.LastName;
            txt_Contact.Text = currentObject.Contact;
            txt_Email.Text = currentObject.Email;
            txt_RegistrationNumber.Text = currentObject.RegistrationNumber;
            if (currentObject.Status == 5) cb_status.Text = "Active";
            else cb_status.Text = "InActive";
        }
        private void setCurrentObject()
        {
            currentObject.FirstName = txt_FirstName.Text;
            currentObject.LastName = txt_LastName.Text;
            currentObject.Contact = txt_Contact.Text;
            currentObject.Email = txt_Email.Text;
            currentObject.RegistrationNumber = txt_RegistrationNumber.Text;
            
            if (cb_status.Text.Equals("Active")) currentObject.Status = 5 ;
            else currentObject.Status = 6;
        }

        private void loadBlank()
        {
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Contact.Clear();
            txt_Email.Clear();
            txt_RegistrationNumber.Clear();
        }

        private bool isBlank()
        {
            if (
                string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_Contact.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_RegistrationNumber.Text) ||
                string.IsNullOrWhiteSpace(cb_status.Text)
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
            currentObject.FirstName = txt_FirstName.Text;
            currentObject.LastName = txt_LastName.Text;
            currentObject.Contact = txt_Contact.Text;
            currentObject.Email = txt_Email.Text;
            currentObject.RegistrationNumber = txt_RegistrationNumber.Text;
            currentObject.Status = Lookup.getLookup(cb_status.Text, "STUDENT_STATUS").LookupId;
            if (currentObject.Status == -1) MessageBox.Show("Warning: Select a valid Status!");
            else
            {
                if (Student.addStudent(currentObject) == 1) MessageBox.Show("Added Successfully");
                else MessageBox.Show("Error: Add Failed");
            }
            updateDGVStudent();
            loadBlank();
            currentObject.Id = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                currentObject.Id = Convert.ToInt32(dgv_Student.Rows[e.RowIndex].Cells["Column8"].Value);
                currentObject.FirstName = dgv_Student.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                currentObject.LastName = dgv_Student.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                currentObject.Contact = dgv_Student.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                currentObject.Email = dgv_Student.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                currentObject.RegistrationNumber = dgv_Student.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                if (dgv_Student.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString().Equals("Active")) currentObject.Status = 5;
                else currentObject.Status = 6;

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
                if (currentObject.Status == -1) MessageBox.Show("Warning: Select a valid Status!");
                setCurrentObject();
                int msg = Student.addStudent(currentObject);
                if (msg == 0) MessageBox.Show("Error: Update Unsuccessful!");
                if(msg == 1) MessageBox.Show("Added Successfully!");
                if (msg == 2) MessageBox.Show("Updated Successfully!");
                updateDGVStudent();
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
            if (Student.deleteStudentById(currentObject.Id)) MessageBox.Show("Deleted Successfully");
            else MessageBox.Show("Error: Delete Failed");
            updateDGVStudent();
            loadBlank();
            currentObject.Id = -1;
        }
    }
}

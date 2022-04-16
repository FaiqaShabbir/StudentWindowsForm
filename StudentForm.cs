using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign_2_BS_19011519_006
{
    public partial class StudentForm : Form
    {

        List<Student> students = new List<Student>();
        Student currStudent = null;
        int currIndex = -1;
        bool isImageSelected = false;

        public StudentForm()
        {
            InitializeComponent();

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (StudentDB.checkFileExists())
            {
                students = StudentDB.ReadDataFromFile();
                //processDB();
            }

            if (students.Count > 0)
            {
                currIndex = students.Count - 1;
                currStudent = students[currIndex];
            }
            if (currStudent != null)
                FromDataToUI();

            EnableControls();

           
            this.txtAddress.Text = "0";
            this.rbMale.Checked = true;
            this.txtStudentId.Text = "0";
            this.txtStudentId.Enabled = false;
        }

        private void EnableControls()
        {
            if (currStudent == null)
            {
                txtStudentName.Enabled = false;
                txtStudentEmail.Enabled = false;
                dtpDOB.Enabled = false;
                txt_Phone_Number.Enabled = false;
                rbMale.Enabled = false;
                rbFemale.Enabled = false;
                txtAddress.Enabled = false;
                btnBrowseImg.Enabled = false;
                btnSave.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnRemove.Enabled = false;
                gbFindById.Enabled = false;
            }
            else
            {
                txtStudentName.Enabled = true;
                txtStudentEmail.Enabled = true;
                dtpDOB.Enabled = true;
                txt_Phone_Number.Enabled = true;
                rbMale.Enabled = true;
                rbFemale.Enabled = true;
                txtAddress.Enabled = true;
                btnBrowseImg.Enabled = true;
                btnSave.Enabled = true;
                btnRemove.Enabled = true;

            }
            if (currIndex > 0)
            {
                btnPrev.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = false;

            }
            if (currIndex < students.Count - 1)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
            if (students.Count > 0)
            {
                gbFindById.Enabled = true;
            }
            else
            {
                gbFindById.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currIndex == students.Count)
            {
                FromUIToData();
                if (currStudent.Name == "")
                {
                    MessageBox.Show("Student Name Required! Cannot be empty");
                }
                else if (currStudent.Email == "")
                {
                    MessageBox.Show("Student Email Required! Cannot be empty");
                }
                else if (isImageSelected == false)
                {
                    MessageBox.Show("Student Image Required! Cannot be empty");
                }
                else
                {
                    students.Add(currStudent);
                    this.txtStudentId.Text = (currStudent.ID) + "";
                    processDB();
                    string res = $"{this.txtStudentName.Text}, {this.txtStudentEmail.Text}, {this.dtpDOB.Value}, " +
                        $"{this.txt_Phone_Number.Text}, {this.rbMale != this.rbFemale}, {this.txtAddress.Text}, " +
                        $"{this.pbImage.ImageLocation}";
                    //MessageBox.Show($"{res}");
                    updateText();

                }


            }
            EnableControls();
        }

        private void updateText()
        {
            lblCurrStudent.Text = $"Student Count: {students.Count}, \nStudent Data: {currStudent.ToString()}";
        }

        private void processDB()
        {
            StudentDB.WriteDataToFile(students);
            students = StudentDB.ReadDataFromFile();
        }

        private void FromUIToData()
        {
            currStudent.ID = Convert.ToInt32(students.Count + 1);
            currStudent.Name = txtStudentName.Text;
            currStudent.Email = txtStudentEmail.Text;
            currStudent.DOB = this.dtpDOB.Value;
            currStudent.Phone_Number = this.txt_Phone_Number.Text;
            currStudent.Image = this.pbImage.ImageLocation;
            currStudent.Gender = (this.rbMale.Checked == true ? true : false);
            currStudent.Address = txtAddress.Text;
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.pbImage.ImageLocation = ofd.FileName;
                isImageSelected = true;
            }
            else
                MessageBox.Show("No Image File Selected!");
        }

        private void FromDataToUI()
        {
            this.txtStudentId.Text = currStudent.ID + "";
            this.txtStudentName.Text = currStudent.Name;
            this.txtStudentEmail.Text = currStudent.Email;
            this.dtpDOB.Value = currStudent.DOB.Date;
            this.txt_Phone_Number.Text = currStudent.Phone_Number;
            this.pbImage.ImageLocation = currStudent.Image;
            if (currStudent.Gender == true)
            {
                this.rbMale.Checked = true;
                this.rbFemale.Checked = false;
            }
            else
            {
                this.rbMale.Checked = false;
                this.rbFemale.Checked = true;
            }

            this.txtAddress.Text = currStudent.Address;
            updateText();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.pbImage.Image = global::Assign_2_BS_19011519_006.Properties.Resources.user;
            this.pbSearch.Image = global::Assign_2_BS_19011519_006.Properties.Resources.search;
            
            currStudent = new Student();
            currIndex = students.Count;
            EnableControls();
            FromDataToUI();
            this.txtStudentId.Text = "";
            isImageSelected = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currIndex <= 0)
            {
                return;
            }
            currIndex--;
            currStudent = students[currIndex];
            FromDataToUI();
            EnableControls();
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            bool found = false;
            int id = Convert.ToInt32(this.txtGetById.Text);
            int count = 0;
            processDB();
            foreach (Student movie in students)
            {
                if (movie.ID == id)
                {
                    currStudent = movie;
                    found = true;
                    currIndex = count;
                    FromDataToUI();
                    EnableControls();
                }
                count++;
            }

            if (!found)
            {
                MessageBox.Show($"Invalid ID: {id}");
                this.txtGetById.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (students.Count != 0)
            {
                foreach (Student movie in students)
                {
                    if (movie.ID == currStudent.ID)
                    {
                        students.Remove(movie);
                        MessageBox.Show("Record Removed: " + movie.ID);
                        updateText();
                        break;
                    }
                }
                if (students.Count == 0)
                {
                    currStudent = null;
                }
                else
                {
                    currIndex = 0;
                    currStudent = students[currIndex];
                }
                processDB();
                FromDataToUI();
                EnableControls();
            }
        }

        private void StudentForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrStudent_Click(object sender, EventArgs e)
        {

        }
    }
}

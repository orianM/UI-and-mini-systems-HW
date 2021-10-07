using Hackerme.DB;
using Hackerme.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackerme.UI
{
    public partial class pnlStudent : UserControl
    {
        public pnlStudent()
        {
            InitializeComponent();
        }


        Student newStudent = new();
        private void pnlStudent_Load(object sender, EventArgs e)
        {
            cklCourses.Items.Clear();
            foreach (var course in HackermeData.courses)
            {
                cklCourses.Items.Add(course);
            }
            cmbCity.DataSource = CityList.List;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex emailValidation = new Regex(@"([A-z]{2,10}\d{0,5})\@gmail\.com");

            if (emailValidation.IsMatch(txtEmail.Text))
            {
            }
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            newStudent.Id = int.Parse(txtId.Text);
            newStudent.Firstname = txtFirstName.Text;
            newStudent.Lastname = txtLastName.Text;
            newStudent.DOB = dtpDOB.Value;
            newStudent.PhoneNumber = txtPhoneNum.Text;
            newStudent.Email = txtEmail.Text;
            newStudent.CityId = cmbCity.SelectedIndex;

           
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.ResetText();
            txtPhoneNum.Clear();
            txtEmail.Clear();
            cmbCity.ResetText();
            cklCourses.ClearSelected();
        }

        private void tsmiSearchByName_Click(object sender, EventArgs e)
        {
            foreach (var student in HackermeData.students)
            {
                if (student.Lastname == tstxtSearchBy.Text)
                {
                    txtId.Text = $"{student.Id}";
                    txtFirstName.Text = student.Firstname;
                    txtLastName.Text = student.Lastname;
                    dtpDOB.Value = student.DOB;
                    txtPhoneNum.Text = student.PhoneNumber;
                    txtEmail.Text = student.Email;
                    cmbCity.Text = $"{student.CityId}";
                }
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            HackermeData.students.Add(newStudent);
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            newStudent.Id = new int();
            newStudent.Firstname = null;
            newStudent.Lastname = null;
            newStudent.DOB = new DateTime();
            newStudent.PhoneNumber = null;
            newStudent.Email = null;
            newStudent.CityId = new int();
        }

      
    }
}

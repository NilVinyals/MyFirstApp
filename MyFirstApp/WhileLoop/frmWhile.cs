﻿using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.WhileLoop
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var students = new Dictionary<Guid, Student>();
            students.Add(student.Guid, student);
            int i = 0;

            while (i < students.Count)
            {
                KeyValuePair<Guid, Student> entry = students.ElementAt(i);
                if (entry.Value.Name.Equals("Pepe"))
                {
                    MessageBox.Show("Pepe is found: " + entry.Value.Name + "is welcome and his Guid is "+ entry.Value.Guid.ToString());
                }
                i++;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // variable de objeto dentro de ambito de metodos --> var

            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = Convert.ToString(txtName.Text);
            student.Surname = Convert.ToString(txtSurname.Text);
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new List<Student>(); // Array list solo puede contener tipo OBJECTS
                                               // Añadimos nuestro objeto en el array list (Boxing-Polymorphism)
            studentList.Add(student);

            for(int i = 0; i < studentList.Count; i++)
            {
                MessageBox.Show(studentList[i].Name + studentList[i].Surname);
            }
            foreach (var _student in studentList)
            {
                // tenemos que hacer un cast para poder extraer las caracteristicas de Student del Object
                // Unboxing-Polymorphism
                MessageBox.Show(((Student)_student).Name + " " + ((Student)_student).Surname);
            }
        }

    }
}

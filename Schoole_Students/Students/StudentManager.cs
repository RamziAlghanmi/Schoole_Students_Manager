using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schoole_Students.ClassRooms;
using Schoole_Students.Grads;

namespace Schoole_Students.Students
{
    public partial class frmStudentManager : Form
    {
        List<Grad> grads;
        List<Student> students;
        IGrads grads_manager = new GradsManager();
        IStudents students_manager = new StudentsManager();
        public frmStudentManager(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void loadeGrad() {
          this.grads = grads_manager.getAllGrads();
        }

        private void setCustomeGrads(List<Grad> grads) { 
            foreach(Student sts in students)
            {
             sts.grads = students_manager.getGrads(grads, sts.Student_Id);
            }
        }
        private void frmStudentManager_Load(object sender, EventArgs e)
        {
            loadeGrad();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
                WindowState = FormWindowState.Minimized;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            frmShowStudents fs = new frmShowStudents(students);
            fs.MdiParent = this;
            fs.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStudent fad = new frmAddStudent();
            fad.MdiParent = this;
            fad.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateStudent fud = new frmUpdateStudent();
            fud.MdiParent = this;
            fud.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteStudent fde = new frmDeleteStudent();
            fde.MdiParent = this;
            fde.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

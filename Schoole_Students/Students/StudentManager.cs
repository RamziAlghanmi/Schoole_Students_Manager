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
        IClassRooms rooms_manager = new ClassRoomsManager();
        IStudents students_manager = new StudentsManager();
        BindingList<Student> studentList;
        BindingList<ClassRoom> roomList;

        public frmStudentManager(BindingList<Student> studentList, BindingList<ClassRoom> roomList)
        {
            InitializeComponent();          
            this.studentList = studentList;
            this.roomList = roomList;

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

        private void btnShowStudents_Click(object sender, EventArgs e)
        {

            frmShowStudents fs = new frmShowStudents(studentList);
            fs.MdiParent = this;
            fs.Show();
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            frmAddStudent fad = new frmAddStudent(studentList, roomList);
            fad.MdiParent = this;
            fad.Show();
        }

        private void btnUpdateStudents_Click(object sender, EventArgs e)
        {
            frmUpdateStudent fud = new frmUpdateStudent(studentList, roomList);
            fud.MdiParent = this;
            fud.Show();
        }

        private void btnDeleteStudents_Click(object sender, EventArgs e)
        {
            frmDeleteStudent fde = new frmDeleteStudent(studentList);
            fde.MdiParent = this;
            fde.Show();
        }

        private void frmStudentManager_Load(object sender, EventArgs e)
        {

        }
    }
}

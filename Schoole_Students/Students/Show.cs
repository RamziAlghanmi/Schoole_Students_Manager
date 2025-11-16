using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoole_Students.Students
{
    public partial class frmShowStudents : Form
    {
        IStudents students_manager = new StudentsManager();
        BindingList<Student> studentList;
        Dictionary<int, string> roomDictionary;
       
        public frmShowStudents(BindingList<Student> studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1100, 700);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(560, 500);
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
           
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = studentList;
        }
    }
}

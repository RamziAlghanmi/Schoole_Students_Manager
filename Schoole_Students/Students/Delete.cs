using Schoole_Students.Grads;
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
    public partial class frmDeleteStudent : Form
    {
        IStudents students_manager = new StudentsManager();
        BindingList<Student> studentList;
        Dictionary<int, string> roomDictionary;

        List<Student> students;
        public frmDeleteStudent(BindingList<Student> studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

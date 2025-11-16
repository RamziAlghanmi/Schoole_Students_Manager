using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schoole_Students.Students;
using Schoole_Students.ClassRooms;

namespace Schoole_Students
{
    public partial class frmMainPage : Form
    {
        IClassRooms rooms_manager= new ClassRoomsManager();
        IStudents students_manager = new StudentsManager();
        BindingList<ClassRoom> roomList;          
        BindingList<Student> studentList;
        Dictionary< int, string> roomDictionary;
        public frmMainPage()
        {
            InitializeComponent();
           }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnMax_Click_1(object sender, EventArgs e)
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

       

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(250, 440);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" أنت الان في القائمة الرئيسية ");
            
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudentManager fsm = new frmStudentManager(studentList, roomDictionary);
            fsm.ShowDialog();
        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            frmClassRoomManager fcrm = new frmClassRoomManager(roomList,studentList);
            fcrm.ShowDialog();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            this.roomList = new BindingList<ClassRoom>(rooms_manager.getAllClassRooms());
            this.studentList = new BindingList<Student>(students_manager.getAllStudents());
            this.roomDictionary = new Dictionary<int, string>(rooms_manager.getRoomDictionary(roomList));
            foreach(ClassRoom room in roomList ) {
                room.Students = rooms_manager.getCustomStudents(studentList, room.Class_Room_Id);
            }
       }
    }
}

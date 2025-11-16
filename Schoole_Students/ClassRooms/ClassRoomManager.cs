using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoole_Students.ClassRooms
{
    public partial class frmClassRoomManager : Form
    {
        IClassRooms rooms_manager = new ClassRoomsManager();
        BindingList<ClassRoom> roomList;
        BindingList<Student> studentList;
        public frmClassRoomManager(BindingList<ClassRoom> roomList, BindingList<Student> studentList)
        {
            InitializeComponent();
            this.roomList = roomList;
            this.studentList = studentList;
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
           
            frmShow fs= new frmShow(roomList);
            fs.MdiParent = this;
            fs.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd fad = new frmAdd(roomList);
            fad.MdiParent = this;
            fad.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate fud = new frmUpdate(roomList);
            fud.MdiParent = this;
            fud.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete fde = new frmDelete(roomList);
            fde.MdiParent = this;
            fde.Show();
        }
        private void frmClassRoomManager_Load(object sender, EventArgs e)
        {
         
        }
    }
}

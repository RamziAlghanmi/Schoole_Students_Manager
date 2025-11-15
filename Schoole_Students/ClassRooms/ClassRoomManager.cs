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
        List<Student> students;
        List<ClassRoom> rooms;
        IClassRooms rooms_manager = new ClassRoomsManager();
        public frmClassRoomManager( List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }
        
        void loadeRooms()
        {
           this.rooms = rooms_manager.getAllClassRooms(students);
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
           
            frmShow fs= new frmShow(rooms);
            fs.MdiParent = this;
            fs.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd fad = new frmAdd();
            fad.MdiParent = this;
            fad.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate fud = new frmUpdate();
            fud.MdiParent = this;
            fud.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete fde = new frmDelete();
            fde.MdiParent = this;
            fde.Show();
        }
        private void frmClassRoomManager_Load(object sender, EventArgs e)
        {
            loadeRooms();
        }
    }
}

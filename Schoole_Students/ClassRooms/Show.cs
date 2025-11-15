using Schoole_Students.Students;
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
    
    public partial class frmShow : Form
    {
        public frmShow(List<ClassRoom> rooms)
        {
            InitializeComponent();
            this.roomList = rooms;
        }
        List<ClassRoom> roomList = new List<ClassRoom>();
       
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

        private void frmShow_Load(object sender, EventArgs e)
        {
            dgvClassRooms.DataSource = null;
            dgvClassRooms.DataSource = roomList;
        }
    }
}

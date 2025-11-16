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
    public partial class frmAdd : Form
    {
        IClassRooms rooms_manager = new ClassRoomsManager();
        BindingList<ClassRoom> roomList;
        Student Student;
        public frmAdd(BindingList<ClassRoom> rooms)
        {
            InitializeComponent();
            this.roomList = rooms;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

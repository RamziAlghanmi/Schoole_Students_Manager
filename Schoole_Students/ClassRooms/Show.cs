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
        IClassRooms rooms_manager = new ClassRoomsManager();
        BindingList<ClassRoom> rooms;
        public frmShow(BindingList<ClassRoom> rooms)
        {
            InitializeComponent();
            this.rooms = rooms;
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
            this.Size = new System.Drawing.Size( 560, 500);
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
          
            dgvClassRooms.DataSource = null;
            dgvClassRooms.DataSource = rooms;
        }
    }
}

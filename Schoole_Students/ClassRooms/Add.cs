using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Schoole_Students.ClassRooms
{
    public partial class frmAdd : Form
    {
        IClassRooms rooms_manager;
        
        BindingList<ClassRoom> roomList;
        public frmAdd(BindingList<ClassRoom> rooms)
        {
            InitializeComponent();
            this.roomList = rooms;
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //rooms_manager = new ClassRoomsManager();
            //rooms_manager.addClassRoom(new ClassRoom(txtClassName, Convert.ToInt32( txtCapacity ));
           // roomList.Add(new ClassRoom(rooms_manager.getNewId(), txtClassName, Convert.ToInt32(txtCapacity)));
           

        }


    }
}

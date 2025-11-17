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
    public partial class frmUpdate : Form
    {
        IClassRooms rooms_manager =new ClassRoomsManager();
        BindingList<ClassRoom> roomList;
       
        public frmUpdate(BindingList<ClassRoom> roomList)
        {
            InitializeComponent();
            this.roomList = roomList;
          
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSearch.text);
           if ( rooms_manager.found(roomList, id))
            {
              int index= rooms_manager.search(roomList, id);
                txtClassName.Text = roomList[index].Class_Room_Name;
                txtCapacity.Text = roomList[index].Max_Capacity.ToString();
                labID.Text = roomList[index].Class_Room_Id.ToString();

            }
        }
    }
}

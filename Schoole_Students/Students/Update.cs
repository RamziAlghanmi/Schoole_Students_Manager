using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoole_Students.Students
{
    public partial class frmUpdateStudent : Form
    {
        int class_id;
        byte[] image;
        IStudents students_manager = new StudentsManager();
        BindingList<Student> studentList;
        BindingList<ClassRoom> roomList;
        public frmUpdateStudent(BindingList<Student> studentList, BindingList<ClassRoom> roomList)
        {
            InitializeComponent();
            this.studentList = studentList;
            this.roomList = roomList;
        }
       
        private void loadToComboBox()
        {
            cbxRooms.DisplayMember = "Class_Room_Name";
            cbxRooms.ValueMember = "Class_Room_Id";
            cbxRooms.DataSource = new BindingSource(roomList, null);
        }
        // دالة لتحويل الصورة ال byte  لتخزينها على قاعدة البيانات
        public byte[] imageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {
            loadToComboBox();
        }

        private void cbxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.class_id = Convert.ToInt32(cbxRooms.SelectedValue);
        }
    }
}

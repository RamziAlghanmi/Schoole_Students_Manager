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
using System.Xml.Linq;

namespace Schoole_Students.Students
{
    public partial class frmAddStudent : Form
    {
        int class_id, new_id;
        byte[] image;
        IStudents students_manager;
        BindingList<Student> studentList;
        BindingList<ClassRoom> roomList;
        public frmAddStudent(BindingList<Student> studentList, BindingList<ClassRoom> roomList)
        {
            InitializeComponent();
            this.studentList = studentList;
            this.roomList = roomList;
        }
        // دالة لتحويل الصورة ال byte  لتخزينها على قاعدة البيانات
        public byte[] imageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save (ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray ();
            }
        }
        private void loadToComboBox()
        {
            cbxRooms.DisplayMember = "Class_Room_Name";
            cbxRooms.ValueMember = "Class_Room_Id";
            cbxRooms.DataSource = new BindingSource(roomList, null);
           

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            loadToComboBox();
            //this.class_id = Convert.ToInt32(cbxRooms.SelectedValue.ToString());
        }
        // students_manager.add(student);
       // studentList.add(student);
        private void cbxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            this.class_id = Convert.ToInt32(cbxRooms.SelectedValue);
            
        }

        private void cbxRooms_Validating(object sender, CancelEventArgs e)
        {
            if(cbxRooms.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbxRooms.Focus();
            }
        }

        // دالة الحصول على الجنس 
       /* string getGender()
        {
            if (radMain.Checked)
            {
                return "Man";
            }
            else
            {
                return "Male";
            }

        }
       */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // الاضافة الى قاعدة البيانات
            // students_manager.Add(new Student( txtName.Text, txtAddress.Text, txtDate.value,
            //                   class_id, txtPhone.Text, getGender(), imageToByte(Image img), txtEmaile.Text));
            // الاضافة الى المصفوفة الحالية
            //  studentList.Add(new Student(students_manager.getNewId(), txtName.Text, txtAddress.Text, txtDate.value,
            //           class_id, txtPhone.Text, getGender(), imageToByte(Image img),txtEmaile.Text));

            // تنظيف الحقول
            //  clearInputs(this);
        }

        void clearInputs(Control parent)
        {
            foreach (Control c in parent.Controls)
            {

                if (c is TextBox)
                {
                    c.Text = String.Empty;

                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is ComboBox)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                else
                {
                    clearInputs(c);
                }
            }

        }
    }
}

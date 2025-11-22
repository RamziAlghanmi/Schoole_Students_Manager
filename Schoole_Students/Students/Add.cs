using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


            rdoMale.Checked = true;

            btnAdd.BringToFront();//تظهر فوق كل العناصر لا يغطيه اي عنصر

            txtName.TextChanged += ValidateForm;
            txtAddress.TextChanged += ValidateForm;
            txtPhone.TextChanged += ValidateForm;
            //txtId.TextChanged += ValidateForm;
            txtEmail.TextChanged += ValidateForm;
            rdoFamale.CheckedChanged += ValidateForm;
            rdoMale.CheckedChanged += ValidateForm;
            picPhoto.Click += ValidateForm;


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
        private void ValidateForm(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = " 777777777";
                labPhon.Text = "Default phone used";
                labPhon.ForeColor = Color.Orange;

            }
            else
            {
                labPhon.Text = "OK";
                labPhon.ForeColor = Color.Green;
            }
            Control control = (Control)sender;

            //Name
            if (control == txtName)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    labName.Text = "Pleass Enter Name";
                    labName.ForeColor = Color.Red;

                }
                else
                {
                    labName.Text = "OK";
                    labName.ForeColor = Color.Green;
                }
            }

            //Address
            else if (control == txtAddress)
            {
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    labAddrees.Text = "Address required";
                    labAddrees.ForeColor = Color.Red;

                }
                else
                {
                    labAddrees.Text = "OK";
                    labAddrees.ForeColor = Color.Green;
                }
            }

            //Phone
            if (control == txtPhone)
            {

            }

            //Email
            else if (control == txtEmail)
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    labEmail.Text = "Invalid email";
                    labEmail.ForeColor = Color.Red;

                }
                else
                {
                    labEmail.Text = "OK";
                    labEmail.ForeColor = Color.Green;
                }
            }



            //id
           /* else if (control == txtId)
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    labId.Text = "Id number required";
                    labId.ForeColor = Color.Red;
                }
                else if (!txtId.Text.All(char.IsDigit))
                {
                    labId.Text = "Digits only";
                    labId.ForeColor = Color.Red;

                }
                else
                {
                    labId.Text = "OK";
                    labId.ForeColor = Color.Green;
                }
            }*/
            //Photo
            else if (control == picPhoto)
            {
                if (picPhoto.Image == null)
                {
                    labPhoto.Text = "Please upload photo";
                    labPhoto.ForeColor = Color.Red;

                }
                else
                {
                    labPhoto.Text = "OK";
                    labPhoto.ForeColor = Color.Green;
                }
            }


            UpAddButton();
        }
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        private void UpAddButton()
        {
            bool allvalid =
                !string.IsNullOrWhiteSpace(txtName.Text) &&
                !string.IsNullOrWhiteSpace(txtAddress.Text) &&
                IsValidEmail(txtEmail.Text) &&
             //   !string.IsNullOrWhiteSpace(txtId.Text) &&
                picPhoto.Image != null;
             



            btnAdd.Enabled = allvalid;
        }
      

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            loadToComboBox();
            this.class_id = Convert.ToInt32(cbxRooms.SelectedValue.ToString());
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
        string getGender()
        {
            if (rdoMale.Checked)
            {
                return "Man";
            }
            else
            {
                return "Male";
            }

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
          image = imageToByte(picPhoto.Image);
            // الاضافة الى قاعدة البيانات
              students_manager.addStudent(new Student( txtName.Text, txtAddress.Text, picDate.Value,
                            class_id, image, getGender(), txtPhone.Text,  txtEmail.Text));
            // الاضافة الى المصفوفة الحالية
              studentList.Add(new Student(students_manager.getNewId(), txtName.Text, txtAddress.Text, picDate.Value,
                       class_id, image,  getGender(), txtPhone.Text, txtEmail.Text));

            // تنظيف الحقول
             clearInputs(this);
            MessageBox.Show("تم إضافة الطالب بنجاح");
        }

        private void labUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFileDialog.FileName);
                ValidateForm(picPhoto, EventArgs.Empty);
                image = imageToByte(picPhoto.Image);
            }
        }

        private void labRemove_Click_1(object sender, EventArgs e)
        {
            picPhoto.Image = null;
            ValidateForm(picPhoto, EventArgs.Empty);

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

namespace Schoole_Students.Students
{
    partial class frmUpdateStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStudent));
            this.pnMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labMain = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipseMainFrm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseMainLab = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseBtnMin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbxSerchName = new System.Windows.Forms.ComboBox();
            this.pernalStudent = new System.Windows.Forms.Panel();
            this.butBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labRemove = new System.Windows.Forms.Label();
            this.labUpload = new System.Windows.Forms.Label();
            this.labPhon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labPhoto = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picDate = new System.Windows.Forms.DateTimePicker();
            this.labAddrees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddrees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comRooms = new System.Windows.Forms.ComboBox();
            this.labName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoFamale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSerchStudent = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pernalStudent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.labMain);
            this.pnMain.Controls.Add(this.btnExit);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.GradientBottomLeft = System.Drawing.Color.DarkGray;
            this.pnMain.GradientBottomRight = System.Drawing.Color.CadetBlue;
            this.pnMain.GradientTopLeft = System.Drawing.Color.LightSkyBlue;
            this.pnMain.GradientTopRight = System.Drawing.Color.DarkCyan;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Quality = 10;
            this.pnMain.Size = new System.Drawing.Size(784, 49);
            this.pnMain.TabIndex = 10;
            // 
            // labMain
            // 
            this.labMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labMain.BackColor = System.Drawing.Color.CadetBlue;
            this.labMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labMain.Location = new System.Drawing.Point(241, 9);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(258, 29);
            this.labMain.TabIndex = 4;
            this.labMain.Text = "تعديل طالب";
            this.labMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMain.UseCompatibleTextRendering = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(747, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 41);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuElipseMainFrm
            // 
            this.bunifuElipseMainFrm.ElipseRadius = 10;
            this.bunifuElipseMainFrm.TargetControl = this;
            // 
            // bunifuElipseMainLab
            // 
            this.bunifuElipseMainLab.ElipseRadius = 12;
            this.bunifuElipseMainLab.TargetControl = this.labMain;
            // 
            // bunifuElipseBtnMin
            // 
            this.bunifuElipseBtnMin.ElipseRadius = 10;
            this.bunifuElipseBtnMin.TargetControl = this;
            // 
            // cbxSerchName
            // 
            this.cbxSerchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSerchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSerchName.FormattingEnabled = true;
            this.cbxSerchName.Location = new System.Drawing.Point(314, 79);
            this.cbxSerchName.Name = "cbxSerchName";
            this.cbxSerchName.Size = new System.Drawing.Size(240, 37);
            this.cbxSerchName.TabIndex = 12;
            this.cbxSerchName.SelectedIndexChanged += new System.EventHandler(this.cbxRooms_SelectedIndexChanged);
            // 
            // pernalStudent
            // 
            this.pernalStudent.Controls.Add(this.butBack);
            this.pernalStudent.Controls.Add(this.btnUpdate);
            this.pernalStudent.Controls.Add(this.groupBox2);
            this.pernalStudent.Controls.Add(this.groupBox1);
            this.pernalStudent.Location = new System.Drawing.Point(0, 168);
            this.pernalStudent.Name = "pernalStudent";
            this.pernalStudent.Size = new System.Drawing.Size(778, 553);
            this.pernalStudent.TabIndex = 13;
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.CadetBlue;
            this.butBack.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.Location = new System.Drawing.Point(51, 514);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(99, 36);
            this.butBack.TabIndex = 18;
            this.butBack.Text = "السايق";
            this.butBack.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(570, 514);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 36);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labRemove);
            this.groupBox2.Controls.Add(this.labUpload);
            this.groupBox2.Controls.Add(this.labPhon);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.labEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.labPhoto);
            this.groupBox2.Controls.Add(this.picPhoto);
            this.groupBox2.Location = new System.Drawing.Point(392, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 458);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Javanese Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(102, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 38);
            this.label11.TabIndex = 15;
            this.label11.Text = "المعلومات الاخرى";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseCompatibleTextRendering = true;
            // 
            // labRemove
            // 
            this.labRemove.AutoSize = true;
            this.labRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labRemove.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemove.ForeColor = System.Drawing.Color.Blue;
            this.labRemove.Location = new System.Drawing.Point(230, 229);
            this.labRemove.Name = "labRemove";
            this.labRemove.Size = new System.Drawing.Size(37, 20);
            this.labRemove.TabIndex = 14;
            this.labRemove.Text = "حذف";
            // 
            // labUpload
            // 
            this.labUpload.AutoSize = true;
            this.labUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labUpload.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUpload.ForeColor = System.Drawing.Color.Blue;
            this.labUpload.Location = new System.Drawing.Point(124, 229);
            this.labUpload.Name = "labUpload";
            this.labUpload.Size = new System.Drawing.Size(44, 20);
            this.labUpload.TabIndex = 13;
            this.labUpload.Text = "تحميل";
            // 
            // labPhon
            // 
            this.labPhon.AutoSize = true;
            this.labPhon.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhon.Location = new System.Drawing.Point(152, 396);
            this.labPhon.Name = "labPhon";
            this.labPhon.Size = new System.Drawing.Size(0, 22);
            this.labPhon.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "الهاتف";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Uighur", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(147, 362);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(163, 31);
            this.txtPhone.TabIndex = 10;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(152, 316);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(0, 22);
            this.labEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "البريد الالكتروني:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Uighur", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(147, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 31);
            this.txtEmail.TabIndex = 7;
            // 
            // labPhoto
            // 
            this.labPhoto.AutoSize = true;
            this.labPhoto.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhoto.Location = new System.Drawing.Point(124, 195);
            this.labPhoto.Name = "labPhoto";
            this.labPhoto.Size = new System.Drawing.Size(0, 22);
            this.labPhoto.TabIndex = 4;
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(124, 76);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(145, 116);
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.picDate);
            this.groupBox1.Controls.Add(this.labAddrees);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAddrees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comRooms);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 472);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(100, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 38);
            this.label7.TabIndex = 21;
            this.label7.Text = "المعلومات الاساسية";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "تاريخ الميلاد:";
            // 
            // picDate
            // 
            this.picDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picDate.Location = new System.Drawing.Point(122, 322);
            this.picDate.Name = "picDate";
            this.picDate.Size = new System.Drawing.Size(186, 28);
            this.picDate.TabIndex = 19;
            // 
            // labAddrees
            // 
            this.labAddrees.AutoSize = true;
            this.labAddrees.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddrees.Location = new System.Drawing.Point(126, 282);
            this.labAddrees.Name = "labAddrees";
            this.labAddrees.Size = new System.Drawing.Size(0, 22);
            this.labAddrees.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "العنوان:";
            // 
            // txtAddrees
            // 
            this.txtAddrees.Font = new System.Drawing.Font("Microsoft Uighur", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddrees.Location = new System.Drawing.Point(121, 248);
            this.txtAddrees.Name = "txtAddrees";
            this.txtAddrees.Size = new System.Drawing.Size(163, 31);
            this.txtAddrees.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "الجنس:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "الفصل:";
            // 
            // comRooms
            // 
            this.comRooms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comRooms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comRooms.FormattingEnabled = true;
            this.comRooms.Location = new System.Drawing.Point(100, 158);
            this.comRooms.Name = "comRooms";
            this.comRooms.Size = new System.Drawing.Size(203, 37);
            this.comRooms.TabIndex = 11;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(96, 125);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 22);
            this.labName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "الاسم:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Uighur", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(100, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 31);
            this.txtName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoFamale);
            this.groupBox3.Controls.Add(this.rdoMale);
            this.groupBox3.Location = new System.Drawing.Point(118, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 70);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // rdoFamale
            // 
            this.rdoFamale.AutoSize = true;
            this.rdoFamale.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFamale.Location = new System.Drawing.Point(88, 33);
            this.rdoFamale.Name = "rdoFamale";
            this.rdoFamale.Size = new System.Drawing.Size(51, 24);
            this.rdoFamale.TabIndex = 2;
            this.rdoFamale.TabStop = true;
            this.rdoFamale.Text = "انثى";
            this.rdoFamale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(6, 33);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 24);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "ذكر";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "الاسم: ";
            // 
            // btnSerchStudent
            // 
            this.btnSerchStudent.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSerchStudent.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerchStudent.Location = new System.Drawing.Point(357, 126);
            this.btnSerchStudent.Name = "btnSerchStudent";
            this.btnSerchStudent.Size = new System.Drawing.Size(99, 36);
            this.btnSerchStudent.TabIndex = 18;
            this.btnSerchStudent.Text = "بحث";
            this.btnSerchStudent.UseVisualStyleBackColor = false;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // frmUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 733);
            this.Controls.Add(this.btnSerchStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pernalStudent);
            this.Controls.Add(this.cbxSerchName);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUpdateStudent";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.frmUpdateStudent_Load);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pernalStudent.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnMain;
        private System.Windows.Forms.Label labMain;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainFrm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainLab;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseBtnMin;
        private System.Windows.Forms.ComboBox cbxSerchName;
        private System.Windows.Forms.Panel pernalStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker picDate;
        private System.Windows.Forms.Label labAddrees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddrees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comRooms;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoFamale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSerchStudent;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labRemove;
        private System.Windows.Forms.Label labUpload;
        private System.Windows.Forms.Label labPhon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labPhoto;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}
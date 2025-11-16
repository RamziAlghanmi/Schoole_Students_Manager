namespace Schoole_Students
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.pnMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labMain = new System.Windows.Forms.Label();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStudents = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClassRooms = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSubjects = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipseMainFrm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseMainLab = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseBtnMin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.labMain);
            this.pnMain.Controls.Add(this.btnMin);
            this.pnMain.Controls.Add(this.btnMax);
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
            this.pnMain.Size = new System.Drawing.Size(819, 47);
            this.pnMain.TabIndex = 0;
            // 
            // labMain
            // 
            this.labMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labMain.BackColor = System.Drawing.Color.CadetBlue;
            this.labMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labMain.Location = new System.Drawing.Point(289, 9);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(210, 29);
            this.labMain.TabIndex = 4;
            this.labMain.Text = "مدرسة الفتح ";
            this.labMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMain.UseCompatibleTextRendering = true;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(715, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 41);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageActive = null;
            this.btnMax.Location = new System.Drawing.Point(748, 3);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(31, 41);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 3;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(782, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 41);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.btnStudents);
            this.groupBox1.Controls.Add(this.btnClassRooms);
            this.groupBox1.Controls.Add(this.btnSubjects);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Location = new System.Drawing.Point(563, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 539);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // btnStudents
            // 
            this.btnStudents.Activecolor = System.Drawing.Color.Teal;
            this.btnStudents.BackColor = System.Drawing.Color.CadetBlue;
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudents.BorderRadius = 5;
            this.btnStudents.ButtonText = "قائمة الطلاب";
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudents.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudents.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudents.Iconimage")));
            this.btnStudents.Iconimage_right = null;
            this.btnStudents.Iconimage_right_Selected = null;
            this.btnStudents.Iconimage_Selected = null;
            this.btnStudents.IconMarginLeft = 0;
            this.btnStudents.IconMarginRight = 0;
            this.btnStudents.IconRightVisible = true;
            this.btnStudents.IconRightZoom = 0D;
            this.btnStudents.IconVisible = true;
            this.btnStudents.IconZoom = 70D;
            this.btnStudents.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btnStudents.IsTab = false;
            this.btnStudents.Location = new System.Drawing.Point(6, 87);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnStudents.OnHovercolor = System.Drawing.Color.Teal;
            this.btnStudents.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStudents.selected = false;
            this.btnStudents.Size = new System.Drawing.Size(238, 61);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "قائمة الطلاب";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnStudents.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnClassRooms
            // 
            this.btnClassRooms.Activecolor = System.Drawing.Color.Teal;
            this.btnClassRooms.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClassRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClassRooms.BorderRadius = 5;
            this.btnClassRooms.ButtonText = "قائمة الفصول";
            this.btnClassRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassRooms.DisabledColor = System.Drawing.Color.Gray;
            this.btnClassRooms.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClassRooms.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClassRooms.Iconimage")));
            this.btnClassRooms.Iconimage_right = null;
            this.btnClassRooms.Iconimage_right_Selected = null;
            this.btnClassRooms.Iconimage_Selected = null;
            this.btnClassRooms.IconMarginLeft = 0;
            this.btnClassRooms.IconMarginRight = 0;
            this.btnClassRooms.IconRightVisible = true;
            this.btnClassRooms.IconRightZoom = 0D;
            this.btnClassRooms.IconVisible = true;
            this.btnClassRooms.IconZoom = 70D;
            this.btnClassRooms.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btnClassRooms.IsTab = false;
            this.btnClassRooms.Location = new System.Drawing.Point(6, 154);
            this.btnClassRooms.Name = "btnClassRooms";
            this.btnClassRooms.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnClassRooms.OnHovercolor = System.Drawing.Color.Teal;
            this.btnClassRooms.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClassRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClassRooms.selected = false;
            this.btnClassRooms.Size = new System.Drawing.Size(238, 61);
            this.btnClassRooms.TabIndex = 2;
            this.btnClassRooms.Text = "قائمة الفصول";
            this.btnClassRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassRooms.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnClassRooms.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassRooms.Click += new System.EventHandler(this.btnClassRooms_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Activecolor = System.Drawing.Color.Teal;
            this.btnSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjects.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubjects.BorderRadius = 5;
            this.btnSubjects.ButtonText = "القائمة المواد الدراسية";
            this.btnSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjects.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubjects.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubjects.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubjects.Iconimage")));
            this.btnSubjects.Iconimage_right = null;
            this.btnSubjects.Iconimage_right_Selected = null;
            this.btnSubjects.Iconimage_Selected = null;
            this.btnSubjects.IconMarginLeft = 0;
            this.btnSubjects.IconMarginRight = 0;
            this.btnSubjects.IconRightVisible = true;
            this.btnSubjects.IconRightZoom = 0D;
            this.btnSubjects.IconVisible = true;
            this.btnSubjects.IconZoom = 70D;
            this.btnSubjects.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btnSubjects.IsTab = false;
            this.btnSubjects.Location = new System.Drawing.Point(6, 424);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnSubjects.OnHovercolor = System.Drawing.Color.Teal;
            this.btnSubjects.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubjects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSubjects.selected = false;
            this.btnSubjects.Size = new System.Drawing.Size(238, 61);
            this.btnSubjects.TabIndex = 3;
            this.btnSubjects.Text = "القائمة المواد الدراسية";
            this.btnSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjects.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnSubjects.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.Teal;
            this.btnHome.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 5;
            this.btnHome.ButtonText = "القائمة الرئيسية";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 70D;
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(6, 10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnHome.OnHovercolor = System.Drawing.Color.Teal;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(238, 67);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "القائمة الرئيسية";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.bunifuElipseBtnMin.TargetControl = this.btnMin;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(12, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 539);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(819, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnMain;
        private Bunifu.Framework.UI.BunifuImageButton btnMax;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudents;
        private Bunifu.Framework.UI.BunifuFlatButton btnClassRooms;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubjects;
        private System.Windows.Forms.Label labMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainFrm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainLab;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseBtnMin;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


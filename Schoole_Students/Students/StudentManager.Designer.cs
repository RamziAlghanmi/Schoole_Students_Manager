namespace Schoole_Students.Students
{
    partial class frmStudentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManager));
            this.pnMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.labMain = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipseMainFrm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseMainLab = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseBtnMin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.pnMain.Controls.Add(this.btnMin);
            this.pnMain.Controls.Add(this.btnMax);
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
            this.pnMain.Size = new System.Drawing.Size(580, 47);
            this.pnMain.TabIndex = 7;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(475, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 41);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 5;
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
            this.btnMax.Location = new System.Drawing.Point(509, 3);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(31, 41);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 6;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // labMain
            // 
            this.labMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labMain.BackColor = System.Drawing.Color.CadetBlue;
            this.labMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labMain.Location = new System.Drawing.Point(169, 9);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(210, 29);
            this.labMain.TabIndex = 4;
            this.labMain.Text = "قائمة الطلاب ";
            this.labMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMain.UseCompatibleTextRendering = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(543, 3);
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
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Teal;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.ButtonText = "حذف طالب";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 50D;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(9, 373);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Teal;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(238, 68);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف طالب";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteStudents_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.Teal;
            this.btnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.ButtonText = "تعديل بيانات طالب";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 50D;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(9, 185);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.Teal;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(238, 82);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "تعديل بيانات طالب";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateStudents_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.Teal;
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.ButtonText = "إضافة طالب جديد";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(9, 104);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Teal;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(238, 69);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "إضافة طالب جديد";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // btnShow
            // 
            this.btnShow.Activecolor = System.Drawing.Color.Teal;
            this.btnShow.BackColor = System.Drawing.Color.CadetBlue;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.BorderRadius = 5;
            this.btnShow.ButtonText = "عرض الطلاب";
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.DisabledColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShow.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShow.Iconimage")));
            this.btnShow.Iconimage_right = null;
            this.btnShow.Iconimage_right_Selected = null;
            this.btnShow.Iconimage_Selected = null;
            this.btnShow.IconMarginLeft = 0;
            this.btnShow.IconMarginRight = 0;
            this.btnShow.IconRightVisible = true;
            this.btnShow.IconRightZoom = 0D;
            this.btnShow.IconVisible = true;
            this.btnShow.IconZoom = 120D;
            this.btnShow.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btnShow.IsTab = false;
            this.btnShow.Location = new System.Drawing.Point(9, 20);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Normalcolor = System.Drawing.Color.CadetBlue;
            this.btnShow.OnHovercolor = System.Drawing.Color.Teal;
            this.btnShow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShow.selected = false;
            this.btnShow.Size = new System.Drawing.Size(238, 72);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "عرض الطلاب";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnShow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Location = new System.Drawing.Point(318, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 450);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // frmStudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 523);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStudentManager";
            this.Text = "StudentManager";
            this.Load += new System.EventHandler(this.frmStudentManager_Load);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnMain;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnMax;
        private System.Windows.Forms.Label labMain;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainFrm;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnShow;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainLab;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseBtnMin;
    }
}
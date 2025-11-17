namespace Schoole_Students.ClassRooms
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.pnMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labMain = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipseMainFrm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseMainLab = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseBtnMin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtClassName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapacity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
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
            this.pnMain.Size = new System.Drawing.Size(543, 49);
            this.pnMain.TabIndex = 11;
            // 
            // labMain
            // 
            this.labMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labMain.BackColor = System.Drawing.Color.CadetBlue;
            this.labMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labMain.Location = new System.Drawing.Point(151, 9);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(258, 29);
            this.labMain.TabIndex = 4;
            this.labMain.Text = "تعديل فصل ";
            this.labMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMain.UseCompatibleTextRendering = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(506, 3);
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
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(136, 55);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 55);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.text = "";
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.PowderBlue;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtClassName.HintForeColor = System.Drawing.Color.Empty;
            this.txtClassName.HintText = "";
            this.txtClassName.isPassword = false;
            this.txtClassName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtClassName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtClassName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtClassName.LineThickness = 6;
            this.txtClassName.Location = new System.Drawing.Point(273, 175);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(161, 57);
            this.txtClassName.TabIndex = 2;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(441, 184);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(74, 24);
            this.labName.TabIndex = 13;
            this.labName.Text = "اسم الفصل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "الرقم الأكاديمي";
            // 
            // labID
            // 
            this.labID.BackColor = System.Drawing.Color.PowderBlue;
            this.labID.Location = new System.Drawing.Point(18, 175);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(145, 33);
            this.labID.TabIndex = 16;
            this.labID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "السعة القصوى";
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.PowderBlue;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCapacity.HintForeColor = System.Drawing.Color.Empty;
            this.txtCapacity.HintText = "";
            this.txtCapacity.isPassword = false;
            this.txtCapacity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCapacity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCapacity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCapacity.LineThickness = 6;
            this.txtCapacity.Location = new System.Drawing.Point(151, 240);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(161, 54);
            this.txtCapacity.TabIndex = 17;
            this.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.Teal;
            this.btnSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.ButtonText = "بحث";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = false;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = false;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(302, 67);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.OnHovercolor = System.Drawing.Color.Teal;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(73, 30);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "بحث";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(403, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 42);
            this.label3.TabIndex = 20;
            this.label3.Text = "الرقم الأكاديمي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(543, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUpdate";
            this.Text = "Update";
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCapacity;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClassName;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.Label label3;
    }
}
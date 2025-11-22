namespace Schoole_Students.ClassRooms
{
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.pnMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labMain = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipseMainFrm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseMainLab = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseBtnMin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtClassName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.pnMain.Size = new System.Drawing.Size(593, 49);
            this.pnMain.TabIndex = 9;
            // 
            // labMain
            // 
            this.labMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labMain.BackColor = System.Drawing.Color.CadetBlue;
            this.labMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labMain.Location = new System.Drawing.Point(145, 9);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(258, 29);
            this.labMain.TabIndex = 4;
            this.labMain.Text = "إضافة فصل";
            this.labMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMain.UseCompatibleTextRendering = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(556, 3);
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
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "إضافة";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(385, 350);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(162, 75);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClassName.HintForeColor = System.Drawing.Color.Empty;
            this.txtClassName.HintText = "";
            this.txtClassName.isPassword = false;
            this.txtClassName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtClassName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtClassName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtClassName.LineThickness = 3;
            this.txtClassName.Location = new System.Drawing.Point(123, 139);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(379, 33);
            this.txtClassName.TabIndex = 11;
            this.txtClassName.Text = "bunifuMaterialTextbox1";
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 486);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAdd";
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnMain;
        private System.Windows.Forms.Label labMain;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainFrm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainLab;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseBtnMin;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClassName;
    }
}
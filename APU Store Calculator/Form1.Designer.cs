namespace APU_Store_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerOpacity = new System.Windows.Forms.Timer(this.components);
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenuBackground = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.labelCompanyDetails = new System.Windows.Forms.Label();
            this.labelDatabaseConnection = new System.Windows.Forms.Label();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.labelMyProfile = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelNewItems = new System.Windows.Forms.Label();
            this.labelManageItems = new System.Windows.Forms.Label();
            this.labelMainTotal = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelNewUsers = new System.Windows.Forms.Label();
            this.labelManageUsers = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpace = new System.Windows.Forms.PictureBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelMenuSpace = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHeaderText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelCenter.SuspendLayout();
            this.panelMenuBackground.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // timerOpacity
            // 
            this.timerOpacity.Interval = 10;
            this.timerOpacity.Tick += new System.EventHandler(this.timerOpacity_Tick);
            // 
            // panelCenter
            // 
            this.panelCenter.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_2;
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Controls.Add(this.panelContent);
            this.panelCenter.Controls.Add(this.panelMenuBackground);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 25);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(800, 550);
            this.panelCenter.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_2;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 140);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(798, 408);
            this.panelContent.TabIndex = 4;
            // 
            // panelMenuBackground
            // 
            this.panelMenuBackground.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_2;
            this.panelMenuBackground.Controls.Add(this.panelSetting);
            this.panelMenuBackground.Controls.Add(this.panelMain);
            this.panelMenuBackground.Controls.Add(this.panelUser);
            this.panelMenuBackground.Controls.Add(this.panelMenu);
            this.panelMenuBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBackground.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBackground.Name = "panelMenuBackground";
            this.panelMenuBackground.Size = new System.Drawing.Size(798, 140);
            this.panelMenuBackground.TabIndex = 3;
            this.panelMenuBackground.Visible = false;
            // 
            // panelSetting
            // 
            this.panelSetting.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_2;
            this.panelSetting.Controls.Add(this.labelCompanyDetails);
            this.panelSetting.Controls.Add(this.labelDatabaseConnection);
            this.panelSetting.Controls.Add(this.labelChangePassword);
            this.panelSetting.Controls.Add(this.labelMyProfile);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSetting.Location = new System.Drawing.Point(0, 105);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(798, 35);
            this.panelSetting.TabIndex = 4;
            // 
            // labelCompanyDetails
            // 
            this.labelCompanyDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCompanyDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCompanyDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyDetails.ForeColor = System.Drawing.Color.Black;
            this.labelCompanyDetails.Location = new System.Drawing.Point(574, 0);
            this.labelCompanyDetails.MaximumSize = new System.Drawing.Size(193, 35);
            this.labelCompanyDetails.MinimumSize = new System.Drawing.Size(193, 35);
            this.labelCompanyDetails.Name = "labelCompanyDetails";
            this.labelCompanyDetails.Size = new System.Drawing.Size(193, 35);
            this.labelCompanyDetails.TabIndex = 8;
            this.labelCompanyDetails.Text = "::: Company Details :::";
            this.labelCompanyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCompanyDetails.Click += new System.EventHandler(this.labelCompanyDetails_Click);
            // 
            // labelDatabaseConnection
            // 
            this.labelDatabaseConnection.BackColor = System.Drawing.Color.Transparent;
            this.labelDatabaseConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDatabaseConnection.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDatabaseConnection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabaseConnection.ForeColor = System.Drawing.Color.Black;
            this.labelDatabaseConnection.Location = new System.Drawing.Point(349, 0);
            this.labelDatabaseConnection.MaximumSize = new System.Drawing.Size(225, 35);
            this.labelDatabaseConnection.MinimumSize = new System.Drawing.Size(225, 35);
            this.labelDatabaseConnection.Name = "labelDatabaseConnection";
            this.labelDatabaseConnection.Size = new System.Drawing.Size(225, 35);
            this.labelDatabaseConnection.TabIndex = 7;
            this.labelDatabaseConnection.Text = "::: Database Connection :::";
            this.labelDatabaseConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDatabaseConnection.Click += new System.EventHandler(this.labelDatabaseConnection_Click);
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.labelChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangePassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChangePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangePassword.ForeColor = System.Drawing.Color.Black;
            this.labelChangePassword.Location = new System.Drawing.Point(149, 0);
            this.labelChangePassword.MaximumSize = new System.Drawing.Size(200, 35);
            this.labelChangePassword.MinimumSize = new System.Drawing.Size(200, 35);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(200, 35);
            this.labelChangePassword.TabIndex = 6;
            this.labelChangePassword.Text = "::: Change Password :::";
            this.labelChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChangePassword.Click += new System.EventHandler(this.labelChangePassword_Click);
            // 
            // labelMyProfile
            // 
            this.labelMyProfile.BackColor = System.Drawing.Color.Transparent;
            this.labelMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMyProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMyProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyProfile.Location = new System.Drawing.Point(0, 0);
            this.labelMyProfile.MaximumSize = new System.Drawing.Size(149, 35);
            this.labelMyProfile.MinimumSize = new System.Drawing.Size(149, 35);
            this.labelMyProfile.Name = "labelMyProfile";
            this.labelMyProfile.Size = new System.Drawing.Size(149, 35);
            this.labelMyProfile.TabIndex = 1;
            this.labelMyProfile.Text = "::: My Profile :::";
            this.labelMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMyProfile.Click += new System.EventHandler(this.labelMyProfile_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_2;
            this.panelMain.Controls.Add(this.labelNewItems);
            this.panelMain.Controls.Add(this.labelManageItems);
            this.panelMain.Controls.Add(this.labelMainTotal);
            this.panelMain.Controls.Add(this.labelItems);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(798, 35);
            this.panelMain.TabIndex = 0;
            // 
            // labelNewItems
            // 
            this.labelNewItems.BackColor = System.Drawing.Color.Transparent;
            this.labelNewItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNewItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNewItems.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewItems.ForeColor = System.Drawing.Color.Black;
            this.labelNewItems.Location = new System.Drawing.Point(296, 0);
            this.labelNewItems.MaximumSize = new System.Drawing.Size(154, 35);
            this.labelNewItems.MinimumSize = new System.Drawing.Size(154, 35);
            this.labelNewItems.Name = "labelNewItems";
            this.labelNewItems.Size = new System.Drawing.Size(154, 35);
            this.labelNewItems.TabIndex = 7;
            this.labelNewItems.Text = "::: New Items :::";
            this.labelNewItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNewItems.Click += new System.EventHandler(this.labelNewItems_Click);
            // 
            // labelManageItems
            // 
            this.labelManageItems.BackColor = System.Drawing.Color.Transparent;
            this.labelManageItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelManageItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelManageItems.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageItems.ForeColor = System.Drawing.Color.Black;
            this.labelManageItems.Location = new System.Drawing.Point(119, 0);
            this.labelManageItems.MaximumSize = new System.Drawing.Size(177, 35);
            this.labelManageItems.MinimumSize = new System.Drawing.Size(177, 35);
            this.labelManageItems.Name = "labelManageItems";
            this.labelManageItems.Size = new System.Drawing.Size(177, 35);
            this.labelManageItems.TabIndex = 6;
            this.labelManageItems.Text = "::: Manage Items :::";
            this.labelManageItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelManageItems.Click += new System.EventHandler(this.labelManageItems_Click);
            // 
            // labelMainTotal
            // 
            this.labelMainTotal.AutoSize = true;
            this.labelMainTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelMainTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMainTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMainTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTotal.ForeColor = System.Drawing.Color.Red;
            this.labelMainTotal.Location = new System.Drawing.Point(649, 0);
            this.labelMainTotal.Name = "labelMainTotal";
            this.labelMainTotal.Padding = new System.Windows.Forms.Padding(7);
            this.labelMainTotal.Size = new System.Drawing.Size(149, 36);
            this.labelMainTotal.TabIndex = 4;
            this.labelMainTotal.Text = "Total: RM 0.00";
            // 
            // labelItems
            // 
            this.labelItems.BackColor = System.Drawing.Color.Transparent;
            this.labelItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelItems.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(0, 0);
            this.labelItems.MaximumSize = new System.Drawing.Size(119, 35);
            this.labelItems.MinimumSize = new System.Drawing.Size(119, 35);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(119, 35);
            this.labelItems.TabIndex = 1;
            this.labelItems.Text = "::: Items :::";
            this.labelItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelItems.Click += new System.EventHandler(this.labelItems_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_2;
            this.panelUser.Controls.Add(this.labelNewUsers);
            this.panelUser.Controls.Add(this.labelManageUsers);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 35);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(798, 35);
            this.panelUser.TabIndex = 3;
            // 
            // labelNewUsers
            // 
            this.labelNewUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelNewUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNewUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNewUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUsers.ForeColor = System.Drawing.Color.Black;
            this.labelNewUsers.Location = new System.Drawing.Point(178, 0);
            this.labelNewUsers.MaximumSize = new System.Drawing.Size(130, 35);
            this.labelNewUsers.MinimumSize = new System.Drawing.Size(130, 35);
            this.labelNewUsers.Name = "labelNewUsers";
            this.labelNewUsers.Size = new System.Drawing.Size(130, 35);
            this.labelNewUsers.TabIndex = 1;
            this.labelNewUsers.Text = "::: New Users :::";
            this.labelNewUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNewUsers.Click += new System.EventHandler(this.labelNewUsers_Click);
            // 
            // labelManageUsers
            // 
            this.labelManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelManageUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelManageUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageUsers.ForeColor = System.Drawing.Color.Black;
            this.labelManageUsers.Location = new System.Drawing.Point(0, 0);
            this.labelManageUsers.MaximumSize = new System.Drawing.Size(178, 35);
            this.labelManageUsers.MinimumSize = new System.Drawing.Size(178, 35);
            this.labelManageUsers.Name = "labelManageUsers";
            this.labelManageUsers.Size = new System.Drawing.Size(178, 35);
            this.labelManageUsers.TabIndex = 0;
            this.labelManageUsers.Text = "::: Manage Users :::";
            this.labelManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelManageUsers.Click += new System.EventHandler(this.labelManageUsers_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_4;
            this.panelMenu.Controls.Add(this.pictureBoxLogout);
            this.panelMenu.Controls.Add(this.pictureBoxSpace);
            this.panelMenu.Controls.Add(this.labelSetting);
            this.panelMenu.Controls.Add(this.labelUser);
            this.panelMenu.Controls.Add(this.labelMain);
            this.panelMenu.Controls.Add(this.labelMenuSpace);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(798, 35);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogout.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_logout_1;
            this.pictureBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogout.Location = new System.Drawing.Point(757, 0);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxLogout.TabIndex = 12;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxBoxLogout_Click);
            this.pictureBoxLogout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBoxLogout_Down);
            this.pictureBoxLogout.MouseEnter += new System.EventHandler(this.pictureBoxBoxLogout_Enter);
            this.pictureBoxLogout.MouseLeave += new System.EventHandler(this.pictureBoxBoxLogout_Leave);
            // 
            // pictureBoxSpace
            // 
            this.pictureBoxSpace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSpace.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxSpace.Location = new System.Drawing.Point(792, 0);
            this.pictureBoxSpace.Name = "pictureBoxSpace";
            this.pictureBoxSpace.Size = new System.Drawing.Size(6, 35);
            this.pictureBoxSpace.TabIndex = 11;
            this.pictureBoxSpace.TabStop = false;
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetting.ForeColor = System.Drawing.Color.White;
            this.labelSetting.Image = global::APU_Store_Calculator.Properties.Resources.img_bg_4_2;
            this.labelSetting.Location = new System.Drawing.Point(233, 0);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.labelSetting.Size = new System.Drawing.Size(106, 35);
            this.labelSetting.TabIndex = 10;
            this.labelSetting.Text = "Setting";
            this.labelSetting.Click += new System.EventHandler(this.labelSetting_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Image = global::APU_Store_Calculator.Properties.Resources.img_bg_4_2;
            this.labelUser.Location = new System.Drawing.Point(151, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.labelUser.Size = new System.Drawing.Size(82, 35);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "User";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.DimGray;
            this.labelMain.Image = global::APU_Store_Calculator.Properties.Resources.img_bg_2;
            this.labelMain.Location = new System.Drawing.Point(62, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.labelMain.Size = new System.Drawing.Size(89, 35);
            this.labelMain.TabIndex = 8;
            this.labelMain.Text = "Main";
            this.labelMain.Click += new System.EventHandler(this.labelMain_Click);
            // 
            // labelMenuSpace
            // 
            this.labelMenuSpace.AutoSize = true;
            this.labelMenuSpace.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMenuSpace.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMenuSpace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuSpace.ForeColor = System.Drawing.Color.White;
            this.labelMenuSpace.Image = global::APU_Store_Calculator.Properties.Resources.img_bg_4_2;
            this.labelMenuSpace.Location = new System.Drawing.Point(0, 0);
            this.labelMenuSpace.Name = "labelMenuSpace";
            this.labelMenuSpace.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.labelMenuSpace.Size = new System.Drawing.Size(62, 35);
            this.labelMenuSpace.TabIndex = 7;
            this.labelMenuSpace.Text = ":::";
            // 
            // panelBottom
            // 
            this.panelBottom.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_1;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 575);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 25);
            this.panelBottom.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_1;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.labelHeaderText);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.panelControlBox);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 25);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // labelHeaderText
            // 
            this.labelHeaderText.AutoSize = true;
            this.labelHeaderText.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelHeaderText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelHeaderText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderText.ForeColor = System.Drawing.Color.Black;
            this.labelHeaderText.Location = new System.Drawing.Point(46, 0);
            this.labelHeaderText.Name = "labelHeaderText";
            this.labelHeaderText.Padding = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.labelHeaderText.Size = new System.Drawing.Size(92, 25);
            this.labelHeaderText.TabIndex = 6;
            this.labelHeaderText.Text = "LOGIN!";
            this.labelHeaderText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_logo_23;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(23, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // panelControlBox
            // 
            this.panelControlBox.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_bg_1;
            this.panelControlBox.Controls.Add(this.pictureBoxMin);
            this.panelControlBox.Controls.Add(this.pictureBoxClose);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlBox.Location = new System.Drawing.Point(752, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(46, 23);
            this.panelControlBox.TabIndex = 1;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_min_1;
            this.pictureBoxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxMin.TabIndex = 2;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.pictureBoxMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMin_Down);
            this.pictureBoxMin.MouseEnter += new System.EventHandler(this.pictureBoxMin_Enter);
            this.pictureBoxMin.MouseLeave += new System.EventHandler(this.pictureBoxMin_Leave);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackgroundImage = global::APU_Store_Calculator.Properties.Resources.img_close_1;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Location = new System.Drawing.Point(23, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_Down);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_Enter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Store Calculator";
            this.panelCenter.ResumeLayout(false);
            this.panelMenuBackground.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Timer timerOpacity;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelNewUsers;
        private System.Windows.Forms.Label labelManageUsers;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelMenuSpace;
        private System.Windows.Forms.Label labelManageItems;
        private System.Windows.Forms.Label labelMainTotal;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Panel panelMenuBackground;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Label labelMyProfile;
        private System.Windows.Forms.Label labelDatabaseConnection;
        private System.Windows.Forms.Label labelCompanyDetails;
        private System.Windows.Forms.Label labelNewItems;
        private System.Windows.Forms.Label labelHeaderText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.PictureBox pictureBoxSpace;
    }
}


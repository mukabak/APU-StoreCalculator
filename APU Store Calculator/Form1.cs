using System;
using System.Drawing;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    public partial class Form1 : Form
    {
        private bool boolOpacity = true;


        private void CallClassDB()
        {
            ClassDB CallClassDB = new ClassDB(this, panelContent);
        }


        private void CallClassItems()
        {
            ClassItems ClassItems = new ClassItems(this);
        }


        private void CallClassManageItems()
        {
            ClassManageItems ClassManageItems = new ClassManageItems(this);
        }


        private void CallClassNewItems()
        {
            ClassNewItems ClassNewItems = new ClassNewItems(this);
        }


        private void CallClassNewUsers()
        {
            ClassNewUsers ClassNewUsers = new ClassNewUsers(this);
        }


        private  void CallClassManageUsers()
        {
            ClassManageUsers ClassManageUsers = new ClassManageUsers(this);
        }


        private void CallClassLogin()
        {
            ClassLogin CallClassLogin = new ClassLogin(this);
        }


        private void CallClassMyProfile()
        {
            ClassMyProfile ClassMyProfile = new ClassMyProfile(this);
        }


        private void CallClassChangePassword()
        {
            ClassChangePassword ClassChangePassword = new ClassChangePassword(this);
        }


        private void CallClassConnection()
        {
            ClassConnection CallClassConnection = new ClassConnection(this);
        }


        private void CallClassCompanyDetails()
        {
            ClassCompanyDetails ClassCompanyDetails = new ClassCompanyDetails(this);
        }


        public Form1()
        {
            InitializeComponent();
            panelMenuBackground.Size = new Size(panelMenuBackground.Size.Width, 70);
            CallClassDB();
        }


        private void pictureBoxBoxLogout_Enter(object sender, EventArgs e)
        {
            pictureBoxLogout.BackgroundImage = Properties.Resources.img_logout_2;
        }


        private void pictureBoxBoxLogout_Leave(object sender, EventArgs e)
        {
            pictureBoxLogout.BackgroundImage = Properties.Resources.img_logout_1;
        }


        private void pictureBoxBoxLogout_Down(object sender, MouseEventArgs e)
        {
            pictureBoxLogout.BackgroundImage = Properties.Resources.img_logout_1;
        }


        private void pictureBoxBoxLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }


        private void pictureBoxClose_Enter(object sender, EventArgs e)
        {
            pictureBoxClose.BackgroundImage = Properties.Resources.img_close_2;
        }


        private void pictureBoxClose_Leave(object sender, EventArgs e)
        {
            pictureBoxClose.BackgroundImage = Properties.Resources.img_close_1;
        }


        private void pictureBoxClose_Down(object sender, MouseEventArgs e)
        {
            pictureBoxClose.BackgroundImage = Properties.Resources.img_controlbox_3;
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void pictureBoxMin_Enter(object sender, EventArgs e)
        {
            pictureBoxMin.BackgroundImage = Properties.Resources.img_min_2;
        }


        private void pictureBoxMin_Leave(object sender, EventArgs e)
        {
            pictureBoxMin.BackgroundImage = Properties.Resources.img_min_1;
        }


        private void pictureBoxMin_Down(object sender, MouseEventArgs e)
        {
            pictureBoxMin.BackgroundImage = Properties.Resources.img_controlbox_3;
        }


        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            timerOpacity.Start();
            this.WindowState = FormWindowState.Minimized;
        }


        private void labelMain_Click(object sender, EventArgs e)
        {
            labelMain.Image = Properties.Resources.img_bg_2_2;
            labelUser.Image = Properties.Resources.img_bg_4_2;
            labelSetting.Image = Properties.Resources.img_bg_4_2;
            labelMain.ForeColor = Color.DimGray;
            labelUser.ForeColor = Color.White;
            labelSetting.ForeColor = Color.White;
            labelItems.Font = new Font(labelItems.Font, FontStyle.Bold);
            labelManageItems.Font = new Font(labelManageItems.Font, FontStyle.Regular);
            labelNewItems.Font = new Font(labelNewItems.Font, FontStyle.Regular);
            labelMainTotal.Visible = true;
            panelMain.Visible = true;
            panelUser.Visible = false;
            panelSetting.Visible = false;
            CallClassItems();
        }


        private void labelUser_Click(object sender, EventArgs e)
        {
            labelUser.Image = Properties.Resources.img_bg_2_2;
            labelMain.Image = Properties.Resources.img_bg_4_2;
            labelSetting.Image = Properties.Resources.img_bg_4_2;
            labelMain.ForeColor = Color.White;
            labelUser.ForeColor = Color.DimGray;
            labelSetting.ForeColor = Color.White;
            panelMain.Visible = false;
            panelUser.Visible = true;
            panelSetting.Visible = false;
            labelNewUsers.Font = new Font(labelNewUsers.Font, FontStyle.Regular);
            labelManageUsers.Font = new Font(labelNewUsers.Font, FontStyle.Bold);
            CallClassManageUsers();
        }


        private void labelSetting_Click(object sender, EventArgs e)
        {
            labelMain.Image = Properties.Resources.img_bg_4_2;
            labelUser.Image = Properties.Resources.img_bg_4_2;
            labelSetting.Image = Properties.Resources.img_bg_2_2;
            labelMain.ForeColor = Color.White;
            labelUser.ForeColor = Color.White;
            labelSetting.ForeColor = Color.DimGray;
            labelMyProfile.Font = new Font(labelMyProfile.Font, FontStyle.Bold);
            labelChangePassword.Font = new Font(labelChangePassword.Font, FontStyle.Regular);
            labelDatabaseConnection.Font = new Font(labelDatabaseConnection.Font, FontStyle.Regular);
            panelMain.Visible = false;
            panelUser.Visible = false;
            panelSetting.Visible = true;
            CallClassMyProfile();
        }


        private void LogOut()
        {
            timerOpacity.Start();
            labelMain.Image = Properties.Resources.img_bg_2_2;
            labelUser.Image = Properties.Resources.img_bg_4_2;
            labelSetting.Image = Properties.Resources.img_bg_4_2;
            labelMain.ForeColor = Color.DimGray;
            labelSetting.ForeColor = Color.White;
            labelItems.Font = new Font(labelItems.Font, FontStyle.Bold);
            labelManageItems.Font = new Font(labelManageItems.Font, FontStyle.Regular);
            labelNewItems.Font = new Font(labelNewItems.Font, FontStyle.Regular);
            panelMenuBackground.Visible = false;
            labelHeaderText.Text = "LOGIN!";
            CallClassLogin();
        }


        private void labelItems_Click(object sender, EventArgs e)
        {
            labelItems.Font = new Font(labelItems.Font, FontStyle.Bold);
            labelManageItems.Font = new Font(labelManageItems.Font, FontStyle.Regular);
            labelNewItems.Font = new Font(labelNewItems.Font, FontStyle.Regular);
            CallClassItems();
            labelMainTotal.Visible = true;
        }


        private void labelManageItems_Click(object sender, EventArgs e)
        {
            labelItems.Font = new Font(labelItems.Font, FontStyle.Regular);
            labelManageItems.Font = new Font(labelManageItems.Font, FontStyle.Bold);
            labelNewItems.Font = new Font(labelNewItems.Font, FontStyle.Regular);
            CallClassManageItems();
            labelMainTotal.Visible = false;
        }


        private void labelNewItems_Click(object sender, EventArgs e)
        {
            labelItems.Font = new Font(labelItems.Font, FontStyle.Regular);
            labelManageItems.Font = new Font(labelManageItems.Font, FontStyle.Regular);
            labelNewItems.Font = new Font(labelNewItems.Font, FontStyle.Bold);
            CallClassNewItems();
            labelMainTotal.Visible = false;
        }


        private void labelManageUsers_Click(object sender, EventArgs e)
        {
            labelNewUsers.Font = new Font(labelNewUsers.Font, FontStyle.Regular);
            labelManageUsers.Font = new Font(labelNewUsers.Font, FontStyle.Bold);
            CallClassManageUsers();
        }


        private void labelNewUsers_Click(object sender, EventArgs e)
        {
            labelNewUsers.Font = new Font(labelNewUsers.Font, FontStyle.Bold);
            labelManageUsers.Font = new Font(labelNewUsers.Font, FontStyle.Regular);
            CallClassNewUsers();
        }


        private void labelMyProfile_Click(object sender, EventArgs e)
        {
            labelMyProfile.Font = new Font(labelMyProfile.Font, FontStyle.Bold);
            labelChangePassword.Font = new Font(labelChangePassword.Font, FontStyle.Regular);
            labelDatabaseConnection.Font = new Font(labelDatabaseConnection.Font, FontStyle.Regular);
            labelCompanyDetails.Font = new Font(labelDatabaseConnection.Font, FontStyle.Regular);
            CallClassMyProfile();
        }


        private void labelChangePassword_Click(object sender, EventArgs e)
        {
            labelMyProfile.Font = new Font(labelMyProfile.Font, FontStyle.Regular);
            labelChangePassword.Font = new Font(labelChangePassword.Font, FontStyle.Bold);
            labelDatabaseConnection.Font = new Font(labelDatabaseConnection.Font, FontStyle.Regular);
            labelCompanyDetails.Font = new Font(labelDatabaseConnection.Font, FontStyle.Regular);
            CallClassChangePassword();
        }


        private void labelDatabaseConnection_Click(object sender, EventArgs e)
        {
            labelMyProfile.Font = new Font(labelMyProfile.Font, FontStyle.Regular);
            labelChangePassword.Font = new Font(labelChangePassword.Font, FontStyle.Regular);
            labelDatabaseConnection.Font = new Font(labelDatabaseConnection.Font, FontStyle.Bold);
            labelCompanyDetails.Font = new Font(labelDatabaseConnection.Font, FontStyle.Regular);
            CallClassConnection();
        }


        private void labelCompanyDetails_Click(object sender, EventArgs e)
        {
            labelMyProfile.Font = new Font(labelMyProfile.Font, FontStyle.Regular);
            labelChangePassword.Font = new Font(labelChangePassword.Font, FontStyle.Regular);
            labelDatabaseConnection.Font = new Font(labelDatabaseConnection.Font, FontStyle.Regular);
            labelCompanyDetails.Font = new Font(labelDatabaseConnection.Font, FontStyle.Bold);
            CallClassCompanyDetails();
        }


        private void timerOpacity_Tick(object sender, EventArgs e)
        {

            if ((this.Opacity > 0) && (boolOpacity == true))
            {
                this.Opacity -= 0.1;
                if (this.Opacity == 0)
                {
                    boolOpacity = false;
                }
            }
            else if (boolOpacity == false)
            {
                this.Opacity += 0.05;
                if (this.Opacity == 1)
                {
                    timerOpacity.Stop();
                    boolOpacity = true;
                }
            }
        }


        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();


        private void Header_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
    }
}


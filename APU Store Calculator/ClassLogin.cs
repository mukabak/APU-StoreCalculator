using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassLogin : ClassDB
    {
        private Form formMain;
        private bool boolUsernameTextChanged = false;
        private static string[] myProperty = new string[30];

        public static string[] MyProperty
        {
            get { return myProperty; }
            set { myProperty = value; }
        }


        private void CallClassItems()
        {
            GetTableItem();
            ClassItems CallClassItemsLogin = new ClassItems(formMain);
        }


        public ClassLogin(Form form)
        {
            VoidClearUserDetails();
            VoidClearSettingDetails();
            GetTableSetting();
            GetTableUser();

            formMain = form;
            int intWidth = (formMain.Size.Width - 800) / 2;
            int intHeight = (formMain.Size.Height - 230) / 2;

            // panelLogin

            Panel panelLogin = new Panel();
            panelLogin.BackgroundImage = Properties.Resources.img_bg_4;
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Name = "panelLogin";
            panelLogin.TabIndex = 2;
            panelLogin.Controls.Clear();

            // panelLoginContent

            Panel panelLoginContent = new Panel();
            panelLoginContent.BackColor = Color.Transparent;
            panelLoginContent.Size = new Size(230, 130);
            panelLoginContent.Location = new Point(intWidth + 280, intHeight);
            panelLoginContent.Name = "panelLoginContent";
            panelLoginContent.TabIndex = 6;
            panelLoginContent.BorderStyle = BorderStyle.None;

            // labelHello

            Label labelHello = new Label();
            labelHello.Size = new Size(800, 60);
            labelHello.TextAlign = ContentAlignment.MiddleCenter;
            labelHello.BackColor = Color.Transparent;
            labelHello.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHello.ForeColor = Color.White;
            labelHello.Location = new Point(0, 50);
            labelHello.Name = "labelHello";
            labelHello.TabIndex = 0;
            labelHello.Text = "Hello!";

            // labelLogin

            Label labelLogin = new Label();
            labelLogin.AutoSize = false;
            labelLogin.Size = new Size(230, 20);
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(0, 5);
            labelLogin.Name = "labelLogin";
            labelLogin.TabIndex = 0;
            labelLogin.Text = "LOGIN";

            // textBoxLogin

            TextBox textBoxLogin = new TextBox();
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLogin.Location = new Point(15, 35);
            textBoxLogin.MaxLength = 20;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(180, 27);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.TextChanged += new EventHandler(textBoxLogin_TextChanged);

            // pictureBoxLoginBorder

            PictureBox pictureBoxLoginBorder = new PictureBox();
            pictureBoxLoginBorder.BackgroundImage = Properties.Resources.img_txt_230_black;
            pictureBoxLoginBorder.Location = new Point(0, 25);
            pictureBoxLoginBorder.Name = "pictureBoxLoginBorder";
            pictureBoxLoginBorder.Size = new Size(230, 35);
            pictureBoxLoginBorder.TabIndex = 4;
            pictureBoxLoginBorder.TabStop = false;
            pictureBoxLoginBorder.Cursor = Cursors.IBeam;
            pictureBoxLoginBorder.Click += new EventHandler(pictureBoxLoginBorder_Click);

            // labelPassword

            Label labelPassword = new Label();
            labelPassword.AutoSize = false;
            labelPassword.Size = new Size(230, 20);
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(0, 65);
            labelPassword.Name = "labelPassword";
            labelPassword.TabIndex = 0;
            labelPassword.Text = "PASSWORD";

            // textBoxPassword

            TextBox textBoxPassword = new TextBox();
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(15, 95);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.PasswordChar = '.';
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(180, 27);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.TextChanged += new EventHandler(textBoxPassword_TextChanged);

            // pictureBoxPasswordBorder

            PictureBox pictureBoxPasswordBorder = new PictureBox();
            pictureBoxPasswordBorder.BackgroundImage = Properties.Resources.img_txt_230_black;
            pictureBoxPasswordBorder.Location = new Point(0, 85);
            pictureBoxPasswordBorder.Name = "pictureBoxPasswordBorder";
            pictureBoxPasswordBorder.Size = new Size(230, 35);
            pictureBoxPasswordBorder.TabIndex = 4;
            pictureBoxPasswordBorder.TabStop = false;
            pictureBoxPasswordBorder.Cursor = Cursors.IBeam;
            pictureBoxPasswordBorder.Click += new EventHandler(pictureBoxPasswordBorder_Click);

            // panelLoginContent Update

            panelLoginContent.Controls.Add(textBoxLogin);
            panelLoginContent.Controls.Add(pictureBoxLoginBorder);
            panelLoginContent.Controls.Add(labelLogin);
            panelLoginContent.Controls.Add(textBoxPassword);
            panelLoginContent.Controls.Add(pictureBoxPasswordBorder);
            panelLoginContent.Controls.Add(labelPassword);

            // panelLogin Update

            panelLogin.Controls.Add(panelLoginContent);
            panelLogin.Controls.Add(labelHello);

            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelLogin.PointToScreen(new Point(0, 0));
            panelLogin.Parent = panelContent;
            panelLogin.Location = panelContent.PointToClient(pointPanel);
            panelLogin.BringToFront();
        }


        private void pictureBoxLoginBorder_Click(object obj_sender, EventArgs e)
        {
            var textBoxLogin = formMain.Controls.Find("textBoxLogin", true).FirstOrDefault();
            textBoxLogin.Select();
        }


        private void pictureBoxPasswordBorder_Click(object obj_sender, EventArgs e)
        {
            var textBoxPassword = formMain.Controls.Find("textBoxPassword", true).FirstOrDefault();
            textBoxPassword.Select();
        }


        private void textBoxLogin_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxLogin = obj_sender as TextBox;

            boolUsernameTextChanged = true;

            var labelHello = formMain.Controls.Find("labelHello", true).FirstOrDefault();

            var textBoxPassword = formMain.Controls.Find("textBoxPassword", true).FirstOrDefault();

            var pictureBoxLoginBorder = formMain.Controls.Find("pictureBoxLoginBorder", true).FirstOrDefault();

            var pictureBoxPasswordBorder = formMain.Controls.Find("pictureBoxPasswordBorder", true).FirstOrDefault();

            if (textBoxLogin.Text == "")
            {
                pictureBoxLoginBorder.BackgroundImage = Properties.Resources.img_txt_230_red;
            }
            else
            {
                pictureBoxLoginBorder.BackgroundImage = Properties.Resources.img_txt_230_black;
            }
            textBoxPassword.Text = "";
            pictureBoxPasswordBorder.BackgroundImage = Properties.Resources.img_txt_230_black;
            labelHello.Text = "Hello!";
        }


        private void textBoxPassword_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxPassword = obj_sender as TextBox;

            var labelHello = formMain.Controls.Find("labelHello", true).FirstOrDefault();

            var textBoxLogin = formMain.Controls.Find("textBoxLogin", true).FirstOrDefault();

            var pictureBoxLoginBorder = formMain.Controls.Find("pictureBoxLoginBorder", true).FirstOrDefault();

            var pictureBoxPasswordBorder = formMain.Controls.Find("pictureBoxPasswordBorder", true).FirstOrDefault();

            var labelHeaderText = formMain.Controls.Find("labelHeaderText", true).FirstOrDefault();

            if (textBoxPassword.Text == "")
            {
                pictureBoxPasswordBorder.BackgroundImage = Properties.Resources.img_txt_230_red;
            }
            else
            {
                pictureBoxPasswordBorder.BackgroundImage = Properties.Resources.img_txt_230_black;
            }

            if (textBoxLogin.Text == "")
            {
                labelHello.Text = "Hello!";
                pictureBoxLoginBorder.BackgroundImage = Properties.Resources.img_txt_230_red;
            }
            else 
            {
                if (boolUsernameTextChanged == true)
                {
                    voidLogin(textBoxLogin.Text);
                    boolUsernameTextChanged = false;
                }
            }

            if (MyProperty[1].Length > 0)
            {
                pictureBoxLoginBorder.BackgroundImage = Properties.Resources.img_txt_230_green;
                labelHello.Text = "Hello! " + MyProperty[2].ToString();

                if ((textBoxPassword.Text == MyProperty[7]) && (textBoxPassword.Text != ""))
                {
                    var panelMenuBackground = formMain.Controls.Find("panelMenuBackground", true).FirstOrDefault();
                    var panelMainMenu = formMain.Controls.Find("panelMain", true).FirstOrDefault();
                    var panelUserMenu = formMain.Controls.Find("panelUser", true).FirstOrDefault();
                    panelMenuBackground.Visible = true;
                    panelMainMenu.Visible = true;
                    panelUserMenu.Visible = false;

                    var labelManageItems = formMain.Controls.Find("labelManageItems", true).FirstOrDefault();
                    var labelNewItems = formMain.Controls.Find("labelNewItems", true).FirstOrDefault();
                    var labelUser = formMain.Controls.Find("labelUser", true).FirstOrDefault();
                    var labelDatabaseConnection = formMain.Controls.Find("labelDatabaseConnection", true).FirstOrDefault();
                    var labelCompanyDetails = formMain.Controls.Find("labelCompanyDetails", true).FirstOrDefault();

                    if (myProperty[4] == "cashier")
                    {
                        labelManageItems.Visible = false;
                        labelNewItems.Visible = false;
                        labelUser.Visible = false;
                        labelDatabaseConnection.Visible = false;
                        labelCompanyDetails.Visible = false;

                        labelManageItems.Enabled = false;
                        labelNewItems.Enabled = false;
                        labelUser.Enabled = false;
                        labelDatabaseConnection.Enabled = false;
                        labelCompanyDetails.Enabled = false;
                    }
                    if (myProperty[4] == "admin")
                    {
                        labelManageItems.Visible = true;
                        labelNewItems.Visible = true;
                        labelUser.Visible = true;
                        labelDatabaseConnection.Visible = true;
                        labelCompanyDetails.Visible = true;

                        labelManageItems.Enabled = true;
                        labelNewItems.Enabled = true;
                        labelUser.Enabled = true;
                        labelDatabaseConnection.Enabled = true;
                        labelCompanyDetails.Enabled = true;
                    }
                    CallClassItems();
                    labelHeaderText.Text = "User: " + MyProperty[2];
                }
                else
                {
                    pictureBoxPasswordBorder.BackgroundImage = Properties.Resources.img_txt_230_red;
                }
            }
            else
            {
                pictureBoxLoginBorder.BackgroundImage = Properties.Resources.img_txt_230_red;
            }
        }
    }
}
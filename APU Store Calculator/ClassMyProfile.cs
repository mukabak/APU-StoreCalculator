using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassMyProfile : ClassDB
    {
        private Form formMain;
        private bool UsernameAccepted = true;

        public ClassMyProfile(Form form)
        {
            formMain = form;

            int intWidth = (formMain.Size.Width - 800) / 2;
            int intHeight = (formMain.Size.Height - 600) / 2;

            // panelMyProfile

            Panel panelMyProfile = new Panel();
            panelMyProfile.BackgroundImage = Properties.Resources.img_bg_2;
            panelMyProfile.Dock = DockStyle.Fill;
            panelMyProfile.Name = "panelMyProfile";
            panelMyProfile.TabIndex = 2;
            panelMyProfile.Controls.Clear();

            // panelMyProfileContent

            Panel panelMyProfileContent = new Panel();
            panelMyProfileContent.BackColor = Color.Transparent;
            panelMyProfileContent.Location = new Point(intWidth + 265, intHeight + 60);
            panelMyProfileContent.Name = "panelMyProfileContent";
            panelMyProfileContent.AutoSize = false;
            panelMyProfileContent.Size = new Size(300, 385);
            panelMyProfileContent.TabIndex = 6;
            panelMyProfileContent.BorderStyle = BorderStyle.None;

            // labelMyProfile

            Label labelMyProfile = new Label();
            labelMyProfile.AutoSize = false;
            labelMyProfile.Size = new Size(250, 40);
            labelMyProfile.TextAlign = ContentAlignment.MiddleCenter;
            labelMyProfile.BackColor = Color.Transparent;
            labelMyProfile.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMyProfile.Location = new Point(10, 5);
            labelMyProfile.Name = "labelMyProfile";
            labelMyProfile.TabIndex = 0;
            labelMyProfile.Text = "MY PROFILE";

            // labelUserID

            Label labelUserID = new Label();
            labelUserID.AutoSize = false;
            labelUserID.Size = new Size(105, 20);
            labelUserID.TextAlign = ContentAlignment.MiddleLeft;
            labelUserID.BackColor = Color.Transparent;
            labelUserID.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserID.Location = new Point(10, 45);
            labelUserID.Name = "labelUserID";
            labelUserID.TabIndex = 0;
            labelUserID.Text = "User ID:";

            // textBoxUserID

            TextBox textBoxUserID = new TextBox();
            textBoxUserID.BackColor = Color.LightGray;
            textBoxUserID.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserID.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserID.Text = ClassLogin.MyProperty[0];
            textBoxUserID.MaxLength = 100;
            textBoxUserID.ReadOnly = true;
            textBoxUserID.Location = new Point(5, 65);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(125, 27);
            textBoxUserID.TabIndex = 0;

            // labelUserType

            Label labelUserType = new Label();
            labelUserType.AutoSize = false;
            labelUserType.Size = new Size(105, 20);
            labelUserType.TextAlign = ContentAlignment.MiddleLeft;
            labelUserType.BackColor = Color.Transparent;
            labelUserType.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserType.Location = new Point(145, 45);
            labelUserType.Name = "labelUserType";
            labelUserType.TabIndex = 0;
            labelUserType.Text = "User Type:";

            // textBoxUserType

            TextBox textBoxUserType = new TextBox();
            textBoxUserType.BackColor = Color.LightGray;
            textBoxUserType.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserType.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserType.Text = ClassLogin.MyProperty[4];
            textBoxUserType.MaxLength = 100;
            textBoxUserType.ReadOnly = true;
            textBoxUserType.Location = new Point(140, 65);
            textBoxUserType.Name = "textBoxUserType";
            textBoxUserType.Size = new Size(125, 27);
            textBoxUserType.TabIndex = 0;

            // labelUsername

            Label labelUsername = new Label();
            labelUsername.AutoSize = false;
            labelUsername.Size = new Size(280, 20);
            labelUsername.TextAlign = ContentAlignment.MiddleLeft;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(10, 95);
            labelUsername.Name = "labelUsername";
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username (Login):";

            // textBoxUsername

            TextBox textBoxUsername = new TextBox();
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Text = ClassLogin.MyProperty[1];
            textBoxUsername.MaxLength = 20;
            textBoxUsername.Location = new Point(5, 115);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(260, 27);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.TextChanged += new EventHandler(textBoxUsername_TextChanged);

            if (ClassLogin.MyProperty[1] == "superuser")
            {
                textBoxUsername.ReadOnly = true;
                textBoxUsername.BackColor = Color.LightGray;
            }

            // pictureBoxUsername

            PictureBox pictureBoxUsername = new PictureBox();
            pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxUsername.Location = new Point(270, 115);
            pictureBoxUsername.Name = "pictureBoxUsername";
            pictureBoxUsername.Size = new Size(25, 25);
            pictureBoxUsername.TabIndex = 4;
            pictureBoxUsername.TabStop = false;
            pictureBoxUsername.Visible = false;

            // labelFirstName

            Label labelFirstName = new Label();
            labelFirstName.AutoSize = false;
            labelFirstName.Size = new Size(280, 20);
            labelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(10, 145);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name:";

            // textBoxFirstName

            TextBox textBoxFirstName = new TextBox();
            textBoxFirstName.BackColor = Color.White;
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Text = ClassLogin.MyProperty[2];
            textBoxFirstName.MaxLength = 20;
            textBoxFirstName.Location = new Point(5, 165);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(260, 27);
            textBoxFirstName.TabIndex = 0;
            textBoxFirstName.TextChanged += new EventHandler(textBoxFirstName_TextChanged);

            // pictureBoxFirstName

            PictureBox pictureBoxFirstName = new PictureBox();
            pictureBoxFirstName.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxFirstName.Location = new Point(270, 165);
            pictureBoxFirstName.Name = "pictureBoxFirstName";
            pictureBoxFirstName.Size = new Size(25, 25);
            pictureBoxFirstName.TabIndex = 4;
            pictureBoxFirstName.TabStop = false;
            pictureBoxFirstName.Visible = false;

            // labelLastName

            Label labelLastName = new Label();
            labelLastName.AutoSize = false;
            labelLastName.Size = new Size(280, 20);
            labelLastName.TextAlign = ContentAlignment.MiddleLeft;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(10, 195);
            labelLastName.Name = "labelLastName";
            labelLastName.TabIndex = 0;
            labelLastName.Text = "Last Name:";

            // textBoxLastName

            TextBox textBoxLastName = new TextBox();
            textBoxLastName.BackColor = Color.White;
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Text = ClassLogin.MyProperty[3];
            textBoxLastName.MaxLength = 20;
            textBoxLastName.Location = new Point(5, 215);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(260, 27);
            textBoxLastName.TabIndex = 0;
            textBoxLastName.TextChanged += new EventHandler(textBoxLastName_TextChanged);

            // pictureBoxLastName

            PictureBox pictureBoxLastName = new PictureBox();
            pictureBoxLastName.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxLastName.Location = new Point(270, 215);
            pictureBoxLastName.Name = "pictureBoxLastName";
            pictureBoxLastName.Size = new Size(25, 25);
            pictureBoxLastName.TabIndex = 4;
            pictureBoxLastName.TabStop = false;
            pictureBoxLastName.Visible = false;

            // labelRevenue

            Label labelRevenue = new Label();
            labelRevenue.AutoSize = false;
            labelRevenue.Size = new Size(280, 20);
            labelRevenue.TextAlign = ContentAlignment.MiddleLeft;
            labelRevenue.BackColor = Color.Transparent;
            labelRevenue.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRevenue.Location = new Point(10, 245);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.TabIndex = 0;
            labelRevenue.Text = "Revenue:";

            // textBoxRevenue

            TextBox textBoxRevenue = new TextBox();
            textBoxRevenue.BackColor = Color.LightGray;
            textBoxRevenue.BorderStyle = BorderStyle.FixedSingle;
            textBoxRevenue.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRevenue.ReadOnly = true;
            textBoxRevenue.MaxLength = 100;
            textBoxRevenue.Location = new Point(5, 265);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.Size = new Size(260, 27);
            textBoxRevenue.TabIndex = 0;
            textBoxRevenue.Text = "RM " + ClassLogin.MyProperty[5];

            // pictureBoxSave

            PictureBox pictureBoxSave = new PictureBox();
            pictureBoxSave.BackgroundImage = Properties.Resources.img_save_3;
            pictureBoxSave.Cursor = Cursors.Hand;
            pictureBoxSave.Location = new Point(85, 305);
            pictureBoxSave.Name = "pictureBoxSave";
            pictureBoxSave.Size = new Size(100, 37);
            pictureBoxSave.TabIndex = 19;
            pictureBoxSave.TabStop = false;
            pictureBoxSave.Click += new EventHandler(pictureBoxSave_Click);
            pictureBoxSave.MouseEnter += new EventHandler(pictureBoxSave_Enter);
            pictureBoxSave.MouseLeave += new EventHandler(pictureBoxSave_Leave);

            // labelStatus

            Label labelStatus = new Label();
            labelStatus.AutoSize = false;
            labelStatus.Size = new Size(270, 40);
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(0, 345);
            labelStatus.Name = "labelStatus";
            labelStatus.Visible = false;
            labelStatus.ForeColor = Color.Green;
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Successfully Saved!";

            // panelMyProfileContent Update

            panelMyProfileContent.Controls.Add(labelMyProfile);
            panelMyProfileContent.Controls.Add(labelUserID);
            panelMyProfileContent.Controls.Add(textBoxUserID);
            panelMyProfileContent.Controls.Add(labelUserType);
            panelMyProfileContent.Controls.Add(textBoxUserType);
            panelMyProfileContent.Controls.Add(labelUsername);
            panelMyProfileContent.Controls.Add(textBoxUsername);
            panelMyProfileContent.Controls.Add(pictureBoxUsername);
            panelMyProfileContent.Controls.Add(labelFirstName);
            panelMyProfileContent.Controls.Add(textBoxFirstName);
            panelMyProfileContent.Controls.Add(pictureBoxFirstName);
            panelMyProfileContent.Controls.Add(labelLastName);
            panelMyProfileContent.Controls.Add(textBoxLastName);
            panelMyProfileContent.Controls.Add(pictureBoxLastName);
            panelMyProfileContent.Controls.Add(labelRevenue);
            panelMyProfileContent.Controls.Add(textBoxRevenue);
            panelMyProfileContent.Controls.Add(pictureBoxSave);
            panelMyProfileContent.Controls.Add(labelStatus);

            // panelConnection Update

            panelMyProfile.Controls.Add(panelMyProfileContent);
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelMyProfile.PointToScreen(new Point(0, 0));
            panelMyProfile.Parent = panelContent;
            panelMyProfile.Location = panelContent.PointToClient(pointPanel);
            panelMyProfile.BringToFront();
        }


        private void textBoxUsername_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxUsername = obj_sender as TextBox;
            var pictureBoxUsername = formMain.Controls.Find("pictureBoxUsername", true).FirstOrDefault();

            pictureBoxUsername.Visible = true;
            pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;
            UsernameAccepted = false;
            if (textBoxUsername.Text.Length > 4)
            {
                UsernameAccepted = true;
                pictureBoxUsername.BackgroundImage = Properties.Resources.img_correct;
                foreach (string strLogin in PubUserLogin)
                {
                    if (textBoxUsername.Text.ToUpper() == strLogin.ToUpper())
                    {
                        pictureBoxUsername.Visible = false;
                        if (textBoxUsername.Text.ToUpper() != ClassLogin.MyProperty[1].ToString().ToUpper())
                        {
                            UsernameAccepted = false;
                            pictureBoxUsername.Visible = true;
                            pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;
                        }
                    }
                }
            }
        }


        private void textBoxFirstName_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxFirstName = obj_sender as TextBox;
            var pictureBoxFirstName = formMain.Controls.Find("pictureBoxFirstName", true).FirstOrDefault();

            if (textBoxFirstName.Text != "")
            {
                pictureBoxFirstName.Visible = true;
                pictureBoxFirstName.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxFirstName.Visible = true;
                pictureBoxFirstName.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void textBoxLastName_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxLastName = obj_sender as TextBox;
            var pictureBoxLastName = formMain.Controls.Find("pictureBoxLastName", true).FirstOrDefault();

            if (textBoxLastName.Text != "")
            {
                pictureBoxLastName.Visible = true;
                pictureBoxLastName.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxLastName.Visible = true;
                pictureBoxLastName.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void pictureBoxSave_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxSave = obj_sender as PictureBox;
            var textBoxUsername = formMain.Controls.Find("textBoxUsername", true).FirstOrDefault();
            var pictureBoxUsername = formMain.Controls.Find("pictureBoxUsername", true).FirstOrDefault();
            var textBoxFirstName = formMain.Controls.Find("textBoxFirstName", true).FirstOrDefault();
            var pictureBoxFirstName = formMain.Controls.Find("pictureBoxFirstName", true).FirstOrDefault();
            var textBoxLastName = formMain.Controls.Find("textBoxLastName", true).FirstOrDefault();
            var pictureBoxLastName = formMain.Controls.Find("pictureBoxLastName", true).FirstOrDefault();
            var labelStatus = formMain.Controls.Find("labelStatus", true).FirstOrDefault();
            var labelHeaderText = formMain.Controls.Find("labelHeaderText", true).FirstOrDefault();

            labelStatus.Visible = false;

            if (textBoxUsername.Text.Length < 5)
            {
                pictureBoxUsername.Visible = true;
                pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;
            }
            if (textBoxFirstName.Text.Length < 1)
            {
                pictureBoxFirstName.Visible = true;
                pictureBoxFirstName.BackgroundImage = Properties.Resources.img_incorrect;
            }
            if (textBoxLastName.Text.Length < 1)
            {
                pictureBoxLastName.Visible = true;
                pictureBoxLastName.BackgroundImage = Properties.Resources.img_incorrect;
            }
            if ((UsernameAccepted == true) &&
                (textBoxUsername.Text.Length > 4) &&
                (textBoxFirstName.Text.Length > 0) &&
                (textBoxLastName.Text.Length > 0))
            {
                ClassLogin.MyProperty[1] = textBoxUsername.Text;
                ClassLogin.MyProperty[2] = textBoxFirstName.Text;
                ClassLogin.MyProperty[3] = textBoxLastName.Text;
                UpdateTableUser(0);
                pictureBoxUsername.Visible = false;
                pictureBoxFirstName.Visible = false;
                pictureBoxLastName.Visible = false;
                labelStatus.Visible = true;
                labelHeaderText.Text = "User: " + ClassLogin.MyProperty[2].ToString();
            }
        }


        private void pictureBoxSave_Enter(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxSave = obj_sender as PictureBox;
            pictureBoxSave.BackgroundImage = Properties.Resources.img_save_4;
        }


        private void pictureBoxSave_Leave(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxSave = obj_sender as PictureBox;
            pictureBoxSave.BackgroundImage = Properties.Resources.img_save_3;
        }
    }
}
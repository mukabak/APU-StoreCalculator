using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassNewUsers : ClassDB
    {
        private Form formMain;
        private bool boolUsernameAccepted = false;

        public ClassNewUsers(Form form)
        {
            formMain = form;

            int intWidth = (formMain.Size.Width - 800) / 2;
            int intHeight = (formMain.Size.Height - 600) / 2;

            // panelUserNewUser

            Panel panelUserNewUser = new Panel();
            panelUserNewUser.BackgroundImage = Properties.Resources.img_bg_2;
            panelUserNewUser.Dock = DockStyle.Fill;
            panelUserNewUser.Name = "panelUserNewUser";
            panelUserNewUser.TabIndex = 2;
            panelUserNewUser.Controls.Clear();

            // panelUserNewUserContent

            Panel panelUserNewUserContent = new Panel();
            panelUserNewUserContent.BackColor = Color.Transparent;
            panelUserNewUserContent.Location = new Point(intWidth + 265, intHeight + 25);
            panelUserNewUserContent.Name = "panelUserNewUserContent";
            panelUserNewUserContent.AutoSize = false;
            panelUserNewUserContent.Size = new Size(300, 410);
            panelUserNewUserContent.TabIndex = 6;
            panelUserNewUserContent.BorderStyle = BorderStyle.None;

            // labelAddNewUser

            Label labelAddNewUser = new Label();
            labelAddNewUser.AutoSize = false;
            labelAddNewUser.Size = new Size(270, 40);
            labelAddNewUser.TextAlign = ContentAlignment.MiddleCenter;
            labelAddNewUser.BackColor = Color.Transparent;
            labelAddNewUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddNewUser.Location = new Point(0, 5);
            labelAddNewUser.Name = "labelAddNewUser";
            labelAddNewUser.TabIndex = 0;
            labelAddNewUser.Text = "ADD NEW USER";

            // labelUsername

            Label labelUsername = new Label();
            labelUsername.AutoSize = false;
            labelUsername.Size = new Size(280, 20);
            labelUsername.TextAlign = ContentAlignment.MiddleLeft;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(10, 45);
            labelUsername.Name = "labelUsername";
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username (Min: 5 Characters):";

            // textBoxUsername

            TextBox textBoxUsername = new TextBox();
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(5, 65);
            textBoxUsername.MaxLength = 20;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(260, 27);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.TextChanged += new EventHandler(textBoxUsername_TextChanged);

            // pictureBoxUsername

            PictureBox pictureBoxUsername = new PictureBox();
            pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxUsername.Location = new Point(270, 65);
            pictureBoxUsername.Name = "pictureBoxUsername";
            pictureBoxUsername.Size = new Size(25, 25);
            pictureBoxUsername.TabIndex = 4;
            pictureBoxUsername.TabStop = false;
            pictureBoxUsername.Visible = false;

            // labelPassword

            Label labelPassword = new Label();
            labelPassword.AutoSize = false;
            labelPassword.Size = new Size(280, 20);
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(10, 95);
            labelPassword.Name = "labelPassword";
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Password (Min: 5 Characters):";

            // textBoxPassword

            TextBox textBoxPassword = new TextBox();
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(5, 115);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.PasswordChar = '.';
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(260, 27);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.TextChanged += new EventHandler(textBoxPassword_TextChanged);

            // pictureBoxPassword

            PictureBox pictureBoxPassword = new PictureBox();
            pictureBoxPassword.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxPassword.Location = new Point(270, 115);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(25, 25);
            pictureBoxPassword.TabIndex = 4;
            pictureBoxPassword.TabStop = false;
            pictureBoxPassword.Visible = false;

            // labelPasswordConfirm

            Label labelPasswordConfirm = new Label();
            labelPasswordConfirm.AutoSize = false;
            labelPasswordConfirm.Size = new Size(280, 20);
            labelPasswordConfirm.TextAlign = ContentAlignment.MiddleLeft;
            labelPasswordConfirm.BackColor = Color.Transparent;
            labelPasswordConfirm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPasswordConfirm.Location = new Point(10, 145);
            labelPasswordConfirm.Name = "labelPasswordConfirm";
            labelPasswordConfirm.TabIndex = 0;
            labelPasswordConfirm.Text = "Password Confirm:";

            // textBoxPasswordConfirm

            TextBox textBoxPasswordConfirm = new TextBox();
            textBoxPasswordConfirm.BackColor = Color.White;
            textBoxPasswordConfirm.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswordConfirm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPasswordConfirm.Location = new Point(5, 165);
            textBoxPasswordConfirm.MaxLength = 20;
            textBoxPasswordConfirm.PasswordChar = '.';
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.Size = new Size(260, 27);
            textBoxPasswordConfirm.TabIndex = 0;
            textBoxPasswordConfirm.TextChanged += new EventHandler(textBoxPasswordConfirm_TextChanged);

            // pictureBoxPasswordConfirm

            PictureBox pictureBoxPasswordConfirm = new PictureBox();
            pictureBoxPasswordConfirm.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxPasswordConfirm.Location = new Point(270, 165);
            pictureBoxPasswordConfirm.Name = "pictureBoxPasswordConfirm";
            pictureBoxPasswordConfirm.Size = new Size(25, 25);
            pictureBoxPasswordConfirm.TabIndex = 4;
            pictureBoxPasswordConfirm.TabStop = false;
            pictureBoxPasswordConfirm.Visible = false;

            // labelFirstName

            Label labelFirstName = new Label();
            labelFirstName.AutoSize = false;
            labelFirstName.Size = new Size(280, 20);
            labelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(10, 195);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name:";

            // textBoxFirstName

            TextBox textBoxFirstName = new TextBox();
            textBoxFirstName.BackColor = Color.White;
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(5, 215);
            textBoxFirstName.MaxLength = 20;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(260, 27);
            textBoxFirstName.TabIndex = 0;
            textBoxFirstName.TextChanged += new EventHandler(textBoxFirstName_TextChanged);

            // pictureBoxFirstName

            PictureBox pictureBoxFirstName = new PictureBox();
            pictureBoxFirstName.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxFirstName.Location = new Point(270, 215);
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
            labelLastName.Location = new Point(10, 245);
            labelLastName.Name = "labelLastName";
            labelLastName.TabIndex = 0;
            labelLastName.Text = "Last Name:";

            // textBoxLastName

            TextBox textBoxLastName = new TextBox();
            textBoxLastName.BackColor = Color.White;
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(5, 265);
            textBoxLastName.MaxLength = 20;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(260, 27);
            textBoxLastName.TabIndex = 0;
            textBoxLastName.TextChanged += new EventHandler(textBoxLastName_TextChanged);

            // pictureLastName

            PictureBox pictureBoxLastName = new PictureBox();
            pictureBoxLastName.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxLastName.Location = new Point(270, 265);
            pictureBoxLastName.Name = "pictureBoxLastName";
            pictureBoxLastName.Size = new Size(25, 25);
            pictureBoxLastName.TabIndex = 4;
            pictureBoxLastName.TabStop = false;
            pictureBoxLastName.Visible = false;

            // checkboxType

            PictureBox pictureBoxType = new PictureBox();
            pictureBoxType.BackColor = Color.Transparent;
            pictureBoxType.BackgroundImage = Properties.Resources.img_cashier;
            pictureBoxType.Location = new Point(98, 295);
            pictureBoxType.Name = "pictureBoxType";
            pictureBoxType.Size = new Size(70, 30);
            pictureBoxType.TabIndex = 4;
            pictureBoxType.TabStop = false;
            pictureBoxType.Cursor = Cursors.Hand;
            pictureBoxType.Tag = "cashier";
            pictureBoxType.Click += new EventHandler(pictureBoxType_Click);

            // pictureBoxRegister

            PictureBox pictureBoxRegister = new PictureBox();
            pictureBoxRegister.BackgroundImage = Properties.Resources.img_register_1;
            pictureBoxRegister.Cursor = Cursors.Hand;
            pictureBoxRegister.Location = new Point(85, 335);
            pictureBoxRegister.Name = "pictureBoxRegister";
            pictureBoxRegister.Size = new Size(100, 30);
            pictureBoxRegister.TabIndex = 19;
            pictureBoxRegister.TabStop = false;
            pictureBoxRegister.Click += new EventHandler(pictureBoxRegister_Click);
            pictureBoxRegister.MouseEnter += new EventHandler(pictureBoxRegister_Enter);
            pictureBoxRegister.MouseLeave += new EventHandler(pictureBoxRegister_Leave);

            // labelStatus

            Label labelStatus = new Label();
            labelStatus.AutoSize = false;
            labelStatus.Size = new Size(280, 40);
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(10, 375);
            labelStatus.Name = "labelStatus";
            labelStatus.Visible = false;
            labelStatus.ForeColor = Color.Green;
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Successfully Registered!";

            // panelUserNewUserContent Update

            panelUserNewUserContent.Controls.Add(labelAddNewUser);
            panelUserNewUserContent.Controls.Add(labelUsername);
            panelUserNewUserContent.Controls.Add(textBoxUsername);
            panelUserNewUserContent.Controls.Add(pictureBoxUsername);
            panelUserNewUserContent.Controls.Add(labelPassword);
            panelUserNewUserContent.Controls.Add(textBoxPassword);
            panelUserNewUserContent.Controls.Add(pictureBoxPassword);
            panelUserNewUserContent.Controls.Add(labelPasswordConfirm);
            panelUserNewUserContent.Controls.Add(textBoxPasswordConfirm);
            panelUserNewUserContent.Controls.Add(pictureBoxPasswordConfirm);
            panelUserNewUserContent.Controls.Add(labelFirstName);
            panelUserNewUserContent.Controls.Add(textBoxFirstName);
            panelUserNewUserContent.Controls.Add(pictureBoxFirstName);
            panelUserNewUserContent.Controls.Add(labelLastName);
            panelUserNewUserContent.Controls.Add(textBoxLastName);
            panelUserNewUserContent.Controls.Add(pictureBoxLastName);
            panelUserNewUserContent.Controls.Add(pictureBoxType);
            panelUserNewUserContent.Controls.Add(pictureBoxRegister);
            panelUserNewUserContent.Controls.Add(labelStatus);

            // panelMainNewItems Update

            panelUserNewUser.Controls.Add(panelUserNewUserContent);
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelUserNewUser.PointToScreen(new Point(0, 0));
            panelUserNewUser.Parent = panelContent;
            panelUserNewUser.Location = panelContent.PointToClient(pointPanel);
            panelUserNewUser.BringToFront();
        }


        private void textBoxUsername_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxUsername = obj_sender as TextBox;
            var pictureBoxUsername = formMain.Controls.Find("pictureBoxUsername", true).FirstOrDefault();

            boolUsernameAccepted = false;
            pictureBoxUsername.Visible = true;
            pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;

            if (textBoxUsername.Text.Length > 4)
            {
                    boolUsernameAccepted = true;
                    pictureBoxUsername.BackgroundImage = Properties.Resources.img_correct;
                foreach (string strLogin in PubUserLogin)
                {
                    if (textBoxUsername.Text.ToUpper() == strLogin.ToUpper())
                    {
                        boolUsernameAccepted = false;
                        pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;
                    }
                }
            }
        }


        private void textBoxPassword_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxPassword = obj_sender as TextBox;
            var pictureBoxPassword = formMain.Controls.Find("pictureBoxPassword", true).FirstOrDefault();

            var textBoxPasswordConfirm = formMain.Controls.Find("textBoxPasswordConfirm", true).FirstOrDefault();
            var pictureBoxPasswordConfirm = formMain.Controls.Find("pictureBoxPasswordConfirm", true).FirstOrDefault();

            if (textBoxPassword.Text.Length > 4)
            {
                pictureBoxPassword.Visible = true;
                pictureBoxPassword.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxPassword.Visible = true;
                pictureBoxPassword.BackgroundImage = Properties.Resources.img_incorrect;
            }
            textBoxPasswordConfirm.Text = "";
            pictureBoxPasswordConfirm.Visible = false;
        }


        private void textBoxPasswordConfirm_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxPasswordConfirm = obj_sender as TextBox;
            var pictureBoxPasswordConfirm = formMain.Controls.Find("pictureBoxPasswordConfirm", true).FirstOrDefault();

            var textBoxPassword = formMain.Controls.Find("textBoxPassword", true).FirstOrDefault();

            if (textBoxPasswordConfirm.Text == textBoxPassword.Text)
            {
                pictureBoxPasswordConfirm.Visible = true;
                pictureBoxPasswordConfirm.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxPasswordConfirm.Visible = true;
                pictureBoxPasswordConfirm.BackgroundImage = Properties.Resources.img_incorrect;
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


        private void pictureBoxRegister_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxRegister = obj_sender as PictureBox;

            var textBoxUsername = formMain.Controls.Find("textBoxUsername", true).FirstOrDefault();
            var pictureBoxUsername = formMain.Controls.Find("pictureBoxUsername", true).FirstOrDefault();

            var textBoxPassword = formMain.Controls.Find("textBoxPassword", true).FirstOrDefault();
            var pictureBoxPassword = formMain.Controls.Find("pictureBoxPassword", true).FirstOrDefault();

            var textBoxPasswordConfirm = formMain.Controls.Find("textBoxPasswordConfirm", true).FirstOrDefault();
            var pictureBoxPasswordConfirm = formMain.Controls.Find("pictureBoxPasswordConfirm", true).FirstOrDefault();

            var textBoxFirstName = formMain.Controls.Find("textBoxFirstName", true).FirstOrDefault();
            var pictureBoxFirstName = formMain.Controls.Find("pictureBoxFirstName", true).FirstOrDefault();

            var textBoxLastName = formMain.Controls.Find("textBoxLastName", true).FirstOrDefault();
            var pictureBoxLastName = formMain.Controls.Find("pictureBoxLastName", true).FirstOrDefault();

            var pictureBoxType = formMain.Controls.Find("pictureBoxType", true).FirstOrDefault();

            var labelStatus = formMain.Controls.Find("labelStatus", true).FirstOrDefault();

            labelStatus.Visible = false;

            if (textBoxUsername.Text.Length < 5)
            {
                pictureBoxUsername.Visible = true;
                pictureBoxUsername.BackgroundImage = Properties.Resources.img_incorrect;
            }
            if (textBoxPassword.Text.Length < 5)
            {
                pictureBoxPassword.Visible = true;
                pictureBoxPassword.BackgroundImage = Properties.Resources.img_incorrect;
            }
            if (textBoxPasswordConfirm.Text.Length < 5)
            {
                pictureBoxPasswordConfirm.Visible = true;
                pictureBoxPasswordConfirm.BackgroundImage = Properties.Resources.img_incorrect;
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
            if ((boolUsernameAccepted == true) &&
                (textBoxUsername.Text.Length > 4) &&
                (textBoxPassword.Text.Length > 4) &&
                (textBoxPassword.Text == textBoxPasswordConfirm.Text) &&
                (textBoxFirstName.Text.Length > 0) &&
                (textBoxLastName.Text.Length > 0))
            {

                    string strType = "cashier";
                    if (pictureBoxType.Tag.ToString() == "admin")
                    {
                        strType = "admin";
                    }
                InsertTableUser(textBoxUsername.Text, textBoxPassword.Text, strType, textBoxFirstName.Text, textBoxLastName.Text);

                  

                    if (PubBoolTableUpdated == true)
                    {
                        labelStatus.Visible = true;
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                        textBoxPasswordConfirm.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        pictureBoxUsername.Visible = false;
                        pictureBoxPassword.Visible = false;
                        pictureBoxPasswordConfirm.Visible = false;
                        pictureBoxFirstName.Visible = false;
                        pictureBoxLastName.Visible = false;
                    }
            }
        }


        private void pictureBoxRegister_Enter(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxRegister = obj_sender as PictureBox;
            pictureBoxRegister.BackgroundImage = Properties.Resources.img_register_2;
        }


        private void pictureBoxRegister_Leave(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxRegister = obj_sender as PictureBox;
            pictureBoxRegister.BackgroundImage = Properties.Resources.img_register_1;
        }


        private void pictureBoxType_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxType = obj_sender as PictureBox;

            if (pictureBoxType.Tag.ToString() == "cashier")
            {
                pictureBoxType.BackgroundImage = Properties.Resources.img_admin;
                pictureBoxType.Tag = "admin";
            }
            else
            {
                pictureBoxType.BackgroundImage = Properties.Resources.img_cashier;
                pictureBoxType.Tag = "cashier";
            }
        }
    }
}
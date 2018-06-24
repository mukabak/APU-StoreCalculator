using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassChangePassword : ClassDB
    {
        private Form formMain;


        public ClassChangePassword(Form form)
        {
            formMain = form;

            int intWidth = (formMain.Size.Width - 800) / 2;
            int intHeight = (formMain.Size.Height - 600) / 2;

            // panelChangePassword

            Panel panelChangePassword = new Panel();
            panelChangePassword.BackgroundImage = Properties.Resources.img_bg_2;
            panelChangePassword.Dock = DockStyle.Fill;
            panelChangePassword.Name = "panelChangePassword";
            panelChangePassword.TabIndex = 2;

            // panelChangePasswordContent

            Panel panelChangePasswordContent = new Panel();
            panelChangePasswordContent.BackColor = Color.Transparent;
            panelChangePasswordContent.Location = new Point(intWidth + 265, intHeight + 110);
            panelChangePasswordContent.Name = "panelChangePasswordContent";
            panelChangePasswordContent.AutoSize = false;
            panelChangePasswordContent.Size = new Size(300, 285);
            panelChangePasswordContent.TabIndex = 6;
            panelChangePasswordContent.BorderStyle = BorderStyle.None;

            // labelChangePassword

            Label labelChangePassword = new Label();
            labelChangePassword.AutoSize = false;
            labelChangePassword.Size = new Size(250, 40);
            labelChangePassword.TextAlign = ContentAlignment.MiddleCenter;
            labelChangePassword.BackColor = Color.Transparent;
            labelChangePassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChangePassword.Location = new Point(10, 5);
            labelChangePassword.Name = "labelChangePassword";
            labelChangePassword.TabIndex = 0;
            labelChangePassword.Text = "CHANGE PASSWORD";

            // labelOldPassword

            Label labelOldPassword = new Label();
            labelOldPassword.AutoSize = false;
            labelOldPassword.Size = new Size(280, 20);
            labelOldPassword.TextAlign = ContentAlignment.MiddleLeft;
            labelOldPassword.BackColor = Color.Transparent;
            labelOldPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOldPassword.Location = new Point(10, 45);
            labelOldPassword.Name = "labelOldPassword";
            labelOldPassword.TabIndex = 0;
            labelOldPassword.Text = "Old Password:";

            // textBoxOldPassword

            TextBox textBoxOldPassword = new TextBox();
            textBoxOldPassword.BackColor = Color.White;
            textBoxOldPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxOldPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOldPassword.PasswordChar = '.';
            textBoxOldPassword.MaxLength = 20;
            textBoxOldPassword.Location = new Point(5, 65);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.Size = new Size(260, 27);
            textBoxOldPassword.TabIndex = 0;
            textBoxOldPassword.TextChanged += new EventHandler(textBoxOldPassword_TextChanged);

            //  pictureBoxOldPassword

            PictureBox pictureBoxOldPassword = new PictureBox();
            pictureBoxOldPassword.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxOldPassword.Location = new Point(270, 65);
            pictureBoxOldPassword.Name = "pictureBoxOldPassword";
            pictureBoxOldPassword.Size = new Size(25, 25);
            pictureBoxOldPassword.TabIndex = 4;
            pictureBoxOldPassword.TabStop = false;
            pictureBoxOldPassword.Visible = false;

            // labelNewPassword

            Label labelNewPassword = new Label();
            labelNewPassword.AutoSize = false;
            labelNewPassword.Size = new Size(280, 20);
            labelNewPassword.TextAlign = ContentAlignment.MiddleLeft;
            labelNewPassword.BackColor = Color.Transparent;
            labelNewPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(10, 95);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.TabIndex = 0;
            labelNewPassword.Text = "New Password:";

            // textBoxNewPassword

            TextBox textBoxNewPassword = new TextBox();
            textBoxNewPassword.BackColor = Color.White;
            textBoxNewPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.PasswordChar = '.';
            textBoxNewPassword.MaxLength = 20;
            textBoxNewPassword.Location = new Point(5, 115);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(260, 27);
            textBoxNewPassword.TabIndex = 0;
            textBoxNewPassword.TextChanged += new EventHandler(textBoxNewPassword_TextChanged);

            //  pictureBoxNewPassword

            PictureBox pictureBoxNewPassword = new PictureBox();
            pictureBoxNewPassword.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxNewPassword.Location = new Point(270, 115);
            pictureBoxNewPassword.Name = "pictureBoxNewPassword";
            pictureBoxNewPassword.Size = new Size(25, 25);
            pictureBoxNewPassword.TabIndex = 4;
            pictureBoxNewPassword.TabStop = false;
            pictureBoxNewPassword.Visible = false;

            // labelNewPasswordConfirm

            Label labelNewPasswordConfirm = new Label();
            labelNewPasswordConfirm.AutoSize = false;
            labelNewPasswordConfirm.Size = new Size(280, 20);
            labelNewPasswordConfirm.TextAlign = ContentAlignment.MiddleLeft;
            labelNewPasswordConfirm.BackColor = Color.Transparent;
            labelNewPasswordConfirm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewPasswordConfirm.Location = new Point(10, 145);
            labelNewPasswordConfirm.Name = "labelNewPasswordConfirm";
            labelNewPasswordConfirm.TabIndex = 0;
            labelNewPasswordConfirm.Text = "New Password Confirm:";

            //  textBoxNewPasswordConfirm

            TextBox textBoxNewPasswordConfirm = new TextBox();
            textBoxNewPasswordConfirm.BackColor = Color.White;
            textBoxNewPasswordConfirm.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewPasswordConfirm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPasswordConfirm.PasswordChar = '.';
            textBoxNewPasswordConfirm.MaxLength = 20;
            textBoxNewPasswordConfirm.Location = new Point(5, 165);
            textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            textBoxNewPasswordConfirm.Size = new Size(260, 27);
            textBoxNewPasswordConfirm.TabIndex = 0;
            textBoxNewPasswordConfirm.TextChanged += new EventHandler(textBoxNewPasswordConfirm_TextChanged);

            //  pictureBoxNewPasswordConfirm

            PictureBox pictureBoxNewPasswordConfirm = new PictureBox();
            pictureBoxNewPasswordConfirm.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxNewPasswordConfirm.Location = new Point(270, 165);
            pictureBoxNewPasswordConfirm.Name = "pictureBoxNewPasswordConfirm";
            pictureBoxNewPasswordConfirm.Size = new Size(25, 25);
            pictureBoxNewPasswordConfirm.TabIndex = 4;
            pictureBoxNewPasswordConfirm.TabStop = false;
            pictureBoxNewPasswordConfirm.Visible = false;

            // pictureBoxSave

            PictureBox pictureBoxSave = new PictureBox();
            pictureBoxSave.BackgroundImage = Properties.Resources.img_save_3;
            pictureBoxSave.Cursor = Cursors.Hand;
            pictureBoxSave.Location = new Point(85, 205);
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
            labelStatus.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(0, 245);
            labelStatus.Name = "labelStatus";
            labelStatus.Visible = false;
            labelStatus.ForeColor = Color.Green;
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Successfully Saved!";

            // panelChangePasswordContent Update

            panelChangePasswordContent.Controls.Add(labelChangePassword);
            panelChangePasswordContent.Controls.Add(labelOldPassword);
            panelChangePasswordContent.Controls.Add(textBoxOldPassword);
            panelChangePasswordContent.Controls.Add(pictureBoxOldPassword);
            panelChangePasswordContent.Controls.Add(labelNewPassword);
            panelChangePasswordContent.Controls.Add(textBoxNewPassword);
            panelChangePasswordContent.Controls.Add(pictureBoxNewPassword);
            panelChangePasswordContent.Controls.Add(labelNewPasswordConfirm);
            panelChangePasswordContent.Controls.Add(textBoxNewPasswordConfirm);
            panelChangePasswordContent.Controls.Add(pictureBoxNewPasswordConfirm);
            panelChangePasswordContent.Controls.Add(pictureBoxSave);
            panelChangePasswordContent.Controls.Add(labelStatus);

            // panelChangePassword Update

            panelChangePassword.Controls.Add(panelChangePasswordContent);
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelChangePassword.PointToScreen(new Point(0, 0));
            panelChangePassword.Parent = panelContent;
            panelChangePassword.Location = panelContent.PointToClient(pointPanel);
            panelChangePassword.BringToFront();
        }


        private void textBoxOldPassword_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxOldPassword = obj_sender as TextBox;
            var pictureBoxOldPassword = formMain.Controls.Find("pictureBoxOldPassword", true).FirstOrDefault();

            pictureBoxOldPassword.Visible = true;

            if (textBoxOldPassword.Text == ClassLogin.MyProperty[7].ToString())
            {
                pictureBoxOldPassword.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxOldPassword.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void textBoxNewPassword_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxNewPassword = obj_sender as TextBox;

            var pictureBoxNewPassword = formMain.Controls.Find("pictureBoxNewPassword", true).FirstOrDefault();
            var pictureBoxNewPasswordConfirm = formMain.Controls.Find("pictureBoxNewPasswordConfirm", true).FirstOrDefault();
            var textBoxNewPasswordConfirm = formMain.Controls.Find("textBoxNewPasswordConfirm", true).FirstOrDefault();

            pictureBoxNewPassword.Visible = true;
            pictureBoxNewPasswordConfirm.Visible = false;
            textBoxNewPasswordConfirm.Text = "";

            if (textBoxNewPassword.Text.Length > 4)
            {
                pictureBoxNewPassword.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxNewPassword.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void textBoxNewPasswordConfirm_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxNewPasswordConfirm = obj_sender as TextBox;
            var textBoxNewPassword = formMain.Controls.Find("textBoxNewPassword", true).FirstOrDefault();
            var pictureBoxNewPasswordConfirm = formMain.Controls.Find("pictureBoxNewPasswordConfirm", true).FirstOrDefault();

            pictureBoxNewPasswordConfirm.Visible = true;

            if (textBoxNewPassword.Text == textBoxNewPasswordConfirm.Text)
            {
                pictureBoxNewPasswordConfirm.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxNewPasswordConfirm.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void pictureBoxSave_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxSave = obj_sender as PictureBox;

            var textBoxOldPassword = formMain.Controls.Find("textBoxOldPassword", true).FirstOrDefault();
            var pictureBoxOldPassword = formMain.Controls.Find("pictureBoxOldPassword", true).FirstOrDefault();

            var textBoxNewPassword = formMain.Controls.Find("textBoxNewPassword", true).FirstOrDefault();
            var pictureBoxNewPassword = formMain.Controls.Find("pictureBoxNewPassword", true).FirstOrDefault();

            var textBoxNewPasswordConfirm = formMain.Controls.Find("textBoxNewPasswordConfirm", true).FirstOrDefault();
            var pictureBoxNewPasswordConfirm = formMain.Controls.Find("pictureBoxNewPasswordConfirm", true).FirstOrDefault();

            var labelStatus = formMain.Controls.Find("labelStatus", true).FirstOrDefault();

            labelStatus.Visible = false;

            if ((textBoxOldPassword.Text != ClassLogin.MyProperty[11].ToString()) || (textBoxOldPassword.Text.Length < 5))
            {
                pictureBoxOldPassword.Visible = true;
                pictureBoxOldPassword.BackgroundImage = Properties.Resources.img_incorrect;
            }

            if (textBoxNewPassword.Text.Length < 5)
            {
                pictureBoxNewPassword.Visible = true;
                pictureBoxNewPassword.BackgroundImage = Properties.Resources.img_incorrect;
            }

            if (textBoxNewPassword.Text != textBoxNewPasswordConfirm.Text)
            {
                pictureBoxNewPasswordConfirm.Visible = true;
                pictureBoxNewPasswordConfirm.BackgroundImage = Properties.Resources.img_incorrect;
            }

            if ((textBoxOldPassword.Text == ClassLogin.MyProperty[7].ToString()) &&
                (textBoxOldPassword.Text.Length > 4) &&
                (textBoxNewPassword.Text.Length > 4) &&
                (textBoxNewPassword.Text == textBoxNewPasswordConfirm.Text))
            {
                ClassLogin.MyProperty[7] = textBoxNewPassword.Text;
                UpdateTableUser(0);
                textBoxOldPassword.Text = "";
                textBoxNewPassword.Text = "";
                textBoxNewPasswordConfirm.Text = "";
                pictureBoxOldPassword.Visible = false;
                pictureBoxNewPassword.Visible = false;
                pictureBoxNewPasswordConfirm.Visible = false;
                labelStatus.Visible = true;
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
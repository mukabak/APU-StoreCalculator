using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassCompanyDetails : ClassDB
    {
        private Form formMain;
        private bool boolCompanyTelephoneCorrect = true;


        public ClassCompanyDetails(Form form)
        {
            formMain = form;

            // panelCompanyDetails

            Panel panelCompanyDetails = new Panel();
            panelCompanyDetails.BackgroundImage = Properties.Resources.img_bg_2;
            panelCompanyDetails.Dock = DockStyle.Fill;
            panelCompanyDetails.Name = "panelCompanyDetails";
            panelCompanyDetails.TabIndex = 2;

            // panelCompanyDetailsContent

            Panel panelCompanyDetailsContent = new Panel();
            panelCompanyDetailsContent.BackColor = Color.Transparent;
            panelCompanyDetailsContent.Location = new Point(264, 94);
            panelCompanyDetailsContent.Name = "panelCompanyDetailsContent";
            panelCompanyDetailsContent.AutoSize = false;
            panelCompanyDetailsContent.Size = new Size(300, 290);
            panelCompanyDetailsContent.TabIndex = 6;
            panelCompanyDetailsContent.BorderStyle = BorderStyle.None;

            // labelCompanyDetails

            Label labelCompanyDetails = new Label();
            labelCompanyDetails.AutoSize = false;
            labelCompanyDetails.Size = new Size(250, 40);
            labelCompanyDetails.TextAlign = ContentAlignment.MiddleCenter;
            labelCompanyDetails.BackColor = Color.Transparent;
            labelCompanyDetails.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCompanyDetails.Location = new Point(10, 5);
            labelCompanyDetails.Name = "labelCompanyDetails";
            labelCompanyDetails.TabIndex = 0;
            labelCompanyDetails.Text = "COMPANY DETAILS";

            // labelCompanyName

            Label labelCompanyName = new Label();
            labelCompanyName.AutoSize = false;
            labelCompanyName.Size = new Size(280, 20);
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            labelCompanyName.BackColor = Color.Transparent;
            labelCompanyName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyName.Location = new Point(10, 45);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "Company Name (Max: 20):";

            // textBoxCompanyName

            TextBox textBoxCompanyName = new TextBox();
            textBoxCompanyName.BackColor = Color.White;
            textBoxCompanyName.BorderStyle = BorderStyle.FixedSingle;
            textBoxCompanyName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCompanyName.Text = ClassLogin.MyProperty[11].ToString();
            textBoxCompanyName.MaxLength = 20;
            textBoxCompanyName.Location = new Point(5, 65);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(260, 27);
            textBoxCompanyName.TabIndex = 0;
            textBoxCompanyName.TextChanged += new EventHandler(textBoxCompanyName_TextChanged);

            //  pictureBoxCompanyName

            PictureBox pictureBoxCompanyName = new PictureBox();
            pictureBoxCompanyName.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxCompanyName.Location = new Point(270, 65);
            pictureBoxCompanyName.Name = "pictureBoxCompanyName";
            pictureBoxCompanyName.Size = new Size(25, 25);
            pictureBoxCompanyName.TabIndex = 4;
            pictureBoxCompanyName.TabStop = false;
            pictureBoxCompanyName.Visible = false;

            // labelCompanyAddress

            Label labelCompanyAddress = new Label();
            labelCompanyAddress.AutoSize = false;
            labelCompanyAddress.Size = new Size(280, 20);
            labelCompanyAddress.TextAlign = ContentAlignment.MiddleLeft;
            labelCompanyAddress.BackColor = Color.Transparent;
            labelCompanyAddress.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyAddress.Location = new Point(10, 95);
            labelCompanyAddress.Name = "labelCompanyAddress";
            labelCompanyAddress.TabIndex = 0;
            labelCompanyAddress.Text = "Company Address (Max: 20):";

            // textBoxCompanyAddress

            TextBox textBoxCompanyAddress = new TextBox();
            textBoxCompanyAddress.BackColor = Color.White;
            textBoxCompanyAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxCompanyAddress.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCompanyAddress.Text = ClassLogin.MyProperty[12].ToString();
            textBoxCompanyAddress.MaxLength = 25;
            textBoxCompanyAddress.Location = new Point(5, 115);
            textBoxCompanyAddress.Name = "textBoxCompanyAddress";
            textBoxCompanyAddress.Size = new Size(260, 27);
            textBoxCompanyAddress.TabIndex = 0;
            textBoxCompanyAddress.TextChanged += new EventHandler(textBoxCompanyAddress_TextChanged);

            //  pictureBoxCompanyAddress

            PictureBox pictureBoxCompanyAddress = new PictureBox();
            pictureBoxCompanyAddress.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxCompanyAddress.Location = new Point(270, 115);
            pictureBoxCompanyAddress.Name = "pictureBoxCompanyAddress";
            pictureBoxCompanyAddress.Size = new Size(25, 25);
            pictureBoxCompanyAddress.TabIndex = 4;
            pictureBoxCompanyAddress.TabStop = false;
            pictureBoxCompanyAddress.Visible = false;

            // labelCompanyTelephone

            Label labelCompanyTelephone = new Label();
            labelCompanyTelephone.AutoSize = false;
            labelCompanyTelephone.Size = new Size(280, 20);
            labelCompanyTelephone.TextAlign = ContentAlignment.MiddleLeft;
            labelCompanyTelephone.BackColor = Color.Transparent;
            labelCompanyTelephone.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyTelephone.Location = new Point(10, 145);
            labelCompanyTelephone.Name = "labelCompanyTelephone";
            labelCompanyTelephone.TabIndex = 0;
            labelCompanyTelephone.Text = "Company Telephone (Max: 11):";

            //  textBoxCompanyTelephone

            TextBox textBoxCompanyTelephone = new TextBox();
            textBoxCompanyTelephone.BackColor = Color.White;
            textBoxCompanyTelephone.BorderStyle = BorderStyle.FixedSingle;
            textBoxCompanyTelephone.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCompanyTelephone.Text = ClassLogin.MyProperty[13].ToString();
            textBoxCompanyTelephone.MaxLength = 11;
            textBoxCompanyTelephone.Location = new Point(5, 165);
            textBoxCompanyTelephone.Name = "textBoxCompanyTelephone";
            textBoxCompanyTelephone.Size = new Size(260, 27);
            textBoxCompanyTelephone.TabIndex = 0;
            textBoxCompanyTelephone.TextChanged += new EventHandler(textBoxCompanyTelephone_TextChanged);

            //  pictureBoxCompanyTelephone

            PictureBox pictureBoxCompanyTelephone = new PictureBox();
            pictureBoxCompanyTelephone.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxCompanyTelephone.Location = new Point(270, 165);
            pictureBoxCompanyTelephone.Name = "pictureBoxCompanyTelephone";
            pictureBoxCompanyTelephone.Size = new Size(25, 25);
            pictureBoxCompanyTelephone.TabIndex = 4;
            pictureBoxCompanyTelephone.TabStop = false;
            pictureBoxCompanyTelephone.Visible = false;

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
            labelStatus.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(0, 245);
            labelStatus.Name = "labelStatus";
            labelStatus.Visible = false;
            labelStatus.ForeColor = Color.Green;
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Successfully Saved!";

            // panelCompanyDetailsContent Update

            panelCompanyDetailsContent.Controls.Add(labelCompanyDetails);
            panelCompanyDetailsContent.Controls.Add(labelCompanyName);
            panelCompanyDetailsContent.Controls.Add(textBoxCompanyName);
            panelCompanyDetailsContent.Controls.Add(pictureBoxCompanyName);
            panelCompanyDetailsContent.Controls.Add(labelCompanyAddress);
            panelCompanyDetailsContent.Controls.Add(textBoxCompanyAddress);
            panelCompanyDetailsContent.Controls.Add(pictureBoxCompanyAddress);
            panelCompanyDetailsContent.Controls.Add(labelCompanyTelephone);
            panelCompanyDetailsContent.Controls.Add(textBoxCompanyTelephone);
            panelCompanyDetailsContent.Controls.Add(pictureBoxCompanyTelephone);
            panelCompanyDetailsContent.Controls.Add(pictureBoxSave);
            panelCompanyDetailsContent.Controls.Add(labelStatus);

            // panelCompanyDetails Update

            panelCompanyDetails.Controls.Add(panelCompanyDetailsContent);
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelCompanyDetails.PointToScreen(new Point(0, 0));
            panelCompanyDetails.Parent = panelContent;
            panelCompanyDetails.Location = panelContent.PointToClient(pointPanel);
            panelCompanyDetails.BringToFront();
        }


        private void textBoxCompanyName_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxCompanyName = obj_sender as TextBox;
            var pictureBoxCompanyName = formMain.Controls.Find("pictureBoxCompanyName", true).FirstOrDefault();

            pictureBoxCompanyName.Visible = true;

            if (textBoxCompanyName.Text.Length > 0)
            {
                pictureBoxCompanyName.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxCompanyName.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void textBoxCompanyAddress_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxCompanyAddress = obj_sender as TextBox;

            var pictureBoxCompanyAddress = formMain.Controls.Find("pictureBoxCompanyAddress", true).FirstOrDefault();

            pictureBoxCompanyAddress.Visible = true;

            if (textBoxCompanyAddress.Text.Length > 0)
            {
                pictureBoxCompanyAddress.BackgroundImage = Properties.Resources.img_correct;
            }
            else
            {
                pictureBoxCompanyAddress.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void textBoxCompanyTelephone_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxCompanyTelephone = obj_sender as TextBox;
            var pictureBoxCompanyTelephone = formMain.Controls.Find("pictureBoxCompanyTelephone", true).FirstOrDefault();

            pictureBoxCompanyTelephone.Visible = true;
            boolCompanyTelephoneCorrect = false;

            try
            {
                if (Int64.Parse(textBoxCompanyTelephone.Text).ToString().Length > 0)
                {
                    pictureBoxCompanyTelephone.BackgroundImage = Properties.Resources.img_correct;
                    boolCompanyTelephoneCorrect = true;
                }
                else
                {
                    pictureBoxCompanyTelephone.BackgroundImage = Properties.Resources.img_incorrect;
                    boolCompanyTelephoneCorrect = false;
                }
            }
            catch
            {
                pictureBoxCompanyTelephone.BackgroundImage = Properties.Resources.img_incorrect;
                boolCompanyTelephoneCorrect = false;
            }
        }


        private void pictureBoxSave_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxSave = obj_sender as PictureBox;

            var textBoxCompanyName = formMain.Controls.Find("textBoxCompanyName", true).FirstOrDefault();
            var pictureBoxCompanyName = formMain.Controls.Find("pictureBoxCompanyName", true).FirstOrDefault();

            var textBoxCompanyAddress = formMain.Controls.Find("textBoxCompanyAddress", true).FirstOrDefault();
            var pictureBoxCompanyAddress = formMain.Controls.Find("pictureBoxCompanyAddress", true).FirstOrDefault();

            var textBoxCompanyTelephone = formMain.Controls.Find("textBoxCompanyTelephone", true).FirstOrDefault();
            var pictureBoxCompanyTelephone = formMain.Controls.Find("pictureBoxCompanyTelephone", true).FirstOrDefault();

            var labelStatus = formMain.Controls.Find("labelStatus", true).FirstOrDefault();

            labelStatus.Visible = false;

            if (textBoxCompanyName.Text.Length < 1)
            {
                pictureBoxCompanyName.Visible = true;
                pictureBoxCompanyName.BackgroundImage = Properties.Resources.img_incorrect;
            }

            if (textBoxCompanyAddress.Text.Length < 1)
            {
                pictureBoxCompanyAddress.Visible = true;
                pictureBoxCompanyAddress.BackgroundImage = Properties.Resources.img_incorrect;
            }

            if (boolCompanyTelephoneCorrect == false)
            {
                pictureBoxCompanyTelephone.Visible = true;
                pictureBoxCompanyTelephone.BackgroundImage = Properties.Resources.img_incorrect;
            }

            if ((textBoxCompanyName.Text.Length > 0) &&
                (textBoxCompanyAddress.Text.Length > 0) &&
                (boolCompanyTelephoneCorrect == true))
            {
                ClassLogin.MyProperty[11] = textBoxCompanyName.Text;
                ClassLogin.MyProperty[12] = textBoxCompanyAddress.Text;
                ClassLogin.MyProperty[13] = textBoxCompanyTelephone.Text;
                UpdateCompanyDetails();
                pictureBoxCompanyName.Visible = false;
                pictureBoxCompanyAddress.Visible = false;
                pictureBoxCompanyTelephone.Visible = false;
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
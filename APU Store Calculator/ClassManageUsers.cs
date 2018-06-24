using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassManageUsers : ClassDB
    {
        private Form formMain;


        private void CallClassLogin()
        {
            ClassLogin CallClassLogin = new ClassLogin(formMain);
        }


        public ClassManageUsers(Form form)
        {
            formMain = form;

            int intWidth = (formMain.Size.Width - 800) / 2;

            // panelManageUsers

            Panel panelManageUsers = new Panel();
            panelManageUsers.AutoScroll = true;
            panelManageUsers.BackgroundImage = Properties.Resources.img_bg_2;
            panelManageUsers.Dock = DockStyle.Fill;
            panelManageUsers.Name = "panelManageUsers";
            panelManageUsers.TabIndex = 2;
            panelManageUsers.Focus();
            panelManageUsers.Controls.Clear();
            panelManageUsers.Paint += new PaintEventHandler(panelManageUsers_Paint);

            // panelManageUsersHeader

            Panel panelManageUsersHeader = new Panel();
            panelManageUsersHeader.BackgroundImage = Properties.Resources.img_bg_2;
            panelManageUsersHeader.Dock = DockStyle.Top;
            panelManageUsersHeader.Name = "panelPaymentHeader";
            panelManageUsersHeader.Size = new Size(800, 25);
            panelManageUsersHeader.TabIndex = 6;

            // labelManageUsersHeaderIndex

            Label labelManageUsersHeaderIndex = new Label();
            labelManageUsersHeaderIndex.AutoSize = true;
            labelManageUsersHeaderIndex.TextAlign = ContentAlignment.MiddleCenter;
            labelManageUsersHeaderIndex.BackColor = Color.Transparent;
            labelManageUsersHeaderIndex.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageUsersHeaderIndex.Location = new Point(intWidth + 15, 5);
            labelManageUsersHeaderIndex.Name = "labelManageUsersHeaderIndex";
            labelManageUsersHeaderIndex.TabIndex = 0;
            labelManageUsersHeaderIndex.Text = "Index";

            // labelManageUsersHeaderType

            Label labelManageUsersHeaderType = new Label();
            labelManageUsersHeaderType.AutoSize = true;
            labelManageUsersHeaderType.TextAlign = ContentAlignment.MiddleCenter;
            labelManageUsersHeaderType.BackColor = Color.Transparent;
            labelManageUsersHeaderType.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageUsersHeaderType.Location = new Point(intWidth + 60, 5);
            labelManageUsersHeaderType.Name = "labelManageUsersHeaderType";
            labelManageUsersHeaderType.TabIndex = 0;
            labelManageUsersHeaderType.Text = "Type";

            // labelManageUsersHeaderFirstName

            Label labelManageUsersHeaderFirstName = new Label();
            labelManageUsersHeaderFirstName.AutoSize = true;
            labelManageUsersHeaderFirstName.TextAlign = ContentAlignment.MiddleCenter;
            labelManageUsersHeaderFirstName.BackColor = Color.Transparent;
            labelManageUsersHeaderFirstName.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageUsersHeaderFirstName.Location = new Point(intWidth + 120, 5);
            labelManageUsersHeaderFirstName.Name = "labelManageUsersHeaderFirstName";
            labelManageUsersHeaderFirstName.TabIndex = 0;
            labelManageUsersHeaderFirstName.Text = "First Name";

            // labelManageUsersHeaderLaseName

            Label labelManageUsersHeaderLaseName = new Label();
            labelManageUsersHeaderLaseName.AutoSize = true;
            labelManageUsersHeaderLaseName.TextAlign = ContentAlignment.MiddleCenter;
            labelManageUsersHeaderLaseName.BackColor = Color.Transparent;
            labelManageUsersHeaderLaseName.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageUsersHeaderLaseName.Location = new Point(intWidth + 300, 5);
            labelManageUsersHeaderLaseName.Name = "labelManageUsersHeaderLaseName";
            labelManageUsersHeaderLaseName.TabIndex = 0;
            labelManageUsersHeaderLaseName.Text = "Last Name";

            // labelManageUsersHeaderRevenue

            Label labelManageUsersHeaderRevenue = new Label();
            labelManageUsersHeaderRevenue.AutoSize = true;
            labelManageUsersHeaderRevenue.TextAlign = ContentAlignment.MiddleCenter;
            labelManageUsersHeaderRevenue.BackColor = Color.Transparent;
            labelManageUsersHeaderRevenue.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageUsersHeaderRevenue.Location = new Point(intWidth + 480, 5);
            labelManageUsersHeaderRevenue.Name = "labelManageUsersHeaderRevenue";
            labelManageUsersHeaderRevenue.TabIndex = 0;
            labelManageUsersHeaderRevenue.Text = "Revenue";

            // labelManageUsersHeaderRegisteredDate

            Label labelManageUsersHeaderRegisteredDate = new Label();
            labelManageUsersHeaderRegisteredDate.AutoSize = true;
            labelManageUsersHeaderRegisteredDate.TextAlign = ContentAlignment.MiddleCenter;
            labelManageUsersHeaderRegisteredDate.BackColor = Color.Transparent;
            labelManageUsersHeaderRegisteredDate.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageUsersHeaderRegisteredDate.Location = new Point(intWidth + 600, 5);
            labelManageUsersHeaderRegisteredDate.Name = "labelManageUsersHeaderRegisteredDate";
            labelManageUsersHeaderRegisteredDate.TabIndex = 0;
            labelManageUsersHeaderRegisteredDate.Text = "Registered Date";

            // labelManageUsersHeaderDelete

            Label labelManageUsersHeaderDelete = new Label();
            labelManageUsersHeaderDelete.AutoSize = true;
            labelManageUsersHeaderDelete.TextAlign = ContentAlignment.MiddleCenter;
            labelManageUsersHeaderDelete.BackColor = Color.Transparent;
            labelManageUsersHeaderDelete.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageUsersHeaderDelete.Location = new Point(intWidth + 720, 5);
            labelManageUsersHeaderDelete.Name = "labelManageUsersHeaderDelete";
            labelManageUsersHeaderDelete.TabIndex = 0;
            labelManageUsersHeaderDelete.Text = "Delete";

            // panelManageUsersHeader Update

            panelManageUsersHeader.Controls.Add(labelManageUsersHeaderIndex);
            panelManageUsersHeader.Controls.Add(labelManageUsersHeaderType);
            panelManageUsersHeader.Controls.Add(labelManageUsersHeaderFirstName);
            panelManageUsersHeader.Controls.Add(labelManageUsersHeaderLaseName);
            panelManageUsersHeader.Controls.Add(labelManageUsersHeaderRevenue);
            panelManageUsersHeader.Controls.Add(labelManageUsersHeaderRegisteredDate);
            panelManageUsersHeader.Controls.Add(labelManageUsersHeaderDelete);

            int i = 0;
            while (i < PubUserCounter)
            {
                // panelManageUsersContent

                Panel panelManageUsersContent = new Panel();
                panelManageUsersContent.BackgroundImage = Properties.Resources.img_bg_2;
                panelManageUsersContent.Dock = DockStyle.Top;
                panelManageUsersContent.Location = new Point(0, 0);
                panelManageUsersContent.Name = "panelManageUsersContent" + PubUserID[i].ToString();
                panelManageUsersContent.Size = new Size(798, 35);
                panelManageUsersContent.TabIndex = 6;

                // labelIndex

                Label labelIndex = new Label();
                labelIndex.Name = "labelIndex" + PubUserID[i].ToString();
                labelIndex.Text = (PubUserCounter - i).ToString();
                labelIndex.BackColor = Color.Transparent;
                labelIndex.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelIndex.AutoSize = true;
                labelIndex.Location = new Point(intWidth + 25, 8);

                // labelType

                Label labelType = new Label();
                labelType.Name = "labelType" + PubUserID[i].ToString();
                labelType.Text = PubUserType[i].ToString();
                labelType.BackColor = Color.Transparent;
                labelType.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelType.AutoSize = true;
                labelType.Location = new Point(intWidth + 60, 8);

                // labelFirstName

                Label labelFirstName = new Label();
                labelFirstName.Name = "labelFirstName" + PubUserID[i].ToString();
                labelFirstName.Text = PubUserFirstName[i].ToString();
                labelFirstName.BackColor = Color.Transparent;
                labelFirstName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelFirstName.AutoSize = true;
                labelFirstName.Location = new Point(intWidth + 120, 8);

                // labelLastName

                Label labelLastName = new Label();
                labelLastName.Name = "labelLastName" + PubUserID[i].ToString();
                labelLastName.Text = PubUserLastName[i].ToString();
                labelLastName.BackColor = Color.Transparent;
                labelLastName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelLastName.AutoSize = true;
                labelLastName.Location = new Point(intWidth + 300, 8);

                // labelRevenue

                Label labelRevenue = new Label();
                labelRevenue.Name = "labelRevenue" + PubUserID[i].ToString();
                labelRevenue.Text = "RM " + PubUserRevenue[i].ToString();
                labelRevenue.BackColor = Color.Transparent;
                labelRevenue.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelRevenue.AutoSize = true;
                labelRevenue.Location = new Point(intWidth + 480, 8);

                // labelRegisteredDate

                Label labelRegisteredDate = new Label();
                labelRegisteredDate.Name = "labelRegisteredDate" + PubUserID[i].ToString();
                labelRegisteredDate.Text = PubUserDate[i].ToString();
                labelRegisteredDate.BackColor = Color.Transparent;
                labelRegisteredDate.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelRegisteredDate.AutoSize = true;
                labelRegisteredDate.Location = new Point(intWidth + 600, 8);

                // pictureboxDelete

                PictureBox pictureboxDelete = new PictureBox();
                pictureboxDelete.Name = "pictureboxDelete" + PubUserID[i].ToString();
                pictureboxDelete.Cursor = Cursors.Hand;
                pictureboxDelete.BackColor = Color.Transparent;
                pictureboxDelete.BackgroundImage = Properties.Resources.img_delete_1;
                pictureboxDelete.BackgroundImageLayout = ImageLayout.Stretch;
                pictureboxDelete.Size = new Size(20, 20);
                pictureboxDelete.Location = new Point(intWidth + 730, 6);
                pictureboxDelete.Click += new EventHandler(pictureboxDelete_Click);
                pictureboxDelete.MouseEnter += new EventHandler(pictureboxDelete_MouseEnter);
                pictureboxDelete.MouseLeave += new EventHandler(pictureboxDelete_MouseLeave);
                pictureboxDelete.MouseDown += new MouseEventHandler(pictureboxDelete_MouseDown);
                pictureboxDelete.MouseMove += new MouseEventHandler(pictureboxDelete_MouseMove);

                if (PubUserLogin[i].ToString() == "superuser")
                {
                    pictureboxDelete.Visible = false;
                    labelIndex.ForeColor = Color.Red;
                    labelType.ForeColor = Color.Red;
                    labelFirstName.ForeColor = Color.Red;
                    labelLastName.ForeColor = Color.Red;
                    labelRevenue.ForeColor = Color.Red;
                    labelRegisteredDate.ForeColor = Color.Red;
                }

                // pictureboxManageUsersLine

                PictureBox pictureboxManageUsersLine = new PictureBox();
                pictureboxManageUsersLine.Name = "pictureboxManageUsersLine" + PubUserID[i].ToString();
                pictureboxManageUsersLine.BackColor = Color.Gray;
                pictureboxManageUsersLine.Size = new Size(760, 1);
                pictureboxManageUsersLine.Location = new Point(intWidth + 20, 34);

                // panelManageUsersContent Update

                panelManageUsersContent.Controls.Add(labelIndex);
                panelManageUsersContent.Controls.Add(labelType);
                panelManageUsersContent.Controls.Add(labelFirstName);
                panelManageUsersContent.Controls.Add(labelLastName);
                panelManageUsersContent.Controls.Add(labelRevenue);
                panelManageUsersContent.Controls.Add(labelRegisteredDate);
                panelManageUsersContent.Controls.Add(pictureboxDelete);
                panelManageUsersContent.Controls.Add(pictureboxManageUsersLine);

                // panelManageUsers Update

                panelManageUsers.Controls.Add(panelManageUsersContent);
                panelManageUsers.Focus();
                i++;
            }

            // panelManageUsers Update

            panelManageUsers.Controls.Add(panelManageUsersHeader);
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelManageUsers.PointToScreen(new Point(0, 0));
            panelManageUsers.Parent = panelContent;
            panelManageUsers.Location = panelContent.PointToClient(pointPanel);
            panelManageUsers.BringToFront();
        }


        private void pictureboxDelete_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxDelete = obj_sender as PictureBox;
            pictureboxDelete.BackgroundImage = Properties.Resources.img_delete_1;

            int intUserID = int.Parse(pictureboxDelete.Name.ToString().Substring(16, 8));

            string panelManageUsersContentName = "panelManageUsersContent" + intUserID.ToString();
            var panelManageUsersContent = formMain.Controls.Find(panelManageUsersContentName, true).FirstOrDefault();

            string pictureboxManageUsersLineName = "pictureboxManageUsersLine" + intUserID.ToString();
            var pictureboxManageUsersLine = formMain.Controls.Find(pictureboxManageUsersLineName, true).FirstOrDefault();

            var panelMenuBackground = formMain.Controls.Find("panelMenuBackground", true).FirstOrDefault();

            panelManageUsersContent.Visible = false;
            panelManageUsersContent.Enabled = false;

            pictureboxManageUsersLine.Visible = false;
            pictureboxManageUsersLine.Enabled = false;

            DeleteTableUser(intUserID);

            if (intUserID.ToString() == ClassLogin.MyProperty[0].ToString())
            {
                panelMenuBackground.Visible = false;
                CallClassLogin();
            }
        }


        private void pictureboxDelete_MouseEnter(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxDelete = obj_sender as PictureBox;
            pictureboxDelete.BackgroundImage = Properties.Resources.img_delete_2;
        }


        private void pictureboxDelete_MouseLeave(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxDelete = obj_sender as PictureBox;
            pictureboxDelete.BackgroundImage = Properties.Resources.img_delete_1;
        }


        private void pictureboxDelete_MouseDown(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxDelete = obj_sender as PictureBox;
            pictureboxDelete.BackgroundImage = Properties.Resources.img_delete_2;
        }


        private void pictureboxDelete_MouseMove(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxDelete = obj_sender as PictureBox;
            pictureboxDelete.BackgroundImage = Properties.Resources.img_delete_2;
        }


        private void panelManageUsers_Paint(object obj_sender, PaintEventArgs e)
        {
            Panel panelManageUsers = obj_sender as Panel;
            panelManageUsers.Focus();
        }
    }
}
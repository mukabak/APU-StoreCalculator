using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassConnection:ClassDB
    {
        private Form formMain;
        private bool createNewDB = false;


        public ClassConnection(Form form)
        {
            formMain = form;

            int intWidth = (formMain.Size.Width - 800) / 2;
            int intHeight = (formMain.Size.Height - 600) / 2;

            // panelConnection

            Panel panelConnection = new Panel();
            panelConnection.BackgroundImage = Properties.Resources.img_bg_2;
            panelConnection.Dock = DockStyle.Fill;
            panelConnection.Name = "panelConnection";
            panelConnection.TabIndex = 2;

            // panelConnectionContent

            Panel panelConnectionContent = new Panel();
            panelConnectionContent.BackColor = Color.Transparent;
            panelConnectionContent.Location = new Point(intWidth + 250, intHeight + 50);
            panelConnectionContent.Name = "panelConnectionContent";
            panelConnectionContent.AutoSize = false;
            panelConnectionContent.Size = new Size(300, 410);
            panelConnectionContent.TabIndex = 6;
            panelConnectionContent.BorderStyle = BorderStyle.None;

            // labelDatabaseServer

            Label labelDatabaseServer = new Label();
            labelDatabaseServer.AutoSize = false;
            labelDatabaseServer.Size = new Size(280, 40);
            labelDatabaseServer.TextAlign = ContentAlignment.MiddleCenter;
            labelDatabaseServer.BackColor = Color.Transparent;
            labelDatabaseServer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDatabaseServer.Location = new Point(10, 5);
            labelDatabaseServer.Name = "labelDatabaseServer";
            labelDatabaseServer.TabIndex = 0;
            labelDatabaseServer.Text = "DATABASE SERVER";

            // labelCreateNewDB

            Label labelCreateNewDB = new Label();
            labelCreateNewDB.AutoSize = false;
            labelCreateNewDB.Size = new Size(120, 20);
            labelCreateNewDB.TextAlign = ContentAlignment.MiddleLeft;
            labelCreateNewDB.BackColor = Color.Transparent;
            labelCreateNewDB.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreateNewDB.Location = new Point(10, 50);
            labelCreateNewDB.Name = "labelCreateNewDB";
            labelCreateNewDB.TabIndex = 0;
            labelCreateNewDB.Text = "Create New DB:";

            // pictureBoxNewDB

            PictureBox pictureBoxNewDB = new PictureBox();
            pictureBoxNewDB.BackColor = Color.Transparent;
            pictureBoxNewDB.BackgroundImage = Properties.Resources.img_no;
            pictureBoxNewDB.Location = new Point(150, 45);
            pictureBoxNewDB.Name = "pictureBoxNewDB";
            pictureBoxNewDB.Size = new Size(60, 30);
            pictureBoxNewDB.TabIndex = 4;
            pictureBoxNewDB.TabStop = false;
            pictureBoxNewDB.Cursor = Cursors.Hand;
            pictureBoxNewDB.Tag = "NO";
            pictureBoxNewDB.Click += new EventHandler(pictureBoxNewDB_Click);

            // pictureBoxRandom

            PictureBox pictureBoxRandom = new PictureBox();
            pictureBoxRandom.BackColor = Color.Transparent;
            pictureBoxRandom.BackgroundImage = Properties.Resources.img_random_1;
            pictureBoxRandom.Location = new Point(230, 45);
            pictureBoxRandom.Name = "pictureBoxRandom";
            pictureBoxRandom.Size = new Size(30, 30);
            pictureBoxRandom.TabIndex = 4;
            pictureBoxRandom.TabStop = false;
            pictureBoxRandom.Visible = false;
            pictureBoxRandom.Cursor = Cursors.Hand;
            pictureBoxRandom.Click += new EventHandler(pictureBoxRandom_Click);
            pictureBoxRandom.MouseEnter += new EventHandler(pictureBoxRandom_MouseEnter);
            pictureBoxRandom.MouseLeave += new EventHandler(pictureBoxRandom_MouseLeave);

            // labelDatabaseName

            Label labelDatabaseName = new Label();
            labelDatabaseName.AutoSize = false;
            labelDatabaseName.Size = new Size(280, 20);
            labelDatabaseName.TextAlign = ContentAlignment.MiddleLeft;
            labelDatabaseName.BackColor = Color.Transparent;
            labelDatabaseName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDatabaseName.Location = new Point(10, 75);
            labelDatabaseName.Name = "labelDatabaseName";
            labelDatabaseName.TabIndex = 0;
            labelDatabaseName.Text = "Database Name:";

            // textBoxDatabaseName

            TextBox textBoxDatabaseName = new TextBox();
            textBoxDatabaseName.BackColor = Color.White;
            textBoxDatabaseName.BorderStyle = BorderStyle.FixedSingle;
            textBoxDatabaseName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDatabaseName.MaxLength = 100;
            textBoxDatabaseName.Location = new Point(5, 95);
            textBoxDatabaseName.Name = "textBoxDatabaseName";
            textBoxDatabaseName.Size = new Size(290, 27);
            textBoxDatabaseName.TabIndex = 0;
            textBoxDatabaseName.Text = "";

            // labelServerAddress

            Label labelServerAddress = new Label();
            labelServerAddress.AutoSize = false;
            labelServerAddress.Size = new Size(280, 20);
            labelServerAddress.TextAlign = ContentAlignment.MiddleLeft;
            labelServerAddress.BackColor = Color.Transparent;
            labelServerAddress.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelServerAddress.Location = new Point(10, 125);
            labelServerAddress.Name = "labelServerAddress";
            labelServerAddress.TabIndex = 0;
            labelServerAddress.Text = "Server Address:";

            // textBoxServerAddress

            TextBox textBoxServerAddress = new TextBox();
            textBoxServerAddress.BackColor = Color.White;
            textBoxServerAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxServerAddress.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxServerAddress.MaxLength = 200;
            textBoxServerAddress.Location = new Point(5, 145);
            textBoxServerAddress.Name = "textBoxServerAddress";
            textBoxServerAddress.Size = new Size(290, 27);
            textBoxServerAddress.TabIndex = 0;
            textBoxServerAddress.Text = "";

            // labelPort

            Label labelPort = new Label();
            labelPort.AutoSize = false;
            labelPort.Size = new Size(280, 20);
            labelPort.TextAlign = ContentAlignment.MiddleLeft;
            labelPort.BackColor = Color.Transparent;
            labelPort.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPort.Location = new Point(10, 175);
            labelPort.Name = "labelPort";
            labelPort.TabIndex = 0;
            labelPort.Text = "Port:";

            // textBoxPort

            TextBox textBoxPort = new TextBox();
            textBoxPort.BackColor = Color.White;
            textBoxPort.BorderStyle = BorderStyle.FixedSingle;
            textBoxPort.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPort.MaxLength = 100;
            textBoxPort.Location = new Point(5, 195);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(290, 27);
            textBoxPort.TabIndex = 0;
            textBoxPort.Text = "";

            // labelUsername

            Label labelUsername = new Label();
            labelUsername.AutoSize = false;
            labelUsername.Size = new Size(280, 20);
            labelUsername.TextAlign = ContentAlignment.MiddleLeft;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(10, 225);
            labelUsername.Name = "labelUsername";
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";

            // textBoxUsername

            TextBox textBoxUsername = new TextBox();
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.MaxLength = 100;
            textBoxUsername.Location = new Point(5, 245);
            textBoxUsername.PasswordChar = '.';
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(290, 27);
            textBoxUsername.TabIndex = 0;
            textBoxUsername.Text = "";

            // labelPassword

            Label labelPassword = new Label();
            labelPassword.AutoSize = false;
            labelPassword.Size = new Size(280, 20);
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(10, 275);
            labelPassword.Name = "labelPassword";
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Password:";

            // textBoxPassword

            TextBox textBoxPassword = new TextBox();
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Location = new Point(5, 295);
            textBoxPassword.PasswordChar = '.';
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(290, 27);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.Text = "";

            // pictureBoxConnect

            PictureBox pictureBoxConnect = new PictureBox();
            pictureBoxConnect.BackgroundImage = Properties.Resources.img_connect_1;
            pictureBoxConnect.Cursor = Cursors.Hand;
            pictureBoxConnect.Location = new Point(100, 335);
            pictureBoxConnect.Name = "pictureBoxRegister";
            pictureBoxConnect.Size = new Size(100, 37);
            pictureBoxConnect.TabIndex = 19;
            pictureBoxConnect.TabStop = false;
            pictureBoxConnect.Click += new EventHandler(pictureBoxConnect_Click);
            pictureBoxConnect.MouseEnter += new EventHandler(pictureBoxConnect_Enter);
            pictureBoxConnect.MouseLeave += new EventHandler(pictureBoxConnect_Leave);

            // labelStatus

            Label labelStatus = new Label();
            labelStatus.AutoSize = false;
            labelStatus.Size = new Size(280, 40);
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(10, 375);
            labelStatus.Name = "labelStatusConnection";
            labelStatus.Visible = false;
            labelStatus.ForeColor = Color.Red;
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Database not connected!";

            // panelConnectionContent Update

            panelConnectionContent.Controls.Add(labelDatabaseServer);
            panelConnectionContent.Controls.Add(labelDatabaseName);
            panelConnectionContent.Controls.Add(labelCreateNewDB);
            panelConnectionContent.Controls.Add(pictureBoxNewDB);
            panelConnectionContent.Controls.Add(pictureBoxRandom);
            panelConnectionContent.Controls.Add(textBoxDatabaseName);
            panelConnectionContent.Controls.Add(labelServerAddress);
            panelConnectionContent.Controls.Add(textBoxServerAddress);
            panelConnectionContent.Controls.Add(labelPort);
            panelConnectionContent.Controls.Add(textBoxPort);
            panelConnectionContent.Controls.Add(labelUsername);
            panelConnectionContent.Controls.Add(textBoxUsername);
            panelConnectionContent.Controls.Add(labelPassword);
            panelConnectionContent.Controls.Add(textBoxPassword);
            panelConnectionContent.Controls.Add(pictureBoxConnect);
            panelConnectionContent.Controls.Add(labelStatus);

            // Update Values

            textBoxDatabaseName.Text = Properties.Settings.Default["strDatabaseName"].ToString();
            textBoxServerAddress.Text = Properties.Settings.Default["strDatabaseServer"].ToString();
            textBoxPort.Text = Properties.Settings.Default["strDatabasePort"].ToString();
            textBoxUsername.Text = Properties.Settings.Default["strDatabaseUsername"].ToString();
            textBoxPassword.Text = Properties.Settings.Default["strDatabasePassword"].ToString();

            // panelConnection Update

            panelConnection.Controls.Add(panelConnectionContent);
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelConnection.PointToScreen(new Point(0, 0));
            panelConnection.Parent = panelContent;
            panelConnection.Location = panelContent.PointToClient(pointPanel);
            panelConnection.BringToFront();
        }


        private void pictureBoxConnect_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxConnect = obj_sender as PictureBox;
            var textBoxDatabaseName = formMain.Controls.Find("textBoxDatabaseName", true).FirstOrDefault();
            var textBoxServerAddress = formMain.Controls.Find("textBoxServerAddress", true).FirstOrDefault();
            var textBoxPort = formMain.Controls.Find("textBoxPort", true).FirstOrDefault();
            var textBoxUsername = formMain.Controls.Find("textBoxUsername", true).FirstOrDefault();
            var textBoxPassword = formMain.Controls.Find("textBoxPassword", true).FirstOrDefault();
            var labelStatus = formMain.Controls.Find("labelStatusConnection", true).FirstOrDefault();
            var labelHeaderText = formMain.Controls.Find("labelHeaderText", true).FirstOrDefault();

            labelStatus.Visible = false;

            if ((textBoxDatabaseName.Text.Length > 0) && (textBoxServerAddress.Text.Length > 0) && (textBoxPort.Text.Length > 0) && (textBoxUsername.Text.Length > 0))
            {
                VoidConnectToDB(createNewDB, textBoxDatabaseName.Text, textBoxServerAddress.Text, textBoxPort.Text, textBoxUsername.Text, textBoxPassword.Text, labelStatus);
            }
            else
            {
                labelStatus.Visible = true;
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Please fill this form!";
            }
        }


        private void pictureBoxConnect_Enter(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxConnect = obj_sender as PictureBox;
            pictureBoxConnect.BackgroundImage = Properties.Resources.img_connect_2;
        }


        private void pictureBoxConnect_Leave(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxConnect = obj_sender as PictureBox;
            pictureBoxConnect.BackgroundImage = Properties.Resources.img_connect_1;
        }


        private void pictureBoxNewDB_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxNewDB = obj_sender as PictureBox;
            var pictureBoxRandom = formMain.Controls.Find("pictureBoxRandom", true).FirstOrDefault();

            if (pictureBoxNewDB.Tag.ToString() == "NO")
            {
                pictureBoxNewDB.BackgroundImage = Properties.Resources.img_yes;
                pictureBoxNewDB.Tag = "YES";
                pictureBoxRandom.Visible = true;
                createNewDB = true;
            }
            else
            {
                pictureBoxNewDB.BackgroundImage = Properties.Resources.img_no;
                pictureBoxNewDB.Tag = "NO";
                pictureBoxRandom.Visible = false;
                createNewDB = false;
            }
        }


        private void pictureBoxRandom_MouseEnter(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxRandom = obj_sender as PictureBox;
            pictureBoxRandom.BackgroundImage = Properties.Resources.img_random_2;
        }


        private void pictureBoxRandom_MouseLeave(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxRandom = obj_sender as PictureBox;
            pictureBoxRandom.BackgroundImage = Properties.Resources.img_random_1;
        }


        private void pictureBoxRandom_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxRandom = obj_sender as PictureBox;
            pictureBoxRandom.BackgroundImage = Properties.Resources.img_random_1;
            var textBoxDatabaseName = formMain.Controls.Find("textBoxDatabaseName", true).FirstOrDefault();

            Random random = new Random();
            int intRandom = random.Next(10000000, 99999999);
            textBoxDatabaseName.Text = "default_db_" + intRandom.ToString();
        }
    }
}
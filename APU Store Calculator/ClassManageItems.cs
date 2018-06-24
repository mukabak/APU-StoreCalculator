using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassManageItems : ClassDB
    {
        private Form formMain;

        public ClassManageItems(Form form)
        {
            formMain = form;
            int intWidth = (formMain.Size.Width - 800) / 2;

            // panelMainManageItems

            Panel panelMainManageItems = new Panel();
            panelMainManageItems.AutoScroll = true;
            panelMainManageItems.BackgroundImage = Properties.Resources.img_bg_2;
            panelMainManageItems.Dock = DockStyle.Fill;
            panelMainManageItems.Location = new Point(40, 97);
            panelMainManageItems.Name = "panelMainManageItems";
            panelMainManageItems.TabIndex = 2;
            panelMainManageItems.Controls.Clear();
            panelMainManageItems.Paint += new PaintEventHandler(panelMainManageItems_Paint);

            // panelManageItemsHeader

            Panel panelManageItemsHeader = new Panel();
            panelManageItemsHeader.BackgroundImage = Properties.Resources.img_bg_2;
            panelManageItemsHeader.Dock = DockStyle.Top;
            panelManageItemsHeader.Name = "panelManageItemsHeader";
            panelManageItemsHeader.Size = new Size(800, 25);
            panelManageItemsHeader.TabIndex = 6;

            // labelManageItemHeaderIndex

            Label labelManageItemHeaderIndex = new Label();
            labelManageItemHeaderIndex.AutoSize = true;
            labelManageItemHeaderIndex.BackColor = Color.Transparent;
            labelManageItemHeaderIndex.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderIndex.Location = new Point(intWidth + 25, 5);
            labelManageItemHeaderIndex.Name = "labelManageItemHeaderIndex";
            labelManageItemHeaderIndex.Size = new Size(40, 13);
            labelManageItemHeaderIndex.TabIndex = 0;
            labelManageItemHeaderIndex.Text = "No";

            // labelManageItemHeaderID

            Label labelManageItemHeaderID = new Label();
            labelManageItemHeaderID.AutoSize = true;
            labelManageItemHeaderID.BackColor = Color.Transparent;
            labelManageItemHeaderID.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderID.Location = new Point(intWidth + 60, 5);
            labelManageItemHeaderID.Name = "labelManageItemHeaderID";
            labelManageItemHeaderID.Size = new Size(40, 13);
            labelManageItemHeaderID.TabIndex = 2;
            labelManageItemHeaderID.Text = "ID";

            // labelManageItemHeaderName

            Label labelManageItemHeaderName = new Label();
            labelManageItemHeaderName.AutoSize = true;
            labelManageItemHeaderName.BackColor = Color.Transparent;
            labelManageItemHeaderName.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderName.Location = new Point(intWidth + 145, 5);
            labelManageItemHeaderName.Name = "labelManageItemHeaderName";
            labelManageItemHeaderName.Size = new Size(35, 13);
            labelManageItemHeaderName.TabIndex = 1;
            labelManageItemHeaderName.Text = "Name";

            // labelManageItemHeaderPrice

            Label labelManageItemHeaderPrice = new Label();
            labelManageItemHeaderPrice.AutoSize = true;
            labelManageItemHeaderPrice.BackColor = Color.Transparent;
            labelManageItemHeaderPrice.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderPrice.Location = new Point(intWidth + 365, 5);
            labelManageItemHeaderPrice.Name = "labelManageItemHeaderPrice";
            labelManageItemHeaderPrice.Size = new Size(55, 13);
            labelManageItemHeaderPrice.TabIndex = 3;
            labelManageItemHeaderPrice.Text = "Price";

            // labelManageItemHeaderGST

            Label labelManageItemHeaderGST = new Label();
            labelManageItemHeaderGST.AutoSize = true;
            labelManageItemHeaderGST.BackColor = Color.Transparent;
            labelManageItemHeaderGST.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderGST.Location = new Point(intWidth + 480, 5);
            labelManageItemHeaderGST.Name = "labelManageItemHeaderGST";
            labelManageItemHeaderGST.Size = new Size(31, 13);
            labelManageItemHeaderGST.TabIndex = 5;
            labelManageItemHeaderGST.Text = "GST";

            // labelManageItemHeaderQuantity

            Label labelManageItemHeaderQuantity = new Label();
            labelManageItemHeaderQuantity.AutoSize = true;
            labelManageItemHeaderQuantity.BackColor = Color.Transparent;
            labelManageItemHeaderQuantity.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderQuantity.Location = new Point(intWidth + 545, 5);
            labelManageItemHeaderQuantity.Name = "labelManageItemHeaderQuantity";
            labelManageItemHeaderQuantity.Size = new Size(63, 13);
            labelManageItemHeaderQuantity.TabIndex = 6;
            labelManageItemHeaderQuantity.Text = "Quantity";

            // labelManageItemHeaderSave

            Label labelManageItemHeaderSave = new Label();
            labelManageItemHeaderSave.AutoSize = true;
            labelManageItemHeaderSave.BackColor = Color.Transparent;
            labelManageItemHeaderSave.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderSave.Location = new Point(intWidth + 643, 5);
            labelManageItemHeaderSave.Name = "labelManageItemHeaderSave";
            labelManageItemHeaderSave.Size = new Size(66, 13);
            labelManageItemHeaderSave.TabIndex = 7;
            labelManageItemHeaderSave.Text = "Save";

            // labelManageItemHeaderDelete

            Label labelManageItemHeaderDelete = new Label();
            labelManageItemHeaderDelete.AutoSize = true;
            labelManageItemHeaderDelete.BackColor = Color.Transparent;
            labelManageItemHeaderDelete.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManageItemHeaderDelete.Location = new Point(intWidth + 720, 5);
            labelManageItemHeaderDelete.Name = "labelManageItemHeaderDelete";
            labelManageItemHeaderDelete.Size = new Size(66, 13);
            labelManageItemHeaderDelete.TabIndex = 7;
            labelManageItemHeaderDelete.Text = "Delete";

            // Dynamically Create Objects

            int i = 0;
            while (i < PubItemCounter)
            {

                // panelManageItemContent

                Panel panelManageItemContent = new Panel();
                panelManageItemContent.BackgroundImage = Properties.Resources.img_bg_2;
                panelManageItemContent.Dock = DockStyle.Top;
                panelManageItemContent.Location = new Point(0, 0);
                panelManageItemContent.Name = "panelManageItemContent" + PubItemID[i].ToString();
                panelManageItemContent.Size = new Size(798, 35);
                panelManageItemContent.TabIndex = 6;

                // labelManageItemIndex

                Label labelManageItemIndex = new Label();
                labelManageItemIndex.Name = "labelManageItemIndex" + PubItemID[i].ToString();
                labelManageItemIndex.Text = (PubItemCounter - i).ToString();
                labelManageItemIndex.BackColor = Color.Transparent;
                labelManageItemIndex.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelManageItemIndex.AutoSize = true;
                labelManageItemIndex.Location = new Point(intWidth + 25, 7);

                // labelManageItemID

                Label labelManageItemID = new Label();
                labelManageItemID.Name = "labelManageItemID" + PubItemID[i].ToString();
                labelManageItemID.Text = PubItemID[i].ToString();
                labelManageItemID.BackColor = Color.Transparent;
                labelManageItemID.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelManageItemID.AutoSize = true;
                labelManageItemID.Location = new Point(intWidth + 60, 7);

                // textboxManageItemName

                TextBox textboxManageItemName = new TextBox();
                textboxManageItemName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                textboxManageItemName.Location = new Point(intWidth + 150, 5);
                textboxManageItemName.Name = "textboxManageItemName" + PubItemID[i].ToString();
                textboxManageItemName.Text = PubItemName[i].ToString();
                textboxManageItemName.Size = new Size(200, 20);
                textboxManageItemName.TabIndex = 1;
                textboxManageItemName.BorderStyle = BorderStyle.FixedSingle;
                textboxManageItemName.BackColor = Color.White;
                textboxManageItemName.MaxLength = 20;
                textboxManageItemName.TextChanged += new EventHandler(textboxManageItemName_TextChanged);

                // textboxManageItemPrice

                TextBox textboxManageItemPrice = new TextBox();
                textboxManageItemPrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                textboxManageItemPrice.Location = new Point(intWidth + 370, 5);
                textboxManageItemPrice.Name = "textboxManageItemPrice" + PubItemID[i].ToString();
                textboxManageItemPrice.Text = PubItemPrice[i].ToString();
                textboxManageItemPrice.Size = new Size(90, 20);
                textboxManageItemPrice.TabIndex = 1;
                textboxManageItemPrice.BorderStyle = BorderStyle.FixedSingle;
                textboxManageItemPrice.BackColor = Color.White;
                textboxManageItemPrice.MaxLength = 10;
                textboxManageItemPrice.TextChanged += new EventHandler(textboxManageItemPrice_TextChanged);

                // pictureBoxGST

                PictureBox pictureBoxGST = new PictureBox();
                pictureBoxGST.BackColor = Color.Transparent;
                pictureBoxGST.BackgroundImage = Properties.Resources.img_gst_0;
                pictureBoxGST.Location = new Point(intWidth + 480, 2);
                pictureBoxGST.Name = "pictureBoxGST" + PubItemID[i].ToString();
                pictureBoxGST.Size = new Size(60, 30);
                pictureBoxGST.TabIndex = 4;
                pictureBoxGST.TabStop = false;
                pictureBoxGST.Cursor = Cursors.Hand;
                pictureBoxGST.Tag = "0";
                pictureBoxGST.Click += new EventHandler(pictureBoxGST_Click);

                if (PubItemTax[i] > 0)
                {
                    pictureBoxGST.BackgroundImage = Properties.Resources.img_gst_6;
                    pictureBoxGST.Tag = "6";
                }

                // textboxManageItemQuantity

                TextBox textboxManageItemQuantity = new TextBox();
                textboxManageItemQuantity.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                textboxManageItemQuantity.Location = new Point(intWidth + 550, 5);
                textboxManageItemQuantity.Name = "textboxManageItemQuantity" + PubItemID[i].ToString();
                textboxManageItemQuantity.Text = PubItemQuantity[i].ToString();
                textboxManageItemQuantity.Size = new Size(80, 20);
                textboxManageItemQuantity.TabIndex = 1;
                textboxManageItemQuantity.BorderStyle = BorderStyle.FixedSingle;
                textboxManageItemQuantity.BackColor = Color.White;
                textboxManageItemQuantity.MaxLength = 10;
                textboxManageItemQuantity.TextChanged += new EventHandler(textboxManageItemQuantity_TextChanged);

                //pictureboxManageItemSave

                PictureBox pictureboxManageItemSave = new PictureBox();
                pictureboxManageItemSave.Name = "pictureboxManageItemSave" + PubItemID[i].ToString();
                pictureboxManageItemSave.Cursor = Cursors.Hand;
                pictureboxManageItemSave.BackColor = Color.Transparent;
                pictureboxManageItemSave.BackgroundImage = Properties.Resources.img_save_1;
                pictureboxManageItemSave.BackgroundImageLayout = ImageLayout.Stretch;
                pictureboxManageItemSave.Size = new Size(20, 20);
                pictureboxManageItemSave.Location = new Point(intWidth + 650, 7);
                pictureboxManageItemSave.Visible = false;
                pictureboxManageItemSave.Click += new EventHandler(pictureboxManageItemSave_Click);
                pictureboxManageItemSave.MouseEnter += new EventHandler(pictureboxManageItemSave_MouseEnter);
                pictureboxManageItemSave.MouseLeave += new EventHandler(pictureboxManageItemSave_MouseLeave);
                pictureboxManageItemSave.MouseDown += new MouseEventHandler(pictureboxManageItemSave_MouseDown);
                pictureboxManageItemSave.MouseMove += new MouseEventHandler(pictureboxManageItemSave_MouseMove);

                // labelSpace

                Label labelSpace = new Label();
                labelSpace.Name = "labelSpace" + PubItemID[i].ToString();
                labelSpace.Text = "::::";
                labelSpace.BackColor = Color.Transparent;
                labelSpace.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelSpace.AutoSize = true;
                labelSpace.Location = new Point(intWidth + 685, 8);

                //pictureboxManageItemDelete

                PictureBox pictureboxManageItemDelete = new PictureBox();
                pictureboxManageItemDelete.Name = "pictureboxManageItemDelete" + PubItemID[i].ToString();
                pictureboxManageItemDelete.Cursor = Cursors.Hand;
                pictureboxManageItemDelete.BackColor = Color.Transparent;
                pictureboxManageItemDelete.BackgroundImage = Properties.Resources.img_delete_1;
                pictureboxManageItemDelete.BackgroundImageLayout = ImageLayout.Stretch;
                pictureboxManageItemDelete.Size = new Size(20, 20);
                pictureboxManageItemDelete.Location = new Point(intWidth + 730, 7);
                pictureboxManageItemDelete.Click += new EventHandler(pictureboxManageItemDelete_Click);
                pictureboxManageItemDelete.MouseEnter += new EventHandler(pictureboxManageItemDelete_MouseEnter);
                pictureboxManageItemDelete.MouseLeave += new EventHandler(pictureboxManageItemDelete_MouseLeave);
                pictureboxManageItemDelete.MouseDown += new MouseEventHandler(pictureboxManageItemDelete_MouseDown);
                pictureboxManageItemDelete.MouseMove += new MouseEventHandler(pictureboxManageItemDelete_MouseMove);

                // pictureboxManageItemLine

                PictureBox pictureboxManageItemLine = new PictureBox();
                pictureboxManageItemLine.Name = "pictureboxManageItemLine" + PubItemID[i].ToString();
                pictureboxManageItemLine.BackColor = Color.Gray;
                pictureboxManageItemLine.Size = new Size(760, 1);
                pictureboxManageItemLine.Location = new Point(intWidth + 20, 34);

                // panelManageItemsHeader Update

                panelManageItemsHeader.Controls.Add(labelManageItemHeaderIndex);
                panelManageItemsHeader.Controls.Add(labelManageItemHeaderID);
                panelManageItemsHeader.Controls.Add(labelManageItemHeaderName);
                panelManageItemsHeader.Controls.Add(labelManageItemHeaderPrice);
                panelManageItemsHeader.Controls.Add(labelManageItemHeaderGST);
                panelManageItemsHeader.Controls.Add(labelManageItemHeaderQuantity);
                panelManageItemsHeader.Controls.Add(labelManageItemHeaderSave);
                panelManageItemsHeader.Controls.Add(labelManageItemHeaderDelete);

                // panelMainManageItems Update

                panelMainManageItems.Controls.Add(panelManageItemContent);
                panelMainManageItems.Controls.Add(panelManageItemsHeader);

                panelManageItemContent.Controls.Add(labelManageItemIndex);
                panelManageItemContent.Controls.Add(labelManageItemID);
                panelManageItemContent.Controls.Add(textboxManageItemName);
                panelManageItemContent.Controls.Add(textboxManageItemPrice);
                panelManageItemContent.Controls.Add(pictureBoxGST);
                panelManageItemContent.Controls.Add(textboxManageItemQuantity);
                panelManageItemContent.Controls.Add(pictureboxManageItemSave);
                panelManageItemContent.Controls.Add(labelSpace);
                panelManageItemContent.Controls.Add(pictureboxManageItemDelete);
                panelManageItemContent.Controls.Add(pictureboxManageItemLine);
                panelManageItemContent.Focus();
                i++;
            }
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelMainManageItems.PointToScreen(new Point(0, 0));
            panelMainManageItems.Parent = panelContent;
            panelMainManageItems.Location = panelContent.PointToClient(pointPanel);
            panelMainManageItems.BringToFront();
        }


        private void pictureboxManageItemSave_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemSave = obj_sender as PictureBox;
            pictureboxManageItemSave.BackgroundImage = Properties.Resources.img_save_1;
            int intItemID = int.Parse(pictureboxManageItemSave.Name.ToString().Substring(24, 8));

            string textboxManageItemName = "textboxManageItemName" + intItemID.ToString();
            var ManageItemName = formMain.Controls.Find(textboxManageItemName, true).FirstOrDefault();
            string strManageItemName = ManageItemName.Text;

                string textboxManageItemPrice = "textboxManageItemPrice" + intItemID;
                var ManageItemPrice = formMain.Controls.Find(textboxManageItemPrice, true).FirstOrDefault();
                float floatManageItemPrice = float.Parse(ManageItemPrice.Text);

                string pictureBoxGSTName = "pictureBoxGST" + intItemID;
                var pictureBoxGST = formMain.Controls.Find(pictureBoxGSTName, true).FirstOrDefault();

                string textboxManageItemQuantity = "textboxManageItemQuantity" + intItemID;
                var ManageItemQuantity = formMain.Controls.Find(textboxManageItemQuantity, true).FirstOrDefault();
                int intManageItemQuantity = int.Parse(ManageItemQuantity.Text);

                float floatcheckboxGST = 0;
                if (pictureBoxGST.Tag.ToString() == "6")
                {
                    floatcheckboxGST = 6;
                }

            decimal decimalPrice = Math.Round((decimal)floatManageItemPrice, 2);
            ManageItemPrice.Text = decimalPrice.ToString();

            UpdateTableItem(intItemID, strManageItemName, decimalPrice, floatcheckboxGST, intManageItemQuantity);

                if (PubBoolTableUpdated == true)
                {
                    pictureboxManageItemSave.Visible = false;
                    ManageItemName.BackColor = Color.White;
                    ManageItemPrice.BackColor = Color.White;
                    ManageItemQuantity.BackColor = Color.White;
            }
        }


        private void pictureboxManageItemSave_MouseDown(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemSave = obj_sender as PictureBox;
            pictureboxManageItemSave.BackgroundImage = Properties.Resources.img_save_1;
        }


        private void pictureboxManageItemSave_MouseEnter(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemSave = obj_sender as PictureBox;
            pictureboxManageItemSave.BackgroundImage = Properties.Resources.img_save_2;
        }


        private void pictureboxManageItemSave_MouseLeave(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemSave = obj_sender as PictureBox;
            pictureboxManageItemSave.BackgroundImage = Properties.Resources.img_save_1;
        }


        private void pictureboxManageItemSave_MouseMove(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemSave = obj_sender as PictureBox;
            pictureboxManageItemSave.BackgroundImage = Properties.Resources.img_save_2;
        }


        private void pictureboxManageItemDelete_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemDelete = obj_sender as PictureBox;
            pictureboxManageItemDelete.BackgroundImage = Properties.Resources.img_delete_1;
            int intItemID = int.Parse(pictureboxManageItemDelete.Name.ToString().Substring(26, 8));

            string panelManageItemContentName = "panelManageItemContent" + intItemID.ToString();
            var panelManageItemContent = formMain.Controls.Find(panelManageItemContentName, true).FirstOrDefault();

            string pictureboxManageItemLineName = "pictureboxManageItemLine" + intItemID.ToString();
            var pictureboxManageItemLine = formMain.Controls.Find(pictureboxManageItemLineName, true).FirstOrDefault();

            DeleteTableItem(intItemID);

            pictureboxManageItemLine.Visible = false;
            pictureboxManageItemLine.Enabled = false;
            panelManageItemContent.Visible = false;
            panelManageItemContent.Enabled = false;
        }


        private void pictureboxManageItemDelete_MouseDown(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemDelete = obj_sender as PictureBox;
            pictureboxManageItemDelete.BackgroundImage = Properties.Resources.img_delete_1;
        }


        private void pictureboxManageItemDelete_MouseEnter(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemDelete = obj_sender as PictureBox;
            pictureboxManageItemDelete.BackgroundImage = Properties.Resources.img_delete_2;
        }


        private void pictureboxManageItemDelete_MouseLeave(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemDelete = obj_sender as PictureBox;
            pictureboxManageItemDelete.BackgroundImage = Properties.Resources.img_delete_1;
        }


        private void pictureboxManageItemDelete_MouseMove(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxManageItemDelete = obj_sender as PictureBox;
            pictureboxManageItemDelete.BackgroundImage = Properties.Resources.img_delete_2;
        }


        private void panelMainManageItems_Paint(object obj_sender, PaintEventArgs e)
        {
            Panel panelMainManageItems = obj_sender as Panel;
            panelMainManageItems.Focus();
        }


        private void textboxManageItemName_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textboxManageItemName = obj_sender as TextBox;
            int intItemID = int.Parse(textboxManageItemName.Name.ToString().Substring(21, 8));
            itemNameCheck(intItemID);
            itemPriceCheck(intItemID);
            itemQuantityCheck(intItemID);
        }


        private void itemNameCheck(int intItemID)
        {
            int intIndex = Array.IndexOf(PubItemID, intItemID);
            string pictureboxManageItemSaveName = "pictureboxManageItemSave" + intItemID.ToString();
            var pictureboxManageItemSave = formMain.Controls.Find(pictureboxManageItemSaveName, true).FirstOrDefault();

            string textboxManageItemNameName = "textboxManageItemName" + intItemID.ToString();
            var textboxManageItemName = formMain.Controls.Find(textboxManageItemNameName, true).FirstOrDefault();

            PubItemNameCorrect[intIndex] = false;
            pictureboxManageItemSave.Visible = false;
            textboxManageItemName.BackColor = Color.Pink;

            if (textboxManageItemName.Text.Length > 0)
            {
                PubItemNameCorrect[intIndex] = true;
                textboxManageItemName.BackColor = Color.LightGreen;
                pictureboxManageItemSave.Visible = true;

                foreach (string strEach in PubItemName)
                {
                    if (textboxManageItemName.Text.ToUpper() == strEach.ToUpper())
                    {
                        textboxManageItemName.BackColor = Color.White;
                        string[] itemName = PubItemName;
                        foreach (string strName in itemName)
                        {
                            int index = Array.IndexOf(itemName, strName);
                            itemName[index] = itemName[index].ToUpper().ToString();
                        }
                        int intGetIndex = Array.IndexOf(itemName, textboxManageItemName.Text.ToUpper());
                        if (PubItemID[intGetIndex] != intItemID)
                        {
                            PubItemNameCorrect[intIndex] = false;
                            textboxManageItemName.BackColor = Color.Pink;
                        }
                    }
                }
            }

            if (PubItemNameCorrect[intIndex] == false || PubItemPriceCorrect[intIndex] == false || PubItemQuantityCorrect[intIndex] == false)
            {
                pictureboxManageItemSave.Visible = false;
            }
        }


        private void textboxManageItemPrice_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textboxManageItemPrice = obj_sender as TextBox;
            int intItemID = int.Parse(textboxManageItemPrice.Name.ToString().Substring(22, 8));

            if (textboxManageItemPrice.Text == "")
            {
                textboxManageItemPrice.Text = "0";
                textboxManageItemPrice.SelectionStart = textboxManageItemPrice.Text.Length - 1;
                textboxManageItemPrice.SelectionLength = 1;
            }
            itemNameCheck(intItemID);
            itemPriceCheck(intItemID);
            itemQuantityCheck(intItemID);
        }


        private void itemPriceCheck(int intItemID)
        {
            int intIndex = Array.IndexOf(PubItemID, intItemID);
            string pictureboxManageItemSaveName = "pictureboxManageItemSave" + intItemID.ToString();
            var pictureboxManageItemSave = formMain.Controls.Find(pictureboxManageItemSaveName, true).FirstOrDefault();

            string textboxManageItemPriceName = "textboxManageItemPrice" + intItemID.ToString();
            var textboxManageItemPrice = formMain.Controls.Find(textboxManageItemPriceName, true).FirstOrDefault();

            PubItemPriceCorrect[intIndex] = false;
            pictureboxManageItemSave.Visible = false;
            textboxManageItemPrice.BackColor = Color.Pink;

            float floatItemPrice;
            if (float.TryParse(textboxManageItemPrice.Text, out floatItemPrice))
            {
                PubItemPriceCorrect[intIndex] = true;
                textboxManageItemPrice.BackColor = Color.LightGreen;
                pictureboxManageItemSave.Visible = true;

                if (PubItemPrice[intIndex] == floatItemPrice)
                {
                    textboxManageItemPrice.BackColor = Color.White;
                }
            }

            if (PubItemNameCorrect[intIndex] == false || PubItemPriceCorrect[intIndex] == false || PubItemQuantityCorrect[intIndex] == false)
            {
                pictureboxManageItemSave.Visible = false;
            }
        }


        private void textboxManageItemQuantity_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textboxManageItemQuantity = obj_sender as TextBox;
            int intItemID = int.Parse(textboxManageItemQuantity.Name.ToString().Substring(25, 8));

            if (textboxManageItemQuantity.Text == "")
            {
                textboxManageItemQuantity.Text = "0";
                textboxManageItemQuantity.SelectionStart = textboxManageItemQuantity.Text.Length - 1;
                textboxManageItemQuantity.SelectionLength = 1;
            }
            itemNameCheck(intItemID);
            itemPriceCheck(intItemID);
            itemQuantityCheck(intItemID);
        }


        private void itemQuantityCheck(int intItemID)
        {
            int intIndex = Array.IndexOf(PubItemID, intItemID);
            string pictureboxManageItemSaveName = "pictureboxManageItemSave" + intItemID.ToString();
            var pictureboxManageItemSave = formMain.Controls.Find(pictureboxManageItemSaveName, true).FirstOrDefault();

            string textboxManageItemQuantityName = "textboxManageItemQuantity" + intItemID.ToString();
            var textboxManageItemQuantity = formMain.Controls.Find(textboxManageItemQuantityName, true).FirstOrDefault();

            PubItemQuantityCorrect[intIndex] = false;
            pictureboxManageItemSave.Visible = false;
            textboxManageItemQuantity.BackColor = Color.Pink;

            int intItemQuantity;
            if (int.TryParse(textboxManageItemQuantity.Text, out intItemQuantity))
            {
                PubItemQuantityCorrect[intIndex] = true;
                textboxManageItemQuantity.BackColor = Color.LightGreen;
                pictureboxManageItemSave.Visible = true;

                if (PubItemQuantity[intIndex] == intItemQuantity)
                {
                    textboxManageItemQuantity.BackColor = Color.White;
                }
            }

            if (PubItemNameCorrect[intIndex] == false || PubItemPriceCorrect[intIndex] == false || PubItemQuantityCorrect[intIndex] == false)
            {
                pictureboxManageItemSave.Visible = false;
            }
        }


        private void pictureBoxGST_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxGST = obj_sender as PictureBox;

            int intItemID = int.Parse(pictureBoxGST.Name.ToString().Substring(13, 8));
            int intIndex = Array.IndexOf(PubItemID, intItemID);
            string pictureboxManageItemSaveName = "pictureboxManageItemSave" + intItemID.ToString();
            var pictureboxManageItemSave = formMain.Controls.Find(pictureboxManageItemSaveName, true).FirstOrDefault();

            pictureboxManageItemSave.Visible = true;

            if (pictureBoxGST.Tag.ToString() == "0")
            {
                pictureBoxGST.BackgroundImage = Properties.Resources.img_gst_6;
                pictureBoxGST.Tag = "6";
            }
            else
            {
                pictureBoxGST.BackgroundImage = Properties.Resources.img_gst_0;
                pictureBoxGST.Tag = "0";
            }

            itemNameCheck(intItemID);
            itemPriceCheck(intItemID);
            itemQuantityCheck(intItemID);
            if (PubItemNameCorrect[intIndex] == false || PubItemPriceCorrect[intIndex] == false || PubItemQuantityCorrect[intIndex] == false)
            {
                pictureboxManageItemSave.Visible = false;
            }
        }
    }
}
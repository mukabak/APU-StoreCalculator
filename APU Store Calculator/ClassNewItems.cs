using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassNewItems : ClassDB
    {
        private Form formMain;
        private bool boolItemNameAccepted = false;
        private float floatItemPrice = 0;
        private int intItemQuantity = 0;

        public ClassNewItems(Form form)
        {
            formMain = form;

            int intWidth = (formMain.Size.Width - 800) / 2;
            int intHeight = (formMain.Size.Height - 600) / 2;

            // panelMainNewItems

            Panel panelMainNewItems = new Panel();
            panelMainNewItems.AutoScroll = true;
            panelMainNewItems.BackgroundImage = Properties.Resources.img_bg_2;
            panelMainNewItems.Dock = DockStyle.Fill;
            panelMainNewItems.Name = "panelMainNewItems";
            panelMainNewItems.TabIndex = 2;
            panelMainNewItems.Controls.Clear();

            // panelNewItemsContent

            Panel panelNewItemsContent = new Panel();
            panelNewItemsContent.BackColor = Color.Transparent;
            panelNewItemsContent.Location = new Point(intWidth + 265, intHeight + 70);
            panelNewItemsContent.Name = "panelPaymentHeader";
            panelNewItemsContent.AutoSize = false;
            panelNewItemsContent.Size = new Size(300, 300);
            panelNewItemsContent.TabIndex = 6;
            panelNewItemsContent.BorderStyle = BorderStyle.None;

            // labelAddNewItem

            Label labelAddNewItem = new Label();
            labelAddNewItem.AutoSize = false;
            labelAddNewItem.Size = new Size(270, 40);
            labelAddNewItem.TextAlign = ContentAlignment.MiddleCenter;
            labelAddNewItem.BackColor = Color.Transparent;
            labelAddNewItem.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddNewItem.Location = new Point(0, 5);
            labelAddNewItem.Name = "labelAddNewItem";
            labelAddNewItem.TabIndex = 0;
            labelAddNewItem.Text = "ADD NEW ITEM";

            // labelItemName

            Label labelItemName = new Label();
            labelItemName.AutoSize = false;
            labelItemName.Size = new Size(280, 20);
            labelItemName.TextAlign = ContentAlignment.MiddleLeft;
            labelItemName.BackColor = Color.Transparent;
            labelItemName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelItemName.Location = new Point(10, 45);
            labelItemName.Name = "labelItemName";
            labelItemName.TabIndex = 0;
            labelItemName.Text = "Item Name (Max: 20 Characters):";

            // textBoxItemName

            TextBox textBoxItemName = new TextBox();
            textBoxItemName.BackColor = Color.White;
            textBoxItemName.BorderStyle = BorderStyle.FixedSingle;
            textBoxItemName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxItemName.Location = new Point(5, 65);
            textBoxItemName.MaxLength = 20;
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(260, 27);
            textBoxItemName.TabIndex = 0;
            textBoxItemName.TextChanged += new EventHandler(textBoxItemName_TextChanged);

            // pictureBoxItemName

            PictureBox pictureBoxItemName = new PictureBox();
            pictureBoxItemName.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxItemName.Location = new Point(270, 65);
            pictureBoxItemName.Name = "pictureBoxItemName";
            pictureBoxItemName.Size = new Size(25, 25);
            pictureBoxItemName.TabIndex = 4;
            pictureBoxItemName.TabStop = false;
            pictureBoxItemName.Visible = false;

            // labelItemPrice

            Label labelItemPrice = new Label();
            labelItemPrice.AutoSize = false;
            labelItemPrice.Size = new Size(280, 20);
            labelItemPrice.TextAlign = ContentAlignment.MiddleLeft;
            labelItemPrice.BackColor = Color.Transparent;
            labelItemPrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelItemPrice.Location = new Point(10, 95);
            labelItemPrice.Name = "labelItemPrice";
            labelItemPrice.TabIndex = 0;
            labelItemPrice.Text = "Item Price (Default: RM 0.00):";

            // textBoxItemPrice

            TextBox textBoxItemPrice = new TextBox();
            textBoxItemPrice.BackColor = Color.White;
            textBoxItemPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxItemPrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxItemPrice.Location = new Point(5, 115);
            textBoxItemPrice.MaxLength = 20;
            textBoxItemPrice.Name = "textBoxItemPrice";
            textBoxItemPrice.Size = new Size(260, 27);
            textBoxItemPrice.TabIndex = 0;
            textBoxItemPrice.TextChanged += new EventHandler(textBoxItemPrice_TextChanged);

            // pictureBoxItemPrice

            PictureBox pictureBoxItemPrice = new PictureBox();
            pictureBoxItemPrice.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxItemPrice.Location = new Point(270, 115);
            pictureBoxItemPrice.Name = "pictureBoxItemPrice";
            pictureBoxItemPrice.Size = new Size(25, 25);
            pictureBoxItemPrice.TabIndex = 4;
            pictureBoxItemPrice.TabStop = false;
            pictureBoxItemPrice.Visible = false;

            // labelItemQuantity

            Label labelItemQuantity = new Label();
            labelItemQuantity.AutoSize = false;
            labelItemQuantity.Size = new Size(280, 20);
            labelItemQuantity.TextAlign = ContentAlignment.MiddleLeft;
            labelItemQuantity.BackColor = Color.Transparent;
            labelItemQuantity.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelItemQuantity.Location = new Point(10, 145);
            labelItemQuantity.Name = "labelItemQuantity";
            labelItemQuantity.TabIndex = 0;
            labelItemQuantity.Text = "Item Quantity (Default: 0):";

            // textBoxItemQuantity

            TextBox textBoxItemQuantity = new TextBox();
            textBoxItemQuantity.BackColor = Color.White;
            textBoxItemQuantity.BorderStyle = BorderStyle.FixedSingle;
            textBoxItemQuantity.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxItemQuantity.Location = new Point(5, 165);
            textBoxItemQuantity.MaxLength = 20;
            textBoxItemQuantity.Name = "textBoxItemQuantity";
            textBoxItemQuantity.Size = new Size(260, 27);
            textBoxItemQuantity.TabIndex = 0;
            textBoxItemQuantity.TextChanged += new EventHandler(textBoxItemQuantity_TextChanged);

            // pictureBoxItemQuantity

            PictureBox pictureBoxItemQuantity = new PictureBox();
            pictureBoxItemQuantity.BackgroundImage = Properties.Resources.img_incorrect;
            pictureBoxItemQuantity.Location = new Point(270, 165);
            pictureBoxItemQuantity.Name = "pictureBoxItemQuantity";
            pictureBoxItemQuantity.Size = new Size(25, 25);
            pictureBoxItemQuantity.TabIndex = 4;
            pictureBoxItemQuantity.TabStop = false;
            pictureBoxItemQuantity.Visible = false;

            // pictureBoxGST

            PictureBox pictureBoxGST = new PictureBox();
            pictureBoxGST.BackColor = Color.Transparent;
            pictureBoxGST.BackgroundImage = Properties.Resources.img_gst_0;
            pictureBoxGST.Location = new Point(105, 200);
            pictureBoxGST.Name = "pictureBoxGST";
            pictureBoxGST.Size = new Size(60, 30);
            pictureBoxGST.TabIndex = 4;
            pictureBoxGST.TabStop = false;
            pictureBoxGST.Cursor = Cursors.Hand;
            pictureBoxGST.Tag = "0";
            pictureBoxGST.Click += new EventHandler(pictureBoxGST_Click);

            // pictureBoxItemAdd

            PictureBox pictureBoxItemAdd = new PictureBox();
            pictureBoxItemAdd.BackgroundImage = Properties.Resources.img_add_1;
            pictureBoxItemAdd.Cursor = Cursors.Hand;
            pictureBoxItemAdd.Location = new Point(105, 235);
            pictureBoxItemAdd.Name = "pictureBoxItemAdd";
            pictureBoxItemAdd.Size = new Size(60, 30);
            pictureBoxItemAdd.TabIndex = 19;
            pictureBoxItemAdd.TabStop = false;
            pictureBoxItemAdd.Click += new EventHandler(pictureBoxItemAdd_Click);
            pictureBoxItemAdd.MouseEnter += new EventHandler(pictureBoxItemAdd_Enter);
            pictureBoxItemAdd.MouseLeave += new EventHandler(pictureBoxItemAdd_Leave);

            // labelItemStatus

            Label labelItemStatus = new Label();
            labelItemStatus.AutoSize = false;
            labelItemStatus.Size = new Size(270, 40);
            labelItemStatus.TextAlign = ContentAlignment.MiddleCenter;
            labelItemStatus.BackColor = Color.Transparent;
            labelItemStatus.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelItemStatus.Location = new Point(0, 270);
            labelItemStatus.Name = "labelItemStatus";
            labelItemStatus.Visible = false;
            labelItemStatus.ForeColor = Color.Green;
            labelItemStatus.TabIndex = 0;
            labelItemStatus.Text = "Successfully Added!";

            // panelNewItemsContent Update

            panelNewItemsContent.Controls.Add(labelAddNewItem);
            panelNewItemsContent.Controls.Add(labelItemName);
            panelNewItemsContent.Controls.Add(textBoxItemName);
            panelNewItemsContent.Controls.Add(pictureBoxItemName);
            panelNewItemsContent.Controls.Add(labelItemPrice);
            panelNewItemsContent.Controls.Add(textBoxItemPrice);
            panelNewItemsContent.Controls.Add(pictureBoxItemPrice);
            panelNewItemsContent.Controls.Add(labelItemQuantity);
            panelNewItemsContent.Controls.Add(textBoxItemQuantity);
            panelNewItemsContent.Controls.Add(pictureBoxItemQuantity);
            panelNewItemsContent.Controls.Add(pictureBoxGST);
            panelNewItemsContent.Controls.Add(pictureBoxItemAdd);
            panelNewItemsContent.Controls.Add(labelItemStatus);

            // panelMainNewItems Update

            panelMainNewItems.Controls.Add(panelNewItemsContent);
            panelMainNewItems.Focus();
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelMainNewItems.PointToScreen(new Point(0, 0));
            panelMainNewItems.Parent = panelContent;
            panelMainNewItems.Location = panelContent.PointToClient(pointPanel);
            panelMainNewItems.BringToFront();
        }


        private void textBoxItemName_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxItemName = obj_sender as TextBox;
            var pictureBoxItemName = formMain.Controls.Find("pictureBoxItemName", true).FirstOrDefault();

            boolItemNameAccepted = false;
            pictureBoxItemName.Visible = true;
            pictureBoxItemName.BackgroundImage = Properties.Resources.img_incorrect;

            if (textBoxItemName.Text.Length > 0)
            {
                boolItemNameAccepted = true;
                pictureBoxItemName.BackgroundImage = Properties.Resources.img_correct;

                foreach (string strItem in PubItemName)
                {
                    if (textBoxItemName.Text.ToUpper() == strItem.ToUpper())
                    {
                        boolItemNameAccepted = false;
                        pictureBoxItemName.BackgroundImage = Properties.Resources.img_incorrect;
                    }
                }
            }
        }


        private void textBoxItemPrice_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxItemPrice = obj_sender as TextBox;
            var pictureBoxItemPrice = formMain.Controls.Find("pictureBoxItemPrice", true).FirstOrDefault();

            pictureBoxItemPrice.Visible = true;
            pictureBoxItemPrice.BackgroundImage = Properties.Resources.img_incorrect;

            if (textBoxItemPrice.Text == "")
            {
                textBoxItemPrice.Text = "0";
                textBoxItemPrice.SelectionStart = textBoxItemPrice.Text.Length - 1;
                textBoxItemPrice.SelectionLength = 1;
            }

            if (float.TryParse(textBoxItemPrice.Text, out floatItemPrice))
            {
                pictureBoxItemPrice.BackgroundImage = Properties.Resources.img_correct;
            }
        }


        private void textBoxItemQuantity_TextChanged(object obj_sender, EventArgs e)
        {
            TextBox textBoxItemQuantity = obj_sender as TextBox;

            var pictureBoxItemQuantity = formMain.Controls.Find("pictureBoxItemQuantity", true).FirstOrDefault();

            pictureBoxItemQuantity.Visible = true;
            pictureBoxItemQuantity.BackgroundImage = Properties.Resources.img_incorrect;

            if (textBoxItemQuantity.Text == "")
            {
                textBoxItemQuantity.Text = "0";
                textBoxItemQuantity.SelectionStart = textBoxItemQuantity.Text.Length - 1;
                textBoxItemQuantity.SelectionLength = 1;
            }

            if (int.TryParse(textBoxItemQuantity.Text, out intItemQuantity))
            {
                pictureBoxItemQuantity.BackgroundImage = Properties.Resources.img_correct;
            }
        }


        private void pictureBoxItemAdd_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxItemAdd = obj_sender as PictureBox;

            var textBoxItemName = formMain.Controls.Find("textBoxItemName", true).FirstOrDefault();
            var pictureBoxItemName = formMain.Controls.Find("pictureBoxItemName", true).FirstOrDefault();

            var textBoxItemPrice = formMain.Controls.Find("textBoxItemPrice", true).FirstOrDefault();
            var pictureBoxItemPrice = formMain.Controls.Find("pictureBoxItemPrice", true).FirstOrDefault();

            var textBoxItemQuantity = formMain.Controls.Find("textBoxItemQuantity", true).FirstOrDefault();
            var pictureBoxItemQuantity = formMain.Controls.Find("pictureBoxItemQuantity", true).FirstOrDefault();

            var pictureBoxGST = formMain.Controls.Find("pictureBoxGST", true).FirstOrDefault();
            var labelItemStatus = formMain.Controls.Find("labelItemStatus", true).FirstOrDefault();

            labelItemStatus.Visible = false;

            if ((boolItemNameAccepted == true) && (textBoxItemName.Text.Length != 0))
            {
                float floatRadioGST = 0;
                if (pictureBoxGST.Tag.ToString() == "6")
                {
                    floatRadioGST = 6;
                }
                decimal decimalFloatItemPrice = Math.Round((decimal)(floatItemPrice), 2);

                InsertTableItem(textBoxItemName.Text, decimalFloatItemPrice, intItemQuantity, floatRadioGST);

                if (PubBoolTableUpdated == true)
                {
                    labelItemStatus.Visible = true;
                    textBoxItemName.Text = "";
                    textBoxItemPrice.Text = "";
                    textBoxItemQuantity.Text = "";
                    pictureBoxItemName.Visible = false;
                    pictureBoxItemPrice.Visible = false;
                    pictureBoxItemQuantity.Visible = false;
                }
            }
            else
            {
                pictureBoxItemName.Visible = true;
                pictureBoxItemName.BackgroundImage = Properties.Resources.img_incorrect;
            }
        }


        private void pictureBoxItemAdd_Enter(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxItemAdd = obj_sender as PictureBox;
            pictureBoxItemAdd.BackgroundImage = Properties.Resources.img_add_2;
        }


        private void pictureBoxItemAdd_Leave(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxItemAdd = obj_sender as PictureBox;
            pictureBoxItemAdd.BackgroundImage = Properties.Resources.img_add_1;
        }


        private void pictureBoxGST_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureBoxGST = obj_sender as PictureBox;

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
        }
    }
}
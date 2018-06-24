using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassItems : ClassDB
    {
        private Form formMain;
        private float floatTotal = 0;
        private int intArrayIndex = 0;
        private int[] intOrderedItemID = new int[0];
        private string[] stringOrderedItemName = new string[0];
        private int[] intOrderedItemQuantity = new int[0];
        private float[] floatOrderedItemPrice = new float[0];
        private float[] floatOrderedItemGST = new float[0];

        private void CallClassPayment()
        {
            ClassPayment CallClassPayment = new ClassPayment(formMain, intOrderedItemID, stringOrderedItemName, intOrderedItemQuantity, floatOrderedItemPrice, floatOrderedItemGST);
        }


        public ClassItems(Form form)
        {
            VoidClearInvoiceDetails();
            formMain = form;
            int intWidth = (formMain.Size.Width - 800) / 2;

            // labelMainTotal Update

            var labelMainTotal = formMain.Controls.Find("labelMainTotal", true).FirstOrDefault();
            labelMainTotal.Text = "RM 0.00";

            // panelMainItems

            Panel panelMainItems = new Panel();
            panelMainItems.AutoScroll = true;
            panelMainItems.BackgroundImage = Properties.Resources.img_bg_2;
            panelMainItems.Dock = DockStyle.Fill;
            panelMainItems.Location = new Point(40, 97);
            panelMainItems.Name = "panelMainItems";
            panelMainItems.TabIndex = 2;
            panelMainItems.Controls.Clear();
            panelMainItems.Paint += new PaintEventHandler(panelMainItems_Paint);

            // panelItemsHeader

            Panel panelItemsHeader = new Panel();
            panelItemsHeader.BackgroundImage = Properties.Resources.img_bg_2;
            panelItemsHeader.Dock = DockStyle.Top;
            panelItemsHeader.Name = "panelItemsHeader";
            panelItemsHeader.Size = new Size(800, 25);
            panelItemsHeader.TabIndex = 6;

            // labelItemIndexHeader

            Label labelItemIndexHeader = new Label();
            labelItemIndexHeader.AutoSize = true;
            labelItemIndexHeader.BackColor = Color.Transparent;
            labelItemIndexHeader.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelItemIndexHeader.Location = new Point(intWidth + 25, 5);
            labelItemIndexHeader.Name = "labelItemIndexHeader";
            labelItemIndexHeader.Size = new Size(40, 13);
            labelItemIndexHeader.TabIndex = 0;
            labelItemIndexHeader.Text = "No";

            // labelItemNameHeader

            Label labelItemNameHeader = new Label();
            labelItemNameHeader.AutoSize = true;
            labelItemNameHeader.BackColor = Color.Transparent;
            labelItemNameHeader.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelItemNameHeader.Location = new Point(intWidth + 60, 5);
            labelItemNameHeader.Name = "labelItemNameHeader";
            labelItemNameHeader.Size = new Size(40, 13);
            labelItemNameHeader.TabIndex = 2;
            labelItemNameHeader.Text = "Name";

            // labelItemPriceHeader

            Label labelItemPriceHeader = new Label();
            labelItemPriceHeader.AutoSize = true;
            labelItemPriceHeader.BackColor = Color.Transparent;
            labelItemPriceHeader.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelItemPriceHeader.Location = new Point(intWidth + 250, 5);
            labelItemPriceHeader.Name = "labelItemPriceHeader";
            labelItemPriceHeader.Size = new Size(35, 13);
            labelItemPriceHeader.TabIndex = 1;
            labelItemPriceHeader.Text = "Price";

            // labelItemQuantityHeader

            Label labelItemQuantityHeader = new Label();
            labelItemQuantityHeader.AutoSize = true;
            labelItemQuantityHeader.BackColor = Color.Transparent;
            labelItemQuantityHeader.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelItemQuantityHeader.Location = new Point(intWidth + 370, 5);
            labelItemQuantityHeader.Name = "labelItemQuantityHeader";
            labelItemQuantityHeader.Size = new Size(55, 13);
            labelItemQuantityHeader.TabIndex = 3;
            labelItemQuantityHeader.Text = "Quantity";

            // labelItemGSTHeader

            Label labelItemGSTHeader = new Label();
            labelItemGSTHeader.AutoSize = true;
            labelItemGSTHeader.BackColor = Color.Transparent;
            labelItemGSTHeader.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelItemGSTHeader.Location = new Point(intWidth + 480, 5);
            labelItemGSTHeader.Name = "labelItemGSTHeader";
            labelItemGSTHeader.Size = new Size(31, 13);
            labelItemGSTHeader.TabIndex = 5;
            labelItemGSTHeader.Text = "GST";

            // labelItemOrderHeader

            Label labelItemOrderHeader = new Label();
            labelItemOrderHeader.AutoSize = true;
            labelItemOrderHeader.BackColor = Color.Transparent;
            labelItemOrderHeader.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelItemOrderHeader.Location = new Point(intWidth + 557, 5);
            labelItemOrderHeader.Name = "labelItemOrderHeader";
            labelItemOrderHeader.Size = new Size(63, 13);
            labelItemOrderHeader.TabIndex = 6;
            labelItemOrderHeader.Text = "Order -/+";

            // pictureboxPay

            PictureBox pictureboxPay = new PictureBox();
            pictureboxPay.Name = "pictureboxPay";
            pictureboxPay.Cursor = Cursors.Hand;
            pictureboxPay.BackColor = Color.Transparent;
            pictureboxPay.BackgroundImage = Properties.Resources.img_pay_1;
            pictureboxPay.Visible = false;
            pictureboxPay.BackgroundImageLayout = ImageLayout.Stretch;
            pictureboxPay.Size = new Size(68, 25);
            pictureboxPay.Location = new Point(intWidth + 700, 0);
            pictureboxPay.Click += new EventHandler(pictureboxPay_Click);
            pictureboxPay.MouseEnter += new EventHandler(pictureboxPay_MouseEnter);
            pictureboxPay.MouseLeave += new EventHandler(pictureboxPay_MouseLeave);
            pictureboxPay.MouseDown += new MouseEventHandler(pictureboxPay_MouseDown);
            pictureboxPay.MouseMove += new MouseEventHandler(pictureboxPay_MouseMove);

            // Dynamically Create Objects

            int i = 0;
            while (i < PubItemCounter)
            {

                // panelItemContent

                Panel panelItemContent = new Panel();
                panelItemContent.BackgroundImage = Properties.Resources.img_bg_2;
                panelItemContent.Dock = DockStyle.Top;
                panelItemContent.Location = new Point(0, 0);
                panelItemContent.Name = "panelItemContent" + PubItemID[i].ToString();
                panelItemContent.Size = new Size(798, 35);
                panelItemContent.TabIndex = 6;

                // labelIndex

                Label labelIndex = new Label();
                labelIndex.Name = "labelIndex" + PubItemID[i].ToString();
                labelIndex.Text = (PubItemCounter - i).ToString();
                labelIndex.BackColor = Color.Transparent;
                labelIndex.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelIndex.AutoSize = true;
                labelIndex.Location = new Point(intWidth + 25, 7);

                // labelName

                Label labelName = new Label();
                labelName.Name = "labelName" + PubItemID[i].ToString();
                labelName.Text = PubItemName[i].ToString();
                labelName.BackColor = Color.Transparent;
                labelName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelName.AutoSize = true;
                labelName.Location = new Point(intWidth + 60, 7);

                // labelPriceUnit

                Label labelPriceUnit = new Label();
                labelPriceUnit.Name = "labelPriceUnit" + PubItemID[i].ToString();
                labelPriceUnit.Text = "RM";
                labelPriceUnit.BackColor = Color.Transparent;
                labelPriceUnit.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelPriceUnit.AutoSize = true;
                labelPriceUnit.Padding = new Padding(0, 0, 0, 0);
                labelPriceUnit.Location = new Point(intWidth + 250, 7);

                // labelPrice

                Label labelPrice = new Label();
                labelPrice.Name = "labelPrice" + PubItemID[i].ToString();
                labelPrice.Text = PubItemPrice[i].ToString();
                labelPrice.BackColor = Color.Transparent;
                labelPrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelPrice.AutoSize = true;
                labelPrice.Location = new Point(intWidth + 280, 7);

                // labelQuantity

                Label labelQuantity = new Label();
                labelQuantity.Name = "labelQuantity" + PubItemID[i].ToString();
                labelQuantity.Text = PubItemQuantity[i].ToString();
                labelQuantity.BackColor = Color.Transparent;
                labelQuantity.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelQuantity.AutoSize = true;
                labelQuantity.Location = new Point(intWidth + 370, 7);

                // labelGST

                Label labelGST = new Label();
                labelGST.Name = "labelGST" + PubItemID[i].ToString();
                labelGST.Text = PubItemTax[i].ToString();
                labelGST.BackColor = Color.Transparent;
                labelGST.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelGST.AutoSize = true;
                labelGST.Location = new Point(intWidth + 480, 7);

                // labelGSTUnit

                Label labelGSTUnit = new Label();
                labelGSTUnit.Name = "labelGSTUnit" + PubItemID[i].ToString();
                labelGSTUnit.Text = "%";
                labelGSTUnit.BackColor = Color.Transparent;
                labelGSTUnit.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelGSTUnit.AutoSize = true;
                labelGSTUnit.Location = new Point(intWidth + 500, 7);

                //pictureboxMinus

                PictureBox pictureboxMinus = new PictureBox();
                pictureboxMinus.Name = PubItemID[i].ToString();
                pictureboxMinus.Cursor = Cursors.Hand;
                pictureboxMinus.BackColor = Color.Transparent;
                pictureboxMinus.BackgroundImage = Properties.Resources.img_minus_1;
                pictureboxMinus.BackgroundImageLayout = ImageLayout.Stretch;
                pictureboxMinus.Size = new Size(20, 20);
                pictureboxMinus.Location = new Point(intWidth + 560, 7);
                pictureboxMinus.Click += new EventHandler(pictureboxMinus_Click);
                pictureboxMinus.MouseEnter += new EventHandler(pictureboxMinus_MouseEnter);
                pictureboxMinus.MouseLeave += new EventHandler(pictureboxMinus_MouseLeave);
                pictureboxMinus.MouseDown += new MouseEventHandler(pictureboxMinus_MouseDown);
                pictureboxMinus.MouseMove += new MouseEventHandler(pictureboxMinus_MouseMove);

                // labelItemCount

                Label labelItemCount = new Label();
                labelItemCount.Name = "labelItemCount" + PubItemID[i].ToString();
                labelItemCount.Text = "0";
                labelItemCount.BackColor = Color.Transparent;
                labelItemCount.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelItemCount.AutoSize = true;
                labelItemCount.Location = new Point(intWidth + 590, 7);

                // pictureboxPlus

                PictureBox pictureboxPlus = new PictureBox();
                pictureboxPlus.Name = PubItemID[i].ToString();
                pictureboxPlus.Cursor = Cursors.Hand;
                pictureboxPlus.BackColor = Color.Transparent;
                pictureboxPlus.BackgroundImage = Properties.Resources.img_plus_1;
                pictureboxPlus.BackgroundImageLayout = ImageLayout.Stretch;
                pictureboxPlus.Size = new Size(20, 20);
                pictureboxPlus.Location = new Point(intWidth + 620, 7);
                pictureboxPlus.Click += new EventHandler(pictureboxPlus_Click);
                pictureboxPlus.MouseEnter += new EventHandler(pictureboxPlus_MouseEnter);
                pictureboxPlus.MouseLeave += new EventHandler(pictureboxPlus_MouseLeave);
                pictureboxPlus.MouseDown += new MouseEventHandler(pictureboxPlus_MouseDown);
                pictureboxPlus.MouseMove += new MouseEventHandler(pictureboxPlus_MouseMove);

                // labelTotalPrice

                Label labelTotalPrice = new Label();
                labelTotalPrice.Name = "labelTotalPrice" + PubItemID[i].ToString();
                labelTotalPrice.Text = "RM 0";
                labelTotalPrice.BackColor = Color.Transparent;
                labelTotalPrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                labelTotalPrice.AutoSize = true;
                labelTotalPrice.Location = new Point(intWidth + 670, 7);
                panelMainItems.Controls.Add(labelTotalPrice);

                // pictureboxLine

                PictureBox pictureboxLine = new PictureBox();
                pictureboxLine.Name = "pictureboxLine" + PubItemID[i].ToString();
                pictureboxLine.Cursor = Cursors.Hand;
                pictureboxLine.BackColor = Color.Transparent;
                pictureboxLine.BackColor = Color.Gray;
                pictureboxLine.Size = new Size(760, 1);
                pictureboxLine.Location = new Point(intWidth + 20, 34);

                // panelItemsHeader Update

                panelItemsHeader.Controls.Add(labelItemIndexHeader);
                panelItemsHeader.Controls.Add(labelItemNameHeader);
                panelItemsHeader.Controls.Add(labelItemPriceHeader);
                panelItemsHeader.Controls.Add(labelItemQuantityHeader);
                panelItemsHeader.Controls.Add(labelItemGSTHeader);
                panelItemsHeader.Controls.Add(labelItemOrderHeader);
                panelItemsHeader.Controls.Add(pictureboxPay);

                // panelItemContent Update

                panelItemContent.Controls.Add(labelIndex);
                panelItemContent.Controls.Add(labelName);
                panelItemContent.Controls.Add(labelPriceUnit);
                panelItemContent.Controls.Add(labelPrice);
                panelItemContent.Controls.Add(labelQuantity);
                panelItemContent.Controls.Add(labelGST);
                panelItemContent.Controls.Add(labelGSTUnit);
                panelItemContent.Controls.Add(pictureboxMinus);
                panelItemContent.Controls.Add(labelItemCount);
                panelItemContent.Controls.Add(pictureboxPlus);
                panelItemContent.Controls.Add(labelTotalPrice);
                panelItemContent.Controls.Add(pictureboxLine);

                // panelMainItems Update

                panelMainItems.Controls.Add(panelItemContent);
                panelMainItems.Controls.Add(panelItemsHeader);
                panelMainItems.Focus();

                i++;
            }
            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelMainItems.PointToScreen(new Point(0, 0));
            panelMainItems.Parent = panelContent;
            panelMainItems.Location = panelContent.PointToClient(pointPanel);
            panelMainItems.BringToFront();
        }


        private void pictureboxMinus_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxMinus = obj_sender as PictureBox;
            pictureboxMinus.BackgroundImage = Properties.Resources.img_minus_1;
        }


        private void pictureboxMinus_MouseDown(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxMinus = obj_sender as PictureBox;
            pictureboxMinus.BackgroundImage = Properties.Resources.img_minus_1;
            string labelCounterName = "labelItemCount" + pictureboxMinus.Name;
            var labelCounter = formMain.Controls.Find(labelCounterName, true).FirstOrDefault();
            int intCounter = int.Parse(labelCounter.Text);

            string labelItemPriceName = "labelPrice" + pictureboxMinus.Name;
            var labelItemPrice = formMain.Controls.Find(labelItemPriceName, true).FirstOrDefault();
            float floatItemPrice = float.Parse(labelItemPrice.Text);

            string labelItemTotalPriceName = "labelTotalPrice" + pictureboxMinus.Name;
            var labelTotalPrice = formMain.Controls.Find(labelItemTotalPriceName, true).FirstOrDefault();

            string labelQuantityName = "labelQuantity" + pictureboxMinus.Name;
            var labelQuantity = formMain.Controls.Find(labelQuantityName, true).FirstOrDefault();
            int intQuantity = int.Parse(labelQuantity.Text);

            string labelGSTName = "labelGST" + pictureboxMinus.Name;
            var labelGST = formMain.Controls.Find(labelGSTName, true).FirstOrDefault();
            float floatGST = float.Parse(labelGST.Text);

            var labelMainTotal = formMain.Controls.Find("labelMainTotal", true).FirstOrDefault();

            labelCounter.ForeColor = Color.Black;
            labelTotalPrice.ForeColor = Color.Black;
            labelQuantity.ForeColor = Color.Black;

            if (intCounter > 0)
            {
                intCounter--;
                floatTotal -= floatItemPrice * (((100 + floatGST)) / 100);
                intQuantity++;

                int intClickedItemID = int.Parse(pictureboxMinus.Name);
                if (intOrderedItemID.Contains(intClickedItemID))
                {
                    int intPosition = Array.IndexOf(intOrderedItemID, intClickedItemID);
                    intOrderedItemQuantity[intPosition] = intCounter;
                }
            }

            if (intCounter >= 1)
            {
                labelCounter.ForeColor = Color.Red;
                labelTotalPrice.ForeColor = Color.Red;
                labelQuantity.ForeColor = Color.Red;
            }

            decimal decimalFloatTotal = Math.Round((decimal)floatTotal, 2);
            decimal decimalFloatTotalPrice = Math.Round((decimal)(floatItemPrice * intCounter * (((100 + floatGST)) / 100)), 2);
            labelCounter.Text = intCounter.ToString();
            labelMainTotal.Text = "RM " + decimalFloatTotal.ToString();
            labelTotalPrice.Text = "RM " + decimalFloatTotalPrice;
            labelQuantity.Text = intQuantity.ToString();

            string pictureboxPayName = "pictureboxPay";
            var pictureboxPay = formMain.Controls.Find(pictureboxPayName, true).FirstOrDefault();

            if (floatTotal < 0.01)
            {
                pictureboxPay.Visible = false;
            }
        }


        private void pictureboxMinus_MouseEnter(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxMinus = obj_sender as PictureBox;
            pictureboxMinus.BackgroundImage = Properties.Resources.img_minus_2;
        }


        private void pictureboxMinus_MouseLeave(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxMinus = obj_sender as PictureBox;
            pictureboxMinus.BackgroundImage = Properties.Resources.img_minus_1;
        }


        private void pictureboxMinus_MouseMove(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxMinus = obj_sender as PictureBox;
            pictureboxMinus.BackgroundImage = Properties.Resources.img_minus_2;
        }


        private void pictureboxPlus_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPlus = obj_sender as PictureBox;
            pictureboxPlus.BackgroundImage = Properties.Resources.img_plus_1;
        }


        private void pictureboxPlus_MouseDown(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPlus = obj_sender as PictureBox;
            pictureboxPlus.BackgroundImage = Properties.Resources.img_plus_1;
            string labelCounterName = "labelItemCount" + pictureboxPlus.Name;
            var labelCounter = formMain.Controls.Find(labelCounterName, true).FirstOrDefault();
            int intCounter = int.Parse(labelCounter.Text);

            string labelNameName = "labelName" + pictureboxPlus.Name;
            var labelName = formMain.Controls.Find(labelNameName, true).FirstOrDefault();

            string labelItemPriceName = "labelPrice" + pictureboxPlus.Name;
            var labelItemPrice = formMain.Controls.Find(labelItemPriceName, true).FirstOrDefault();
            float floatItemPrice = float.Parse(labelItemPrice.Text);

            string labelItemTotalPriceName = "labelTotalPrice" + pictureboxPlus.Name;
            var labelTotalPrice = formMain.Controls.Find(labelItemTotalPriceName, true).FirstOrDefault();

            string labelQuantityName = "labelQuantity" + pictureboxPlus.Name;
            var labelQuantity = formMain.Controls.Find(labelQuantityName, true).FirstOrDefault();
            int intQuantity = int.Parse(labelQuantity.Text);

            string labelGSTName = "labelGST" + pictureboxPlus.Name;
            var labelGST = formMain.Controls.Find(labelGSTName, true).FirstOrDefault();
            float floatGST = float.Parse(labelGST.Text);

            var labelMainTotal = formMain.Controls.Find("labelMainTotal", true).FirstOrDefault();

            if ((intCounter < 99) && (intQuantity > 0))
            {
                intCounter++;
                floatTotal += floatItemPrice * (((100 + floatGST)) / 100); ;
                intQuantity--;

                int intClickedItemID = int.Parse(pictureboxPlus.Name);
                if (intOrderedItemID.Contains(intClickedItemID))
                {
                    int intPosition = Array.IndexOf(intOrderedItemID, intClickedItemID);
                    intOrderedItemID[intPosition] = intClickedItemID;
                    stringOrderedItemName[intPosition] = labelName.Text;
                    intOrderedItemQuantity[intPosition] = intCounter;
                    floatOrderedItemPrice[intPosition] = floatItemPrice;
                    floatOrderedItemGST[intPosition] = floatGST;
                }
                else
                {
                    Array.Resize(ref intOrderedItemID, intArrayIndex + 1);
                    Array.Resize(ref stringOrderedItemName, intArrayIndex + 1);
                    Array.Resize(ref intOrderedItemQuantity, intArrayIndex + 1);
                    Array.Resize(ref floatOrderedItemPrice, intArrayIndex + 1);
                    Array.Resize(ref floatOrderedItemGST, intArrayIndex + 1);

                    intOrderedItemID[intArrayIndex] = intClickedItemID;
                    stringOrderedItemName[intArrayIndex] = labelName.Text;
                    intOrderedItemQuantity[intArrayIndex] = intCounter;
                    floatOrderedItemPrice[intArrayIndex] = floatItemPrice;
                    floatOrderedItemGST[intArrayIndex] = floatGST;

                    intArrayIndex++;
                }
            }

            if (intCounter >= 1)
            {
                labelCounter.ForeColor = Color.Red;
                labelTotalPrice.ForeColor = Color.Red;
                labelQuantity.ForeColor = Color.Red;
            }
            decimal decimalFloatTotal = Math.Round((decimal)floatTotal, 2);
            decimal decimalFloatTotalPrice = Math.Round((decimal)(floatItemPrice * intCounter * (((100 + floatGST)) / 100)), 2);
            labelCounter.Text = intCounter.ToString();
            labelMainTotal.Text = "RM " + decimalFloatTotal.ToString();
            labelTotalPrice.Text = "RM " + decimalFloatTotalPrice;
            labelQuantity.Text = intQuantity.ToString();

            string pictureboxPayName = "pictureboxPay";
            var pictureboxPay = formMain.Controls.Find(pictureboxPayName, true).FirstOrDefault();

            if (floatTotal > 0)
            {
                pictureboxPay.Visible = true;
            }
        }


        private void pictureboxPlus_MouseEnter(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPlus = obj_sender as PictureBox;
            pictureboxPlus.BackgroundImage = Properties.Resources.img_plus_2;
        }


        private void pictureboxPlus_MouseLeave(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPlus = obj_sender as PictureBox;
            pictureboxPlus.BackgroundImage = Properties.Resources.img_plus_1;
        }


        private void pictureboxPlus_MouseMove(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPlus = obj_sender as PictureBox;
            pictureboxPlus.BackgroundImage = Properties.Resources.img_plus_2;
        }


        private void pictureboxPay_Click(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPay = obj_sender as PictureBox;
            var labelMainTotal = formMain.Controls.Find("labelMainTotal", true).FirstOrDefault();
            decimal decimalFloatTotal = Math.Round((decimal)floatTotal, 2);
            InsertTableInvoive(decimalFloatTotal);
            string stringOldInvoiceID = ClassLogin.MyProperty[20].ToString();
            if (stringOldInvoiceID== ClassLogin.MyProperty[20].ToString())
            {
                labelMainTotal.Text = "RM 0.00";
                labelMainTotal.Visible = false;
                CallClassPayment();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }


        private void pictureboxPay_MouseDown(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPay = obj_sender as PictureBox;
            pictureboxPay.BackgroundImage = Properties.Resources.img_pay_1;
        }


        private void pictureboxPay_MouseEnter(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPay = obj_sender as PictureBox;
            pictureboxPay.BackgroundImage = Properties.Resources.img_pay_2;
        }


        private void pictureboxPay_MouseLeave(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPay = obj_sender as PictureBox;
            pictureboxPay.BackgroundImage = Properties.Resources.img_pay_1;
        }


        private void pictureboxPay_MouseMove(object obj_sender, EventArgs e)
        {
            PictureBox pictureboxPay = obj_sender as PictureBox;
            pictureboxPay.BackgroundImage = Properties.Resources.img_pay_2;
        }


        private void panelMainItems_Paint(object obj_sender, PaintEventArgs e)
        {
            Panel panelMainItems = obj_sender as Panel;
            panelMainItems.Focus();
        }
    }
}

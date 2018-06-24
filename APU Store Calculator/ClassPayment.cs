using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace APU_Store_Calculator
{
    class ClassPayment : ClassDB
    {
        private Form formMain;
        private int[] intOrderedItemID = new int[0];
        private string[] stringOrderedItemName = new string[0];
        private int[] intOrderedItemQuantity = new int[0];
        private float[] floatOrderedItemPrice = new float[0];
        private float[] floatOrderedItemGST = new float[0];

        public ClassPayment(Form form, int[] intItemID, string[] stringItemName, int[] intItemQuantity, float[] floatItemPrice, float[] floatItemGST)
        {
            formMain = form;
            intOrderedItemID = intItemID;
            stringOrderedItemName = stringItemName;
            intOrderedItemQuantity = intItemQuantity;
            floatOrderedItemPrice = floatItemPrice;
            floatOrderedItemGST = floatItemGST;
            Payment();
        }


        private void Payment()
        {
            int intWidth = (formMain.Size.Width - 800) / 2;

            // panelMainPayment

            Panel panelMainPayment = new Panel();
            panelMainPayment.AutoScroll = true;
            panelMainPayment.BackgroundImage = Properties.Resources.img_bg_2;
            panelMainPayment.Dock = DockStyle.Fill;
            panelMainPayment.Name = "panelMainPayment";
            panelMainPayment.TabIndex = 2;
            panelMainPayment.Focus();
            panelMainPayment.Controls.Clear();
            panelMainPayment.Paint += new PaintEventHandler(panelMainPayment_Paint);

            // panelPaymentHeader

            Panel panelPaymentContent = new Panel();
            panelPaymentContent.BackColor = Color.White;
            panelPaymentContent.Location = new Point(intWidth + 250, 50);
            panelPaymentContent.Name = "panelPaymentHeader";
            panelPaymentContent.AutoSize = true;
            panelPaymentContent.MinimumSize = new Size(300, 200);
            panelPaymentContent.MaximumSize = new Size(300, 10000);
            panelPaymentContent.TabIndex = 6;
            panelPaymentContent.BorderStyle = BorderStyle.FixedSingle;

            // labelPaymentHeaderCompanyName

            Label labelPaymentHeaderCompanyName = new Label();
            labelPaymentHeaderCompanyName.AutoSize = false;
            labelPaymentHeaderCompanyName.Size = new Size(300, 50);
            labelPaymentHeaderCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            labelPaymentHeaderCompanyName.BackColor = Color.Transparent;
            labelPaymentHeaderCompanyName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderCompanyName.Location = new Point(0, 0);
            labelPaymentHeaderCompanyName.Name = "labelPaymentHeaderCompanyName";
            labelPaymentHeaderCompanyName.TabIndex = 0;
            labelPaymentHeaderCompanyName.Text = ClassLogin.MyProperty[11].ToString().ToUpper();

            // labelPaymentHeaderCompanyAddress

            Label labelPaymentHeaderCompanyAddress = new Label();
            labelPaymentHeaderCompanyAddress.AutoSize = true;
            labelPaymentHeaderCompanyAddress.Location = new Point(10, 50);
            labelPaymentHeaderCompanyAddress.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderCompanyAddress.BackColor = Color.Transparent;
            labelPaymentHeaderCompanyAddress.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderCompanyAddress.Name = "labelPaymentHeaderCompanyAddress";
            labelPaymentHeaderCompanyAddress.TabIndex = 2;
            labelPaymentHeaderCompanyAddress.Text = "ADDRESS:";

            // labelPaymentHeaderCompanyAddressDetail

            Label labelPaymentHeaderCompanyAddressDetail = new Label();
            labelPaymentHeaderCompanyAddressDetail.AutoSize = true;
            labelPaymentHeaderCompanyAddressDetail.Location = new Point(100, 50);
            labelPaymentHeaderCompanyAddressDetail.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderCompanyAddressDetail.BackColor = Color.Transparent;
            labelPaymentHeaderCompanyAddressDetail.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderCompanyAddressDetail.Name = "labelPaymentHeaderCompanyAddressDetail";
            labelPaymentHeaderCompanyAddressDetail.TabIndex = 2;
            labelPaymentHeaderCompanyAddressDetail.Text = ClassLogin.MyProperty[12].ToString().ToUpper();

            // labelPaymentHeaderCompanyTelephone

            Label labelPaymentHeaderCompanyTelephone = new Label();
            labelPaymentHeaderCompanyTelephone.AutoSize = true;
            labelPaymentHeaderCompanyTelephone.Location = new Point(10, 70);
            labelPaymentHeaderCompanyTelephone.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderCompanyTelephone.BackColor = Color.Transparent;
            labelPaymentHeaderCompanyTelephone.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderCompanyTelephone.Name = "labelPaymentHeaderCompanyTelephone";
            labelPaymentHeaderCompanyTelephone.TabIndex = 2;
            labelPaymentHeaderCompanyTelephone.Text = "TELEPHONE:";

            // labelPaymentHeaderCompanyTelephoneDetail

            Label labelPaymentHeaderCompanyTelephoneDetail = new Label();
            labelPaymentHeaderCompanyTelephoneDetail.AutoSize = true;
            labelPaymentHeaderCompanyTelephoneDetail.Location = new Point(100, 70);
            labelPaymentHeaderCompanyTelephoneDetail.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderCompanyTelephoneDetail.BackColor = Color.Transparent;
            labelPaymentHeaderCompanyTelephoneDetail.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderCompanyTelephoneDetail.Name = "labelPaymentHeaderCompanyTelephoneDetail";
            labelPaymentHeaderCompanyTelephoneDetail.TabIndex = 2;
            labelPaymentHeaderCompanyTelephoneDetail.Text = ClassLogin.MyProperty[13].ToString().ToUpper();

            // labelPaymentHeaderCashier

            Label labelPaymentHeaderCashier = new Label();
            labelPaymentHeaderCashier.AutoSize = true;
            labelPaymentHeaderCashier.Location = new Point(10, 90);
            labelPaymentHeaderCashier.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderCashier.BackColor = Color.Transparent;
            labelPaymentHeaderCashier.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderCashier.Name = "labelPaymentHeaderCashier";
            labelPaymentHeaderCashier.TabIndex = 2;
            labelPaymentHeaderCashier.Text = "CASHIER:";

            // labelPaymentHeaderCashierDetail

            Label labelPaymentHeaderCashierDetail = new Label();
            labelPaymentHeaderCashierDetail.AutoSize = true;
            labelPaymentHeaderCashierDetail.Location = new Point(100, 90);
            labelPaymentHeaderCashierDetail.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderCashierDetail.BackColor = Color.Transparent;
            labelPaymentHeaderCashierDetail.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderCashierDetail.Name = "labelPaymentHeaderCashierDetail";
            labelPaymentHeaderCashierDetail.TabIndex = 2;
            labelPaymentHeaderCashierDetail.Text = ClassLogin.MyProperty[1].ToString().ToUpper();

            // labelPaymentHeaderDateTime

            Label labelPaymentHeaderDateTime = new Label();
            labelPaymentHeaderDateTime.AutoSize = true;
            labelPaymentHeaderDateTime.Location = new Point(10, 110);
            labelPaymentHeaderDateTime.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderDateTime.BackColor = Color.Transparent;
            labelPaymentHeaderDateTime.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderDateTime.Name = "labelPaymentHeaderDateTime";
            labelPaymentHeaderDateTime.TabIndex = 2;
            labelPaymentHeaderDateTime.Text = "DATE TIME:";

            // labelPaymentHeaderDateTimeDetail

            Label labelPaymentHeaderDateTimeDetail = new Label();
            labelPaymentHeaderDateTimeDetail.AutoSize = true;
            labelPaymentHeaderDateTimeDetail.Location = new Point(100, 110);
            labelPaymentHeaderDateTimeDetail.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderDateTimeDetail.BackColor = Color.Transparent;
            labelPaymentHeaderDateTimeDetail.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderDateTimeDetail.Name = "labelPaymentHeaderDateTimeDetail";
            labelPaymentHeaderDateTimeDetail.TabIndex = 2;
            labelPaymentHeaderDateTimeDetail.Text = ClassLogin.MyProperty[21].ToString();

            // labelPaymentHeaderInvoiceID

            Label labelPaymentHeaderInvoiceID = new Label();
            labelPaymentHeaderInvoiceID.AutoSize = false;
            labelPaymentHeaderInvoiceID.Size = new Size(300, 20);
            labelPaymentHeaderInvoiceID.Location = new Point(0, 135);
            labelPaymentHeaderInvoiceID.TextAlign = ContentAlignment.MiddleCenter;
            labelPaymentHeaderInvoiceID.BackColor = Color.Transparent;
            labelPaymentHeaderInvoiceID.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderInvoiceID.Name = "labelPaymentHeaderInvoiceID";
            labelPaymentHeaderInvoiceID.TabIndex = 2;
            labelPaymentHeaderInvoiceID.Text = "NO: " + ClassLogin.MyProperty[20].ToString();

            // labelPaymentHeaderInvoiceHeader

            Label labelPaymentHeaderInvoiceHeader = new Label();
            labelPaymentHeaderInvoiceHeader.AutoSize = false;
            labelPaymentHeaderInvoiceHeader.Size = new Size(290, 20);
            labelPaymentHeaderInvoiceHeader.Location = new Point(10, 160);
            labelPaymentHeaderInvoiceHeader.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentHeaderInvoiceHeader.BackColor = Color.Transparent;
            labelPaymentHeaderInvoiceHeader.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentHeaderInvoiceHeader.Name = "labelPaymentHeaderInvoiceHeader";
            labelPaymentHeaderInvoiceHeader.TabIndex = 2;
            labelPaymentHeaderInvoiceHeader.Text = "|   PRICE   |  UNIT  |   TOTAL  PRICE   |  GST  |";

            // pictureboxPaymentHeaderInvoiceLine1

            PictureBox pictureboxPaymentHeaderInvoiceLine1 = new PictureBox();
            pictureboxPaymentHeaderInvoiceLine1.Name = "pictureboxPaymentHeaderInvoiceLine1";
            pictureboxPaymentHeaderInvoiceLine1.BackColor = Color.Gray;
            pictureboxPaymentHeaderInvoiceLine1.Size = new Size(280, 1);
            pictureboxPaymentHeaderInvoiceLine1.Location = new Point(10, 185);

            // Create Ordered Items Dynamically

            int intCounter = 0;
            int intItemCounter = 0;
            float floatTotalPriceCounter = 0;
            float floatTotalGSTCounter = 0;

            foreach (var intID in intOrderedItemID)
            {
                int intIndex = Array.IndexOf(intOrderedItemID, intID);
                if (intOrderedItemQuantity[intIndex] > 0)
                {
                    intItemCounter += intOrderedItemQuantity[intIndex];
                    floatTotalPriceCounter += intOrderedItemQuantity[intIndex] * floatOrderedItemPrice[intIndex];
                    floatTotalGSTCounter += intOrderedItemQuantity[intIndex] * floatOrderedItemPrice[intIndex] * floatOrderedItemGST[intIndex] / 100;

                    InsertTableSold(intOrderedItemID[intIndex], floatOrderedItemPrice[intIndex], intOrderedItemQuantity[intIndex], floatOrderedItemGST[intIndex]);

                    // labelPaymentCounter

                    Label labelPaymentCounter = new Label();
                    labelPaymentCounter.AutoSize = true;
                    labelPaymentCounter.Location = new Point(10, 190 + (intCounter * 50));
                    labelPaymentCounter.TextAlign = ContentAlignment.MiddleLeft;
                    labelPaymentCounter.BackColor = Color.Transparent;
                    labelPaymentCounter.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    labelPaymentCounter.Name = "labelPaymentCounter" + intOrderedItemID[intIndex].ToString();
                    labelPaymentCounter.TabIndex = 2;
                    labelPaymentCounter.Text = (intCounter + 1).ToString() + ")";

                    // labelPaymentID

                    Label labelPaymentID = new Label();
                    labelPaymentID.AutoSize = true;
                    labelPaymentID.Location = new Point(30, 190 + (intCounter * 50));
                    labelPaymentID.TextAlign = ContentAlignment.MiddleLeft;
                    labelPaymentID.BackColor = Color.Transparent;
                    labelPaymentID.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    labelPaymentID.Name = "labelPaymentID" + intOrderedItemID[intIndex].ToString();
                    labelPaymentID.TabIndex = 2;
                    labelPaymentID.Text = intOrderedItemID[intIndex].ToString();

                    // labelPaymentName

                    Label labelPaymentName = new Label();
                    labelPaymentName.AutoSize = true;
                    labelPaymentName.Location = new Point(100, 190 + (intCounter * 50));
                    labelPaymentName.TextAlign = ContentAlignment.MiddleLeft;
                    labelPaymentName.BackColor = Color.Transparent;
                    labelPaymentName.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    labelPaymentName.Name = "labelPaymentName" + intOrderedItemID[intIndex].ToString();
                    labelPaymentName.TabIndex = 2;
                    labelPaymentName.Text = stringOrderedItemName[intIndex].ToString();

                    // labelPaymentPrice

                    Label labelPaymentPrice = new Label();
                    labelPaymentPrice.AutoSize = true;
                    labelPaymentPrice.Location = new Point(20, 210 + (intCounter * 50));
                    labelPaymentPrice.TextAlign = ContentAlignment.MiddleLeft;
                    labelPaymentPrice.BackColor = Color.Transparent;
                    labelPaymentPrice.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    labelPaymentPrice.Name = "labelPaymentPrice" + intOrderedItemID[intIndex].ToString();
                    labelPaymentPrice.TabIndex = 2;
                    labelPaymentPrice.Text = "RM " + floatOrderedItemPrice[intIndex].ToString();

                    // labelPaymentPrice

                    Label labelPaymentUnit = new Label();
                    labelPaymentUnit.AutoSize = true;
                    labelPaymentUnit.Location = new Point(95, 210 + (intCounter * 50));
                    labelPaymentUnit.TextAlign = ContentAlignment.MiddleLeft;
                    labelPaymentUnit.BackColor = Color.Transparent;
                    labelPaymentUnit.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    labelPaymentUnit.Name = "labelPaymentUnit" + intOrderedItemID[intIndex].ToString();
                    labelPaymentUnit.TabIndex = 2;
                    labelPaymentUnit.Text = intOrderedItemQuantity[intIndex].ToString();

                    // labelPaymentTotalPrice

                    Label labelPaymentItemTotalPrice = new Label();
                    labelPaymentItemTotalPrice.AutoSize = true;
                    labelPaymentItemTotalPrice.Location = new Point(155, 210 + (intCounter * 50));
                    labelPaymentItemTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
                    labelPaymentItemTotalPrice.BackColor = Color.Transparent;
                    labelPaymentItemTotalPrice.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    labelPaymentItemTotalPrice.Name = "labelPaymentItemTotalPrice" + intOrderedItemID[intIndex].ToString();
                    labelPaymentItemTotalPrice.TabIndex = 2;
                    labelPaymentItemTotalPrice.Text = "RM " + (intOrderedItemQuantity[intIndex] * floatOrderedItemPrice[intIndex]).ToString();

                    // labelPaymentGST

                    Label labelPaymentGST = new Label();
                    labelPaymentGST.AutoSize = true;
                    labelPaymentGST.Location = new Point(240, 210 + (intCounter * 50));
                    labelPaymentGST.TextAlign = ContentAlignment.MiddleLeft;
                    labelPaymentGST.BackColor = Color.Transparent;
                    labelPaymentGST.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    labelPaymentGST.Name = "labelPaymentTotalPrice" + intOrderedItemID[intIndex].ToString();
                    labelPaymentGST.TabIndex = 2;
                    labelPaymentGST.Text = "+ " + floatOrderedItemGST[intIndex].ToString() + " %";

                    // panelPaymentContent Update

                    panelPaymentContent.Controls.Add(labelPaymentCounter);
                    panelPaymentContent.Controls.Add(labelPaymentID);
                    panelPaymentContent.Controls.Add(labelPaymentName);
                    panelPaymentContent.Controls.Add(labelPaymentPrice);
                    panelPaymentContent.Controls.Add(labelPaymentUnit);
                    panelPaymentContent.Controls.Add(labelPaymentItemTotalPrice);
                    panelPaymentContent.Controls.Add(labelPaymentGST);
                    intCounter++;
                }
            }

            // pictureboxPaymentHeaderInvoiceLine2

            PictureBox pictureboxPaymentHeaderInvoiceLine2 = new PictureBox();
            pictureboxPaymentHeaderInvoiceLine2.Name = "pictureboxPaymentHeaderInvoiceLine2";
            pictureboxPaymentHeaderInvoiceLine2.BackColor = Color.Gray;
            pictureboxPaymentHeaderInvoiceLine2.Size = new Size(280, 1);
            pictureboxPaymentHeaderInvoiceLine2.Location = new Point(10, 235 + ((intCounter - 1) * 50));

            // labelPaymentItems

            Label labelPaymentItems = new Label();
            labelPaymentItems.AutoSize = true;
            labelPaymentItems.Location = new Point(10, 240 + ((intCounter - 1) * 50));
            labelPaymentItems.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentItems.BackColor = Color.Transparent;
            labelPaymentItems.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentItems.Name = "labelPaymentItems";
            labelPaymentItems.TabIndex = 2;
            labelPaymentItems.Text = "TOTAL ITEM(S):";

            // labelPaymentItemsCounter

            Label labelPaymentItemsCounter = new Label();
            labelPaymentItemsCounter.AutoSize = true;
            labelPaymentItemsCounter.Location = new Point(150, 240 + ((intCounter - 1) * 50));
            labelPaymentItemsCounter.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentItemsCounter.BackColor = Color.Transparent;
            labelPaymentItemsCounter.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentItemsCounter.Name = "labelPaymentItemsCounter";
            labelPaymentItemsCounter.TabIndex = 2;
            labelPaymentItemsCounter.Text = intItemCounter.ToString();

            // labelPaymentTotalPrice

            Label labelPaymentTotalPrice = new Label();
            labelPaymentTotalPrice.AutoSize = true;
            labelPaymentTotalPrice.Location = new Point(10, 260 + ((intCounter - 1) * 50));
            labelPaymentTotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentTotalPrice.BackColor = Color.Transparent;
            labelPaymentTotalPrice.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentTotalPrice.Name = "labelPaymentTotalPrice";
            labelPaymentTotalPrice.TabIndex = 2;
            labelPaymentTotalPrice.Text = "TOTAL PRICE:";

            // labelPaymentTotalPriceCounter

            Label labelPaymentTotalPriceCounter = new Label();
            labelPaymentTotalPriceCounter.AutoSize = true;
            labelPaymentTotalPriceCounter.Location = new Point(150, 260 + ((intCounter - 1) * 50));
            labelPaymentTotalPriceCounter.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentTotalPriceCounter.BackColor = Color.Transparent;
            labelPaymentTotalPriceCounter.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentTotalPriceCounter.Name = "labelPaymentTotalPriceCounter";
            labelPaymentTotalPriceCounter.TabIndex = 2;
            labelPaymentTotalPriceCounter.Text = "RM " + floatTotalPriceCounter.ToString();

            // labelPaymentGSTHeader

            Label labelPaymentGSTHeader = new Label();
            labelPaymentGSTHeader.AutoSize = true;
            labelPaymentGSTHeader.Location = new Point(10, 280 + ((intCounter - 1) * 50));
            labelPaymentGSTHeader.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentGSTHeader.BackColor = Color.Transparent;
            labelPaymentGSTHeader.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentGSTHeader.Name = "labelPaymentGSTHeader";
            labelPaymentGSTHeader.TabIndex = 2;
            labelPaymentGSTHeader.Text = "TOTAL GST:";

            // labelPaymentGSTCounter

            Label labelPaymentGSTCounter = new Label();
            labelPaymentGSTCounter.AutoSize = true;
            labelPaymentGSTCounter.Location = new Point(150, 280 + ((intCounter - 1) * 50));
            labelPaymentGSTCounter.TextAlign = ContentAlignment.MiddleLeft;
            labelPaymentGSTCounter.BackColor = Color.Transparent;
            labelPaymentGSTCounter.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentGSTCounter.Name = "labelPaymentGSTCounter";
            labelPaymentGSTCounter.TabIndex = 2;
            labelPaymentGSTCounter.Text = "RM " + Math.Round((decimal)(floatTotalGSTCounter), 2).ToString();

            // pictureboxPaymentHeaderInvoiceLine3

            PictureBox pictureboxPaymentHeaderInvoiceLine3 = new PictureBox();
            pictureboxPaymentHeaderInvoiceLine3.Name = "pictureboxPaymentHeaderInvoiceLine3";
            pictureboxPaymentHeaderInvoiceLine3.BackColor = Color.Gray;
            pictureboxPaymentHeaderInvoiceLine3.Size = new Size(280, 1);
            pictureboxPaymentHeaderInvoiceLine3.Location = new Point(10, 305 + ((intCounter - 1) * 50));

            // labelPaymentTotalPricesWithGST

            Label labelPaymentTotalPricesWithGST = new Label();
            labelPaymentTotalPricesWithGST.AutoSize = false;
            labelPaymentTotalPricesWithGST.Size = new Size(300, 30);
            labelPaymentTotalPricesWithGST.Location = new Point(0, 310 + ((intCounter - 1) * 50));
            labelPaymentTotalPricesWithGST.TextAlign = ContentAlignment.MiddleCenter;
            labelPaymentTotalPricesWithGST.BackColor = Color.Transparent;
            labelPaymentTotalPricesWithGST.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentTotalPricesWithGST.Name = "labelPaymentTotalPricesWithGST";
            labelPaymentTotalPricesWithGST.TabIndex = 2;
            labelPaymentTotalPricesWithGST.Text = "PAID: RM " + Math.Round((decimal)((floatTotalGSTCounter + floatTotalPriceCounter)), 2).ToString();

            // labelPaymentTHANKYOU

            Label labelPaymentTHANKYOU = new Label();
            labelPaymentTHANKYOU.AutoSize = false;
            labelPaymentTHANKYOU.Size = new Size(300, 40);
            labelPaymentTHANKYOU.Location = new Point(0, 340 + ((intCounter - 1) * 50));
            labelPaymentTHANKYOU.TextAlign = ContentAlignment.MiddleCenter;
            labelPaymentTHANKYOU.BackColor = Color.Transparent;
            labelPaymentTHANKYOU.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaymentTHANKYOU.Name = "labelPaymentTHANKYOU";
            labelPaymentTHANKYOU.TabIndex = 2;
            labelPaymentTHANKYOU.Text = "THANK YOU!";

            // panelPaymentContent Update

            panelPaymentContent.Controls.Add(labelPaymentHeaderCompanyName);
            panelPaymentContent.Controls.Add(labelPaymentHeaderCompanyAddress);
            panelPaymentContent.Controls.Add(labelPaymentHeaderCompanyAddressDetail);
            panelPaymentContent.Controls.Add(labelPaymentHeaderCompanyTelephone);
            panelPaymentContent.Controls.Add(labelPaymentHeaderCompanyTelephoneDetail);
            panelPaymentContent.Controls.Add(labelPaymentHeaderCashier);
            panelPaymentContent.Controls.Add(labelPaymentHeaderCashierDetail);
            panelPaymentContent.Controls.Add(labelPaymentHeaderDateTime);
            panelPaymentContent.Controls.Add(labelPaymentHeaderDateTimeDetail);
            panelPaymentContent.Controls.Add(labelPaymentHeaderInvoiceID);
            panelPaymentContent.Controls.Add(labelPaymentHeaderInvoiceHeader);
            panelPaymentContent.Controls.Add(pictureboxPaymentHeaderInvoiceLine1);
            panelPaymentContent.Controls.Add(pictureboxPaymentHeaderInvoiceLine2);
            panelPaymentContent.Controls.Add(labelPaymentItems);
            panelPaymentContent.Controls.Add(labelPaymentItemsCounter);
            panelPaymentContent.Controls.Add(labelPaymentTotalPrice);
            panelPaymentContent.Controls.Add(labelPaymentTotalPriceCounter);
            panelPaymentContent.Controls.Add(labelPaymentGSTHeader);
            panelPaymentContent.Controls.Add(labelPaymentGSTCounter);
            panelPaymentContent.Controls.Add(pictureboxPaymentHeaderInvoiceLine3);
            panelPaymentContent.Controls.Add(labelPaymentTotalPricesWithGST);
            panelPaymentContent.Controls.Add(labelPaymentTHANKYOU);

            // labelSpace1

            Label labelSpace1 = new Label();
            labelSpace1.AutoSize = false;
            labelSpace1.Size = new Size(300, 40);
            labelSpace1.Location = new Point(0, 490 + ((intCounter - 1) * 50));
            labelSpace1.TextAlign = ContentAlignment.MiddleCenter;
            labelSpace1.BackColor = Color.Transparent;
            labelSpace1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSpace1.Name = "labelSpace1";
            labelSpace1.TabIndex = 2;
            labelSpace1.Text = "";

            // panelMainManageItems Update

            panelMainPayment.Controls.Add(panelPaymentContent);
            panelMainPayment.Controls.Add(labelSpace1);
            panelMainPayment.Focus();

            var panelContent = formMain.Controls.Find("panelContent", true).FirstOrDefault();
            panelContent.Controls.Clear();
            Point pointPanel = panelMainPayment.PointToScreen(new Point(0, 0));
            panelMainPayment.Parent = panelContent;
            panelMainPayment.Location = panelContent.PointToClient(pointPanel);
            panelMainPayment.BringToFront();

            // Update Item Quantity

            foreach (var intIDUpdate in intOrderedItemID)
            {
                int intIndexUodate = Array.IndexOf(intOrderedItemID, intIDUpdate);
                if (intOrderedItemQuantity[intIndexUodate] > 0)
                {
                    UpdateItemQuantity(intOrderedItemID[intIndexUodate], intOrderedItemQuantity[intIndexUodate]);
                }
            }
            decimal decimalUserRevenue = Math.Round((decimal)((floatTotalGSTCounter + floatTotalPriceCounter)), 2);
            UpdateTableUser(decimalUserRevenue);
        }


        private void panelMainPayment_Paint(object obj_sender, PaintEventArgs e)
        {
            Panel panelMainPayment = obj_sender as Panel;
            panelMainPayment.Focus();
        }
    }
}
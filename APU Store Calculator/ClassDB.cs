using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APU_Store_Calculator
{
    class ClassDB
    {
        private Form formMain;
        private Panel panelContent;
        private MySqlConnection sqlConnectionDB = new MySqlConnection();
        private string AccessCode = "e5bd5f6c64d66092cfcf65ecb456a69d";
        private static bool prvBoolTableUpdated = false;
        private static int prvItemCounter = 0;
        private static int[] prvItemID = new int[0];
        private static string[] prvItemName = new string[0];
        private static float[] prvItemPrice = new float[0];
        private static int[] prvItemQuantity = new int[0];
        private static float[] prvItemTax = new float[0];
        private static string[] prvItemDate = new string[0];
        private static bool[] prvItemNameCorrect = new bool[0];
        private static bool[] prvItemPriceCorrect = new bool[0];
        private static bool[] prvItemQuantityCorrect = new bool[0];
        private static int prvUserCounter = 0;
        private static int[] prvUserID = new int[0];
        private static string[] prvUserLogin = new string[0];
        private static string[] prvUserFirstName = new string[0];
        private static string[] prvUserLastName = new string[0];
        private static string[] prvUserType = new string[0];
        private static float[] prvUserRevenue = new float[0];
        private static string[] prvUserDate = new string[0];


        public static bool PubBoolTableUpdated
        {
            get { return prvBoolTableUpdated; }
            set { prvBoolTableUpdated = value; }
        }
        public static int PubItemCounter
        {
            get { return prvItemCounter; }
            set { prvItemCounter = value; }
        }
        public static int[] PubItemID
        {
            get{ return prvItemID; }
            set { prvItemID = value; }
        }
        public static string[] PubItemName
        {
            get { return prvItemName; }
            set { prvItemName = value; }
        }
        public static float[] PubItemPrice
        {
            get { return prvItemPrice; }
            set { prvItemPrice = value; }
        }
        public static int[] PubItemQuantity
        {
            get { return prvItemQuantity; }
            set { prvItemQuantity = value; }
        }
        public static float[] PubItemTax
        {
            get { return prvItemTax; }
            set { prvItemTax = value; }
        }
        public static string[] PubItemDate
        {
            get { return prvItemDate; }
            set { prvItemDate = value; }
        }
        public static bool[] PubItemNameCorrect
        {
            get { return prvItemNameCorrect; }
            set { prvItemNameCorrect = value; }
        }
        public static bool[] PubItemPriceCorrect
        {
            get { return prvItemPriceCorrect; }
            set { prvItemPriceCorrect = value; }
        }
        public static bool[] PubItemQuantityCorrect
        {
            get { return prvItemQuantityCorrect; }
            set { prvItemQuantityCorrect = value; }
        }
        public static int PubUserCounter
        {
            get { return prvUserCounter; }
            set { prvUserCounter = value; }
        }
        public static int[] PubUserID
        {
            get { return prvUserID; }
            set { prvUserID = value; }
        }
        public static string[] PubUserLogin
        {
            get { return prvUserLogin; }
            set { prvUserLogin = value; }
        }
        public static string[] PubUserFirstName
        {
            get { return prvUserFirstName; }
            set { prvUserFirstName = value; }
        }
        public static string[] PubUserLastName
        {
            get { return prvUserLastName; }
            set { prvUserLastName = value; }
        }
        public static string[] PubUserType
        {
            get { return prvUserType; }
            set { prvUserType = value; }
        }
        public static float[] PubUserRevenue
        {
            get { return prvUserRevenue; }
            set { prvUserRevenue = value; }
        }
        public static string[] PubUserDate
        {
            get { return prvUserDate; }
            set { prvUserDate = value; }
        }


        private void MySqlLoader()
        {
            ClassLogin.MyProperty[14] = Properties.Settings.Default["strDatabaseName"].ToString();
            ClassLogin.MyProperty[15] = Properties.Settings.Default["strDatabaseServer"].ToString();
            ClassLogin.MyProperty[16] = Properties.Settings.Default["strDatabasePort"].ToString();
            ClassLogin.MyProperty[17] = Properties.Settings.Default["strDatabaseUsername"].ToString();
            ClassLogin.MyProperty[18] = Properties.Settings.Default["strDatabasePassword"].ToString();
            sqlConnectionDB.ConnectionString = "datasource=" + ClassLogin.MyProperty[15].ToString() + ";port=" + ClassLogin.MyProperty[16].ToString() + ";username=" + ClassLogin.MyProperty[17].ToString() + ";password=" + ClassLogin.MyProperty[18].ToString() + ";";
        }


        public ClassDB()
        {
        }


        public ClassDB(Form form, Panel panel)
        {
            formMain = form;
            panelContent = panel;
            CheckConnection();
        }


        public void voidLogin(string strUserLogin)
        {
            MySqlLoader();
                VoidClearUserDetails();
                try
            {
                sqlConnectionDB.Open();
                string strQuery = "SELECT * FROM " + ClassLogin.MyProperty[14].ToString() + ".table_user WHERE user_login='" + strUserLogin + "'";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                        ClassLogin.MyProperty[0] = sqlReader["user_id"].ToString();
                        ClassLogin.MyProperty[1] = sqlReader["user_login"].ToString();
                        ClassLogin.MyProperty[2] = sqlReader["user_first_name"].ToString();
                        ClassLogin.MyProperty[3] = sqlReader["user_last_name"].ToString();
                        ClassLogin.MyProperty[4] = sqlReader["user_type"].ToString();
                        ClassLogin.MyProperty[5] = sqlReader["user_revenue"].ToString();
                        ClassLogin.MyProperty[6] = sqlReader["user_registered_date"].ToString();
                        ClassLogin.MyProperty[7] = sqlReader["user_password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
        }


        public void GetTableSetting()
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "SELECT * FROM " + ClassLogin.MyProperty[14].ToString() + ".table_setting WHERE setting_access_code='" + AccessCode.ToString() + "'";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    ClassLogin.MyProperty[11] = sqlReader["setting_company_name"].ToString();
                    ClassLogin.MyProperty[12] = sqlReader["setting_company_address"].ToString();
                    ClassLogin.MyProperty[13] = sqlReader["setting_company_telephone"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            MySqlLoader();
        }


        public void GetTableItem()
        {
            MySqlLoader();
            prvItemCounter = 0;
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "SELECT * FROM " + ClassLogin.MyProperty[14].ToString() + ".table_item";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    prvItemCounter++;
                    Array.Resize(ref prvItemID, prvItemCounter);
                    Array.Resize(ref prvItemName, prvItemCounter);
                    Array.Resize(ref prvItemPrice, prvItemCounter);
                    Array.Resize(ref prvItemQuantity, prvItemCounter);
                    Array.Resize(ref prvItemTax, prvItemCounter);
                    Array.Resize(ref prvItemDate, prvItemCounter);
                    Array.Resize(ref prvItemNameCorrect, prvItemCounter);
                    Array.Resize(ref prvItemPriceCorrect, prvItemCounter);
                    Array.Resize(ref prvItemQuantityCorrect, prvItemCounter);

                    prvItemID[prvItemCounter - 1] = (int)sqlReader["item_id"];
                    prvItemName[prvItemCounter - 1] = sqlReader["item_name"].ToString();
                    prvItemPrice[prvItemCounter - 1] = (float)sqlReader["item_price"];
                    prvItemQuantity[prvItemCounter - 1] = (int)sqlReader["item_quantity"];
                    prvItemTax[prvItemCounter - 1] = (float)sqlReader["item_tax"];
                    prvItemDate[prvItemCounter - 1] = sqlReader["item_registered_date"].ToString();
                    prvItemNameCorrect[prvItemCounter - 1] = true;
                    prvItemPriceCorrect[prvItemCounter - 1] = true;
                    prvItemQuantityCorrect[prvItemCounter - 1] = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
        }


        public void GetTableUser()
        {
            MySqlLoader();
            prvUserCounter = 0;
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "SELECT * FROM " + ClassLogin.MyProperty[14].ToString() + ".table_user";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    prvUserCounter++;
                    Array.Resize(ref prvUserID, prvUserCounter);
                    Array.Resize(ref prvUserLogin, prvUserCounter);
                    Array.Resize(ref prvUserFirstName, prvUserCounter);
                    Array.Resize(ref prvUserLastName, prvUserCounter);
                    Array.Resize(ref prvUserType, prvUserCounter);
                    Array.Resize(ref prvUserRevenue, prvUserCounter);
                    Array.Resize(ref prvUserDate, prvUserCounter);

                    prvUserID[prvUserCounter - 1] = (int)sqlReader["user_id"];
                    prvUserLogin[prvUserCounter - 1] = sqlReader["user_login"].ToString();
                    prvUserFirstName[prvUserCounter - 1] = sqlReader["user_first_name"].ToString();
                    prvUserLastName[prvUserCounter - 1] = sqlReader["user_last_name"].ToString();
                    prvUserType[prvUserCounter - 1] = sqlReader["user_type"].ToString();
                    prvUserRevenue[prvUserCounter - 1] = (float)sqlReader["user_revenue"];
                    prvUserDate[prvUserCounter - 1] = sqlReader["user_registered_date"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            voidLogin(ClassLogin.MyProperty[1].ToString());
        }


        public void InsertTableInvoive(decimal deTotalPrice)
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                Random random = new Random();
                int invoice_id = random.Next(10000000, 99999999);
                string invoice_date = DateTime.Now.ToString();
                int intInvoiceUserID = int.Parse(ClassLogin.MyProperty[0].ToString());
                string strQuery = "INSERT INTO " + ClassLogin.MyProperty[14].ToString() + ".table_invoice(invoice_id, invoice_user_id, invoice_total_price, invoice_date) VALUES (" + invoice_id + ", " + intInvoiceUserID + ", " + deTotalPrice + ", '" + invoice_date + "')";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    ClassLogin.MyProperty[20] = invoice_id.ToString();
                    ClassLogin.MyProperty[21] = invoice_date.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
        }


        public void InsertTableSold(int order_id, float order_price, int order_quantity, float order_gst)
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                int sold_invoice_id = int.Parse(ClassLogin.MyProperty[20].ToString());
                string strQuery = "INSERT INTO " + ClassLogin.MyProperty[14].ToString() + ".table_sold(sold_id, sold_invoice_id, sold_item_id, sold_price, sold_quantity, sold_tax) VALUES (FLOOR(RAND() * 89999998) + 10000000, " + sold_invoice_id + ", " + order_id + ", " + order_price + ", " + order_quantity + ", " + order_gst + ")";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
        }


        public void UpdateItemQuantity(int order_id, int order_quantity)
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "UPDATE " + ClassLogin.MyProperty[14].ToString() + ".table_item SET item_quantity=item_quantity" + -order_quantity + " WHERE item_id=" + order_id + " ";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            GetTableItem();
        }


        public void CheckConnection()
        {
            MySqlLoader();
            bool boolAccessed = false;
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "SELECT * FROM " + ClassLogin.MyProperty[14].ToString() + ".table_user WHERE user_login='superuser'";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    boolAccessed = true;
                }
            }
            catch { }

            sqlConnectionDB.Close();
            if (boolAccessed==true)
            {
                CallClassLogin();
            }
            else
            {
                CallClassConnection();
                var labelStatusConnectionDB = formMain.Controls.Find("labelStatusConnection", true).FirstOrDefault();
                labelStatusConnectionDB.Visible = true;
            }
        }


        private void CallClassConnection()
        {
            ClassConnection CallClassConnection = new ClassConnection(formMain);
        }


        private void CallClassLogin()
        {
            panelContent.Controls.Clear();
            ClassLogin CallClassLogin = new ClassLogin(formMain);
        }


        public void VoidDefaultDataCreater(bool create)
        {
            MySqlLoader();
            int intPassword= 0;
            Random random = new Random();
            intPassword = random.Next(10000, 99999);
            try
            {
                if (create == true)
                {
                    sqlConnectionDB.Open();
                    string strQueryAddDefaultSetting = "INSERT INTO " + ClassLogin.MyProperty[14].ToString() + ".table_setting (setting_access_code, setting_company_name, setting_company_address, setting_company_telephone) SELECT * FROM (SELECT '" + AccessCode.ToString() + "', 'Company name here...', 'Company address here...', 'Tel here...') AS tmp WHERE NOT EXISTS (SELECT setting_access_code FROM " + ClassLogin.MyProperty[14].ToString() + ".table_setting WHERE setting_access_code='" + AccessCode.ToString() + "') LIMIT 1";
                    MySqlCommand sqlCommandAddDefaultSetting = new MySqlCommand(strQueryAddDefaultSetting, sqlConnectionDB);
                    if (sqlCommandAddDefaultSetting.ExecuteNonQuery() == 1)
                    {
                    }
                    sqlConnectionDB.Close();

                    sqlConnectionDB.Open();
                    string strQueryAddDefaultUser = "INSERT INTO " + ClassLogin.MyProperty[14].ToString() + ".table_user (user_id, user_login, user_password, user_type, user_first_name, user_last_name, user_revenue, user_registered_date) SELECT * FROM (SELECT FLOOR(RAND() * 89999998) + 10000000, 'superuser', '" + intPassword.ToString() + "', 'admin', 'Your password: " + intPassword.ToString() + "', 'Last name here...', 0, CURDATE()) AS tmp WHERE NOT EXISTS (SELECT user_login FROM " + ClassLogin.MyProperty[14].ToString() + ".table_user WHERE user_login='superuser') LIMIT 1";
                    MySqlCommand sqlCommandAddDefaultUser = new MySqlCommand(strQueryAddDefaultUser, sqlConnectionDB);
                    if (sqlCommandAddDefaultUser.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Welcome new user!\nDefault Username and Password created for you.\nUsername: superuser\nPassword:" + intPassword.ToString() + "");
                    }
                    sqlConnectionDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnectionDB.Close();
            }
            Application.Exit();
        }


        public void VoidClearUserDetails()
        {
            ClassLogin.MyProperty[0] = "";
            ClassLogin.MyProperty[1] = "";
            ClassLogin.MyProperty[2] = "";
            ClassLogin.MyProperty[3] = "";
            ClassLogin.MyProperty[4] = "";
            ClassLogin.MyProperty[5] = "";
            ClassLogin.MyProperty[6] = "";
            ClassLogin.MyProperty[7] = "";
            ClassLogin.MyProperty[8] = "";
            ClassLogin.MyProperty[9] = "";
        }


        public void VoidClearSettingDetails()
        {
            ClassLogin.MyProperty[10] = "";
            ClassLogin.MyProperty[11] = "";
            ClassLogin.MyProperty[12] = "";
            ClassLogin.MyProperty[13] = "";
            ClassLogin.MyProperty[14] = "";
            ClassLogin.MyProperty[15] = "";
            ClassLogin.MyProperty[16] = "";
            ClassLogin.MyProperty[17] = "";
            ClassLogin.MyProperty[18] = "";
            ClassLogin.MyProperty[19] = "";
        }


        public void VoidClearInvoiceDetails()
        {
            ClassLogin.MyProperty[20] = "";
            ClassLogin.MyProperty[21] = "";
            ClassLogin.MyProperty[22] = "";
            ClassLogin.MyProperty[23] = "";
            ClassLogin.MyProperty[24] = "";
            ClassLogin.MyProperty[25] = "";
            ClassLogin.MyProperty[26] = "";
            ClassLogin.MyProperty[27] = "";
            ClassLogin.MyProperty[28] = "";
            ClassLogin.MyProperty[29] = "";
        }


        public void VoidConnectToDB(bool create, string name, string server, string port, string username, string password, object status)
        {
            Label labelStatus = status as Label;

            MySqlConnection createConnection = new MySqlConnection();
            createConnection.ConnectionString = "datasource=" + server.ToString() + ";port=" + port.ToString() + ";username=" + username.ToString() + ";password=" + password.ToString() + ";";
            try
            {
                createConnection.Open();

                Properties.Settings.Default["strDatabaseName"] = name.ToString();
                Properties.Settings.Default["strDatabaseServer"] = server.ToString();
                Properties.Settings.Default["strDatabasePort"] = port.ToString();
                Properties.Settings.Default["strDatabaseUsername"] = username.ToString();
                Properties.Settings.Default["strDatabasePassword"] = password.ToString();
                Properties.Settings.Default.Save();

                labelStatus.Visible = true;
                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = "Successfully connected!";

                if (create == true)
                {
                    MySqlCommand sqlCreateDB = new MySqlCommand("CREATE DATABASE IF NOT EXISTS `" + name.ToString() + "`", createConnection);
                    MySqlCommand sqlCreateTableInvoice = new MySqlCommand("CREATE TABLE IF NOT EXISTS `" + name.ToString() + "`.`table_invoice` (`invoice_id` int(8) NOT NULL, `invoice_user_id` int(8) NOT NULL, `invoice_total_price` float NOT NULL, `invoice_date` varchar(20) NOT NULL, PRIMARY KEY(invoice_id)) ENGINE = InnoDB DEFAULT CHARSET = latin1;", createConnection);
                    MySqlCommand sqlCreateTableItem = new MySqlCommand("CREATE TABLE IF NOT EXISTS `" + name.ToString() + "`.`table_item` (`item_id` int(8) NOT NULL, `item_name` varchar(20) NOT NULL, `item_price` float NOT NULL, `item_quantity` int(10) NOT NULL, `item_tax` float NOT NULL, `item_registered_date` varchar(20) NOT NULL, PRIMARY KEY(item_id)) ENGINE = InnoDB DEFAULT CHARSET = latin1;", createConnection);
                    MySqlCommand sqlCreateTableSetting = new MySqlCommand("CREATE TABLE IF NOT EXISTS `" + name.ToString() + "`.`table_setting` (`setting_access_code` varchar(32) NOT NULL, `setting_company_name` varchar(20), `setting_company_address` varchar(25), `setting_company_telephone` varchar(11), PRIMARY KEY(setting_access_code), UNIQUE(setting_access_code)) ENGINE = InnoDB DEFAULT CHARSET = latin1;", createConnection);
                    MySqlCommand sqlCreateTableSold = new MySqlCommand("CREATE TABLE IF NOT EXISTS `" + name.ToString() + "`.`table_sold` (`sold_id` int(8) NOT NULL, `sold_invoice_id` int(8) NOT NULL, `sold_item_id` int(8) NOT NULL, `sold_price` float NOT NULL, `sold_quantity` int(10) NOT NULL, `sold_tax` float NOT NULL, PRIMARY KEY(sold_id)) ENGINE = InnoDB DEFAULT CHARSET = latin1;", createConnection);
                    MySqlCommand sqlCreateTableUser = new MySqlCommand("CREATE TABLE IF NOT EXISTS `" + name.ToString() + "`.`table_user` (`user_id` int(8) NOT NULL, `user_login` varchar(20) NOT NULL, `user_password` varchar(20) NOT NULL, `user_type` varchar(20) NOT NULL, `user_first_name` varchar(20) NOT NULL, `user_last_name` varchar(20) NOT NULL, `user_revenue` float NOT NULL, `user_registered_date` varchar(20) NOT NULL, PRIMARY KEY(user_id), UNIQUE(user_login)) ENGINE = InnoDB DEFAULT CHARSET = latin1;", createConnection);

                    sqlCreateDB.ExecuteNonQuery();
                    sqlCreateTableUser.ExecuteNonQuery();
                    sqlCreateTableInvoice.ExecuteNonQuery();
                    sqlCreateTableSetting.ExecuteNonQuery();
                    sqlCreateTableItem.ExecuteNonQuery();
                    sqlCreateTableSold.ExecuteNonQuery();

                    labelStatus.Text = "Database successfully created!";
                }
                createConnection.Close();
                VoidDefaultDataCreater(create);
            }
            catch
            {
                createConnection.Close();
                labelStatus.Visible = true;
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "There is no connection to this server!";
            }
        }


        public void UpdateTableItem(int id, string name, decimal price, float tax, int quantity)
        {
            PubBoolTableUpdated = false;
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "UPDATE " + ClassLogin.MyProperty[14].ToString() + ".table_item SET item_name='" + name + "', item_price=" + price + ", item_tax=" + tax + ", item_quantity=" + quantity + " WHERE item_id=" + id + "";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    PubBoolTableUpdated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            GetTableItem();
        }


        public void DeleteTableItem(int id)
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "DELETE FROM " + ClassLogin.MyProperty[14].ToString() + ".table_item WHERE item_id=" + id + "";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            GetTableItem();
        }


        public void UpdateCompanyDetails()
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "UPDATE " + ClassLogin.MyProperty[14].ToString() + ".table_setting SET setting_company_name='" + ClassLogin.MyProperty[11].ToString() + "',  setting_company_address='" + ClassLogin.MyProperty[12].ToString() + "',  setting_company_telephone='" + ClassLogin.MyProperty[13].ToString() + "' WHERE setting_access_code='" + AccessCode.ToString() + "' ";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
        }


        public void UpdateTableUser(decimal deRevenue)
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "UPDATE " + ClassLogin.MyProperty[14].ToString() + ".table_user SET user_login='" + ClassLogin.MyProperty[1].ToString() + "', user_password='" + ClassLogin.MyProperty[7].ToString() + "', user_first_name='" + ClassLogin.MyProperty[2].ToString() + "', user_last_name='" + ClassLogin.MyProperty[3].ToString() + "', user_revenue=user_revenue + " + deRevenue + " WHERE user_id = " + int.Parse(ClassLogin.MyProperty[0].ToString()) + "";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            GetTableUser();
        }


        public void InsertTableItem(string name, decimal price, int quantity, float tax)
        {
            PubBoolTableUpdated = false;
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "INSERT INTO " + ClassLogin.MyProperty[14].ToString() + ".table_item(item_id, item_name, item_price, item_quantity, item_tax, item_registered_date) VALUES (FLOOR(RAND() * 89999998) + 10000000, '" + name + "', " + price + ", " + quantity + ", " + tax + ", CURDATE())";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    PubBoolTableUpdated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            GetTableItem();
        }


        public void InsertTableUser(string login, string pass, string type, string fn, string ln)
        {
            PubBoolTableUpdated = false;
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "INSERT INTO " + ClassLogin.MyProperty[14].ToString() + ".table_user(user_id, user_login, user_password, user_type, user_first_name, user_last_name, user_revenue, user_registered_date) VALUES (FLOOR(RAND() * 89999998) + 10000000, '" + login + "', '" + pass + "', '" + type + "', '" + fn + "', '" + ln + "', 0, CURDATE())";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    PubBoolTableUpdated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            GetTableUser();
        }


        public void DeleteTableUser(int id)
        {
            MySqlLoader();
            try
            {
                sqlConnectionDB.Open();
                string strQuery = "DELETE FROM " + ClassLogin.MyProperty[14].ToString() + ".table_user WHERE user_id=" + id + "";
                MySqlCommand sqlCommand = new MySqlCommand(strQuery, sqlConnectionDB);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnectionDB.Close();
            GetTableUser();
        }
    }
}

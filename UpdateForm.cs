using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Catering_Service_Online
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void buttonSubmitUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection UpdateCon = new SqlConnection();

            UpdateCon.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";

            string CustomerEmail = textBoxEmailUpdate.Text;
            string CustomerName = textBoxNameUpdate.Text;
            string CustomerPass = textBoxPassUpdate.Text;
            string CustomerPhone = textBoxPhoneUpdate.Text;
            string CustomerAddress = richTextBoxAddressUpdate.Text;

            if (CustomerEmail == "")
            {
                MessageBox.Show("Invalid Insertion");
            }
            else
            { 
            string sql = "UPDATE Customer SET CustomerEmail ='" + CustomerEmail + "'" + ","
                + "CustomerName = '" + CustomerName + "'" + ","
                + "CustomerPassword = '" + CustomerPass + "'" + ","
                + "CustomerPhone = '" + CustomerPhone + "'" + ","
                + "CustomerAddress = '" + CustomerAddress + "'" 
                + "WHERE CustomerEmail ='" + User.userEmail + "'";

                using (SqlCommand UpdateCmd = new SqlCommand(sql, UpdateCon))
                {

                    try
                    {
                        //Opening the connection:
                        UpdateCon.Open();

                        //cmd.CommandType = CommandType.Text;
                        UpdateCmd.ExecuteNonQuery();

                        //Disconnect
                        UpdateCon.Close();

                        MessageBox.Show("Your Information has been Updated. Please login again");

                        FormLogin formLogin1 = new FormLogin();
                        formLogin1.Show();
                        this.Hide();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Email / User name already registered");
                    }
                }

            }
        }

        private void buttonUpdateToLogin_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.Show();
            this.Hide();
        }
    }
}

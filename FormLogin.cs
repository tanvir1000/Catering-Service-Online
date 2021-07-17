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

    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

        }



        public void buttonLogIn_Click(object sender, EventArgs e)
        {

                SqlConnection LogIncon = new SqlConnection();

                LogIncon.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                       "integrated security = SSPI";

                string CustomerEmail = textBoxEmailLogin.Text;
                string CustomerPassword = textBoxPasswordLogin.Text;

                User.userEmail = CustomerEmail;

                if (CustomerEmail == "")
                {
                    MessageBox.Show("Invalid Insertion");
                }
                else if (CustomerEmail == "Admin" && CustomerPassword == "Admin")
                {
                    Admin Admin1 = new Admin();
                    Admin1.Show();
                    this.Hide();
                }
                else
                {
                    //Generating SQL Query

                    string query = "Select * from Customer where CustomerEmail= '"
                        + CustomerEmail + "' and CustomerPassword= '" + CustomerPassword + "'";


                    SqlCommand command = new SqlCommand(query, LogIncon);

                    //Opening the connection:
                    LogIncon.Open();

                    //Execute SQL Query:
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                LogIncon.Close();
                                MessageBox.Show("Login Successful");
                                CustomerMenu customerMenu = new CustomerMenu();
                                customerMenu.Show();
                                this.Hide();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email / User-name and Password doesn't match");
                        }
                    }
                }





        }

        private void buttonRegisterNew_Click(object sender, EventArgs e)
        {
            FormRegisterNew formRegisterNew1 = new FormRegisterNew();
            formRegisterNew1.Show();
            this.Hide();
        }
    }
}

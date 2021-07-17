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
    public partial class FormRegisterNew : Form
    {
        public FormRegisterNew()
        {
            InitializeComponent();
        }

        private void buttonSubmitRegister_Click(object sender, EventArgs e)
        {

            SqlConnection RegiCon = new SqlConnection();

            RegiCon.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";

            string CustomerEmail = textBoxEmailRegister.Text;
            string CustomerName = textBoxNameRegister.Text;
            string CustomerPass = textBoxPassRegister.Text;
            string CustomerPhone = textBoxPhoneRegister.Text;
            string CustomerAddress = richTextBoxAddressRegister.Text;

            
            string sql = "INSERT INTO Customer(CustomerEmail,CustomerName,CustomerPassword,"
                         +"CustomerPhone,CustomerAddress)" + " VALUES("
                         + "'" + CustomerEmail + "'" + ","
                         + "'" + CustomerName + "'" + ","
                         + "'" + CustomerPass + "'" + ","
                         + "'" + CustomerPhone + "'" + ","
                         + "'" + CustomerAddress + "'"+ ")";

            using (SqlCommand RegiCmd = new SqlCommand(sql, RegiCon))
            {

                try
                {
                    //Opening the connection:
                    RegiCon.Open();

                    //cmd.CommandType = CommandType.Text;
                    RegiCmd.ExecuteNonQuery();

                    //Disconnect
                    RegiCon.Close();

                    MessageBox.Show("Thank you for your registration. You can log in now with your Email / User-name");

                    FormLogin formLogin1 = new FormLogin();
                    formLogin1.Show();
                    this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Email / User-name already registered");
                }


            }


        }

        private void buttonRegiToLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin1 = new FormLogin();
            formLogin1.Show();
            this.Hide();
        }
    }
}

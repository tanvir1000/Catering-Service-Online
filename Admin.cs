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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";

            //Generating SQL Query

            string Orderquery = "select * from OrderNow";// where CustomerName = '" + User.userName + "'";
            string Reviewquery = "select * from Review";
            string Cancelquery = "select * from CancelOrder";
            string Infoquery = "select * from Customer";

            SqlCommand Ordercommand = new SqlCommand(Orderquery, con);
            SqlCommand Reviewcommand = new SqlCommand(Reviewquery, con);
            SqlCommand Cancelcommand = new SqlCommand(Cancelquery, con);
            SqlCommand Infocommand = new SqlCommand(Infoquery, con);

            //Opening the connection:
            con.Open();

            //Execute SQL Query:
            SqlDataReader Orderreader = Ordercommand.ExecuteReader();

            //Binding reader to source
            BindingSource Ordersource = new BindingSource();
            Ordersource.DataSource = Orderreader;



            con.Close();


            con.Open();


            //Execute SQL Query:
            SqlDataReader Reviewreader = Reviewcommand.ExecuteReader();

            //Binding reader to source
            BindingSource Reviewsource = new BindingSource();
            Reviewsource.DataSource = Reviewreader;



            con.Close();

            con.Open();


            //Execute SQL Query:
            SqlDataReader Cancelreader = Cancelcommand.ExecuteReader();

            //Binding reader to source
            BindingSource Cancelsource = new BindingSource();
            Cancelsource.DataSource = Cancelreader;



            con.Close();

            
            con.Open();


            //Execute SQL Query:
            SqlDataReader Inforeader = Infocommand.ExecuteReader();

            //Binding reader to source
            BindingSource Infosource = new BindingSource();
            Infosource.DataSource = Inforeader;



            con.Close();

            //binding source to grid view control
            dataGridViewOrder.DataSource = Ordersource;
            dataGridViewReview.DataSource = Reviewsource;
            dataGridViewCancelOrder.DataSource = Cancelsource;
            dataGridViewInfo.DataSource = Infosource;

        }

        private void ButtonAdminLogout_Click(object sender, EventArgs e)
        {

            FormLogin formLogin1 = new FormLogin();
            formLogin1.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {



            SqlConnection RegiCon = new SqlConnection();

            RegiCon.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";

            String CancelNumber = textBoxCancel.Text;


            string sql = "DELETE FROM OrderNow WHERE OrderNumber = "
                       + CancelNumber;

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

                    MessageBox.Show("Order Number " + CancelNumber + " has been cancelled");

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Input Order Number");
                }


            }

        }
    }
}

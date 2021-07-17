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
    public partial class UserControlReview : UserControl
    {
        public UserControlReview()
        {
            InitializeComponent();


        }

        private void UserControlReview_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";

            //Generating SQL Query


            string Reviewquery = "select * from Review";


            SqlCommand Reviewcommand = new SqlCommand(Reviewquery, con);

            //Opening the connection:
            con.Open();


            //Execute SQL Query:
            SqlDataReader Reviewreader = Reviewcommand.ExecuteReader();

            //Binding reader to source
            BindingSource Reviewsource = new BindingSource();
            Reviewsource.DataSource = Reviewreader;



            con.Close();

            //binding source to grid view control
            dataGridViewReview.DataSource = Reviewsource;
        }



        private void buttonReview_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                       "integrated security = SSPI";

                string CustomerReview = richTextBoxReview.Text;

                string customerNameString = "Select CustomerName from Customer where CustomerEmail='" + User.userEmail + "'";

                SqlCommand Cmd = new SqlCommand(customerNameString, con);

                con.Open();
                using (SqlDataReader dataReader = Cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        User.userName = dataReader["CustomerName"].ToString();


                    }

                 
                }
                con.Close();


            if (CustomerReview == "")
            {
                MessageBox.Show("Please input your Review in the Text box");
            }
            else
            {
                string sql = "INSERT INTO Review(CustomerName,Review) VALUES("
             + "'" + User.userName + "'" + ","
             + "'" + CustomerReview + "'" + ")";
                using (SqlCommand ReviewCmd = new SqlCommand(sql, con))
                
                {


                    //Opening the connection:
                    con.Open();

                    //cmd.CommandType = CommandType.Text;
                    ReviewCmd.ExecuteNonQuery();

                    //Disconnect
                    con.Close();

                    MessageBox.Show("Thank you for your review");

                }

            }

        }

    }
}

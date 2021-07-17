using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Catering_Service_Online
{
    public partial class UserControlOrderNow : UserControl
    {
        public string RiceQnt { get; private set; }

        public UserControlOrderNow()
        {
            InitializeComponent();

            string[] payment = new string[4];
            payment[0]="Cash on delivery";
            payment[1]="Bkash";
            payment[2]="Nogod";
            payment[3]="Credit/Debit";

            cbPaymentMethod.DataSource = payment;

        }

        public void buttonCalculate_Click(object sender, EventArgs e)
        {

            User.Costtotal = ( User.RiceQnt * 100 
                + User.TikkaQnt * 120
                + User.FishQnt * 150
                + User.ChicBiriQnt * 180
                + User.BeefBiriQnt * 220
                + User.MuttonQnt * 250
                + User.BeefBurgQnt * 180
                + User.ChicBurgQnt * 150
                + User.SandwichQnt * 150
                + User.FriesQnt * 60
                + User.PizzaQnt * 150
                + User.WingsQnt * 120
                + User.WaterQnt * 10
                + User.JuiceQnt * 60
                + User.ColaQnt * 30
                + User.TeaQnt * 15
                + User.CoffeeQnt * 20
                + User.ChocoQnt * 60
                + User.BananaQnt * 60
                + User.MangoQnt * 60
                + User.StrawQnt * 60
                + User.DoughnutsQnt * 60
                + User.WafflesQnt * 60
                + User.MuffinsQnt * 60
                + User.IcecreamQnt * 60);

            lblTotalCost.Text = User.Costtotal.ToString();

        }


        private void buttonOrderConfirm_Click(object sender, EventArgs e)
        {


            User.Costtotal = (User.RiceQnt * 100
                            + User.TikkaQnt * 120
                            + User.FishQnt * 150
                            + User.ChicBiriQnt * 180
                            + User.BeefBiriQnt * 220
                            + User.MuttonQnt * 250
                            + User.BeefBurgQnt * 180
                            + User.ChicBurgQnt * 150
                            + User.SandwichQnt * 150
                            + User.FriesQnt * 60
                            + User.PizzaQnt * 150
                            + User.WingsQnt * 120
                            + User.WaterQnt * 10
                            + User.JuiceQnt * 60
                            + User.ColaQnt * 30
                            + User.TeaQnt * 15
                            + User.CoffeeQnt * 20
                            + User.ChocoQnt * 60
                            + User.BananaQnt * 60
                            + User.MangoQnt * 60
                            + User.StrawQnt * 60
                            + User.DoughnutsQnt * 60
                            + User.WafflesQnt * 60
                            + User.MuffinsQnt * 60
                            + User.IcecreamQnt * 60);


            DateTime deliveryTime = dtpDeliveryTime.Value;
            string paymentMethod = cbPaymentMethod.SelectedItem.ToString();

            SqlConnection Ordercon = new SqlConnection();

            Ordercon.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";



            
             string customerNameString = "Select CustomerName,CustomerID from Customer where CustomerEmail='" + User.userEmail + "'";

            SqlCommand Cmd = new SqlCommand(customerNameString, Ordercon);
            
            Ordercon.Open();
            using (SqlDataReader dataReader = Cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                     User.userName = dataReader["CustomerName"].ToString();
                    User.userID = dataReader["CustomerID"].ToString();
                    

                }

               
            }
            Ordercon.Close();


            string Ordersql = "INSERT INTO OrderNow(CustomerName,PlainRice,TikkaMasala,FishKebab,"
                + "ChickenBiriyani,BeefBiriyani,MuttonBiriyani,BeefBurger,ChickenBurger,Sandwich,"
                + "Fries,Pizza,Wings,Water,Juice,Cola,Tea,Coffee,ChocoShake,MangoShake,"
                + "BananaShake,StarwberryShake,Doughnuts,Waffles,Muffins,IceCream,DeliveryTime," +
                "PaymentMethod,TotalCost)"
                + " VALUES ('"+ User.userName + "','" 
                               + User.RiceQnt + "'" + ","
                         + "'" + User.TikkaQnt + "'" + ","
                         + "'" + User.FishQnt + "'" + ","
                         + "'" + User.ChicBiriQnt + "'" + ","
                         + "'" + User.BeefBiriQnt + "'" + ","
                         + "'" + User.MuttonQnt + "'" + ","
                         + "'" + User.BeefBurgQnt + "'" + ","
                         + "'" + User.ChicBurgQnt + "'" + ","
                         + "'" + User.SandwichQnt + "'" + ","
                         + "'" + User.FriesQnt + "'" + ","
                         + "'" + User.PizzaQnt + "'" + ","
                         + "'" + User.WingsQnt + "'" + ","
                         + "'" + User.WaterQnt + "'" + ","
                         + "'" + User.JuiceQnt + "'" + ","
                         + "'" + User.ColaQnt + "'" + ","
                         + "'" + User.TeaQnt + "'" + ","
                         + "'" + User.CoffeeQnt + "'" + ","
                         + "'" + User.ChocoQnt + "'" + ","
                         + "'" + User.BananaQnt + "'" + ","
                         + "'" + User.MangoQnt + "'" + ","
                         + "'" + User.StrawQnt + "'" + ","
                         + "'" + User.DoughnutsQnt + "'" + ","
                         + "'" + User.WafflesQnt + "'" + ","
                         + "'" + User.MuffinsQnt + "'" + ","
                         + "'" + User.IcecreamQnt + "'" + ","
                         + "'" + deliveryTime + "'" + ","
                         + "'" + paymentMethod + "'" + ","
                         + User.Costtotal + ")";
            if (User.Costtotal == 0)
            {
                MessageBox.Show("You haven't ordered anything");
            }
            else
            {
                using (SqlCommand Ordercmd = new SqlCommand(Ordersql, Ordercon))

                {
                    //Opening the connection:
                    Ordercon.Open();

                    //cmd.CommandType = CommandType.Text;
                    Ordercmd.ExecuteNonQuery();

                    //Disconnect
                    Ordercon.Close();



                }




                string OrderNumberString = "Select OrderNumber from OrderNow where CustomerName='" + User.userName + "'";

                SqlCommand OrderNumberCmd = new SqlCommand(OrderNumberString, Ordercon);

                Ordercon.Open();
                using (SqlDataReader dataReader = OrderNumberCmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        User.orderNum = dataReader["OrderNumber"].ToString();

                    }

                    
                }
                Ordercon.Close();
                MessageBox.Show("CUSTOMER ORDER RECEIPT \n" +
                    "\n Order Number:              " + User.orderNum +
                    "\n Customer ID:               " + User.userID +
                    "\n Customer Name:             " + User.userName + "\n" +
                    "\n Plain Rice Quantity:            " + RiceQnt +
                    "\n Tikka Masala Quantity:       " + User.TikkaQnt +
                    "\n Fish Kebab Quantity:          " + User.FishQnt +
                    "\n Chicken Biriyani Quantity:  " + User.ChicBiriQnt +
                    "\n Beef Biriyani Quantity:       " + User.BeefBiriQnt +
                    "\n Mutton Biriyani Quantity:  " + User.MuttonQnt +
                    "\n Beef Burger Quantity:        " + User.BeefBurgQnt +
                    "\n Chiken Burger Quantity:    " + User.ChicBurgQnt +
                    "\n Sandwich Quantity:           " + User.SandwichQnt +
                    "\n Fries Quantity:                   " + User.FriesQnt +
                    "\n Pizza Quantity:                   " + User.PizzaQnt +
                    "\n Wings Quantity:                " + User.WingsQnt +
                    "\n Water Quantity:                 " + User.WaterQnt +
                    "\n Juice Quantity:                   " + User.JuiceQnt +
                    "\n Cola Quantity:                    " + User.ColaQnt +
                    "\n Tea Quantity:                     " + User.TeaQnt +
                    "\n Coffee Quantity:               " + User.CoffeeQnt +
                    "\n Choco shake Quantity:      " + User.ChocoQnt +
                    "\n Mango shake Quantity:      " + User.MangoQnt +
                    "\n Banana shake Quantity:     " + User.BananaQnt +
                    "\n Starwberry shake Quantity: " + User.StrawQnt +
                    "\n Doughnuts  Quantity:       " + User.DoughnutsQnt +
                    "\n Waffles  Quantity:             " + User.WafflesQnt +
                    "\n Muffins Quantity:             " + User.MuffinsQnt +
                    "\n Ice Cream Quantity:          " + User.IcecreamQnt +
                    "\n\n Delivery Time:             " + deliveryTime +
                    "\n\n Payment Method:             " + paymentMethod +
                    "\n\n Total Price:             " + User.Costtotal);

            }
            User.RiceQnt = User.TikkaQnt = User.FishQnt = User.ChicBiriQnt = User.BeefBiriQnt = 0;
            User.MuttonQnt = User.BeefBurgQnt = User.ChicBurgQnt = User.SandwichQnt = User.FriesQnt = 0;
            User.PizzaQnt = User.WingsQnt = User.WaterQnt = User.JuiceQnt = User.ColaQnt = User.TeaQnt = 0;
            User.CoffeeQnt = User.ChocoQnt = User.BananaQnt = User.MangoQnt = User.StrawQnt = 0;
            User.DoughnutsQnt = User.WafflesQnt = User.MuffinsQnt = User.IcecreamQnt = User.Costtotal = 0;
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";

            string CancelOrder = richTextBoxCancelOrder.Text;

            string customerNameString = "Select CustomerName from Customer where CustomerEmail='" + User.userEmail + "'";

            SqlCommand Cmd = new SqlCommand(customerNameString, con);

            con.Open();
            using (SqlDataReader dataReader = Cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    User.userName = dataReader["CustomerName"].ToString();


                }

                con.Close();
            }

            if (CancelOrder == "")
            {
                MessageBox.Show("Invalid Request");
            }


            else
            {
                string sql = "INSERT INTO CancelOrder(CustomerName,CustomerEmail,CancelOrder) VALUES("
             + "'" + User.userName + "'" + ","
             + "'" + User.userEmail + "'" + ","
             + "'" + CancelOrder + "'" + ")";
                using (SqlCommand CancelCmd = new SqlCommand(sql, con))

                {


                    //Opening the connection:
                    con.Open();

                    //cmd.CommandType = CommandType.Text;
                    CancelCmd.ExecuteNonQuery();

                    //Disconnect
                    con.Close();

                    MessageBox.Show("Your request has been submitted under Admin review");

                }

            }
        }

        private void UserControlOrderNow_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source = DESKTOP-5JSHQGT\\SQLEXPRESS; database = myoop2db; " +
                                   "integrated security = SSPI";

            //Generating SQL Query

            string Orderquery = "select * from OrderNow";// where CustomerName = '" + User.userName + "'";

            SqlCommand Ordercommand = new SqlCommand(Orderquery, con);


            //Opening the connection:
            con.Open();

            //Execute SQL Query:
            SqlDataReader Orderreader = Ordercommand.ExecuteReader();

            //Binding reader to source
            BindingSource Ordersource = new BindingSource();
            Ordersource.DataSource = Orderreader;



            con.Close();


            //binding source to grid view control
            dataGridViewOrder.DataSource = Ordersource;

        }
    }
}

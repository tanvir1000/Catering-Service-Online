using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering_Service_Online
{
    
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());


        }
    }
    public static class User
    {
        public static string userEmail;
        public static string userID;
        public static string userName;
        public static string orderNum;
        public static int Costtotal;

        public static int RiceQnt;
        public static int TikkaQnt;
        public static int FishQnt;
        public static int ChicBiriQnt;
        public static int BeefBiriQnt;
        public static int MuttonQnt;

        public static int BeefBurgQnt;
        public static int ChicBurgQnt;
        public static int SandwichQnt;
        public static int FriesQnt;
        public static int PizzaQnt;
        public static int WingsQnt;

        public static int WaterQnt;
        public static int JuiceQnt;
        public static int ColaQnt;
        public static int TeaQnt;
        public static int CoffeeQnt;

        public static int ChocoQnt;
        public static int BananaQnt;
        public static int MangoQnt;
        public static int StrawQnt;

        public static int DoughnutsQnt;
        public static int WafflesQnt;
        public static int MuffinsQnt;
        public static int IcecreamQnt;

    }
}

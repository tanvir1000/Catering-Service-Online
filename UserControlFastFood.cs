using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering_Service_Online
{
    public partial class UserControlFastFood : UserControl
    {
        public UserControlFastFood()
        {
            InitializeComponent();
        }

        private void nudBeefBurQnt_ValueChanged(object sender, EventArgs e)
        {
            User.BeefBurgQnt = (int)nudBeefBurQnt.Value;
        }

        private void nudChicBurQnt_ValueChanged(object sender, EventArgs e)
        {
            User.ChicBurgQnt = (int)nudChicBurQnt.Value;
        }

        private void nudSandwichQnt_ValueChanged(object sender, EventArgs e)
        {
            User.SandwichQnt = (int)nudSandwichQnt.Value;
        }

        private void nudFriesQnt_ValueChanged(object sender, EventArgs e)
        {
            User.FriesQnt = (int)nudFriesQnt.Value;
        }

        private void nudPizzaQnt_ValueChanged(object sender, EventArgs e)
        {
            User.PizzaQnt = (int)nudPizzaQnt.Value;
        }

        private void nudWingsQnt_ValueChanged(object sender, EventArgs e)
        {
            User.WingsQnt = (int)nudWingsQnt.Value;
        }
    }
}

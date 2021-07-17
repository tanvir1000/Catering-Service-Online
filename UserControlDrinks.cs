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
    public partial class UserControlDrinks : UserControl
    {
        public UserControlDrinks()
        {
            InitializeComponent();
        }

        private void nudWaterQnt_ValueChanged(object sender, EventArgs e)
        {
            User.WaterQnt = (int)nudWaterQnt.Value;
        }

        private void nudJuiceQnt_ValueChanged(object sender, EventArgs e)
        {
            User.JuiceQnt = (int)nudJuiceQnt.Value;
        }

        private void nudColaQnt_ValueChanged(object sender, EventArgs e)
        {
            User.ColaQnt = (int)nudColaQnt.Value;
        }

        private void nudTeaQnt_ValueChanged(object sender, EventArgs e)
        {
            User.TeaQnt = (int)nudTeaQnt.Value;
        }

        private void nudCoffeeQnt_ValueChanged(object sender, EventArgs e)
        {
            User.CoffeeQnt = (int)nudCoffeeQnt.Value;
        }
    }
}

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
    public partial class UserControlDessert : UserControl
    {
        public UserControlDessert()
        {
            InitializeComponent();
        }

        private void nudDoughnutsQnt_ValueChanged(object sender, EventArgs e)
        {
            User.DoughnutsQnt = (int)nudDoughnutsQnt.Value;
        }

        private void nudWafflesQnt_ValueChanged(object sender, EventArgs e)
        {
            User.WafflesQnt = (int)nudWafflesQnt.Value;
        }

        private void nudMuffinsQnt_ValueChanged(object sender, EventArgs e)
        {
            User.MuffinsQnt = (int)nudMuffinsQnt.Value;
        }

        private void nudIcecreamQnt_ValueChanged(object sender, EventArgs e)
        {
            User.IcecreamQnt = (int)nudIcecreamQnt.Value;
        }
    }
}

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
    public partial class UserControlShakes : UserControl
    {
        public UserControlShakes()
        {
            InitializeComponent();
        }

        private void nudChocoQnt_ValueChanged(object sender, EventArgs e)
        {
            User.ChocoQnt = (int)nudChocoQnt.Value;
        }

        private void nudBananaQnt_ValueChanged(object sender, EventArgs e)
        {
            User.BananaQnt = (int)nudBananaQnt.Value;
        }

        private void nudMangoQnt_ValueChanged(object sender, EventArgs e)
        {
            User.MangoQnt = (int)nudMangoQnt.Value;
        }

        private void nudStrawQnt_ValueChanged(object sender, EventArgs e)
        {
            User.StrawQnt = (int)nudStrawQnt.Value;
        }
    }
}

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
    public partial class UserControlTraditional : UserControl
    {
        public UserControlTraditional()
        {
            InitializeComponent();
            
        }


        private void panelRice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudRiceQnt_ValueChanged(object sender, EventArgs e)
        {
            User.RiceQnt = (int)nudRiceQnt.Value;
        }

        private void nudTikkaQnt_ValueChanged(object sender, EventArgs e)
        {
            User.TikkaQnt = (int)nudTikkaQnt.Value;
        }

        private void nudFishKebabQnt_ValueChanged(object sender, EventArgs e)
        {
            User.FishQnt = (int)nudFishKebabQnt.Value;
        }

        private void nudChicBiriQnt_ValueChanged(object sender, EventArgs e)
        {
            User.ChicBiriQnt = (int)nudChicBiriQnt.Value;
        }

        private void nudBeefBiriQnt_ValueChanged(object sender, EventArgs e)
        {
            User.BeefBiriQnt = (int)nudBeefBiriQnt.Value;
        }

        private void nudMuttonQnt_ValueChanged(object sender, EventArgs e)
        {
            User.MuttonQnt = (int)nudMuttonQnt.Value;
        }
    }
}

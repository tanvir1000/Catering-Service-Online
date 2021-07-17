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
    public partial class Menu : Form
    {

        private void choose_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            sidePanel.Height = buttonTraditional.Height;
            sidePanel.Top = buttonTraditional.Top;
            controlTraditional1.BringToFront();
        }

        private void buttonTraditional_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonTraditional.Height;
            sidePanel.Top = buttonTraditional.Top;
            controlTraditional1.BringToFront();
        }

        private void buttonFastFood_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFastFood.Height;
            sidePanel.Top = buttonFastFood.Top;
            customFastFood1.BringToFront();
        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFastFood.Height;
            sidePanel.Top = buttonFastFood.Top;
            customFastFood1.BringToFront();
        }

        private void buttonShakes_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFastFood.Height;
            sidePanel.Top = buttonFastFood.Top;
            customFastFood1.BringToFront();
        }

        private void buttonDessert_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFastFood.Height;
            sidePanel.Top = buttonFastFood.Top;
            customFastFood1.BringToFront();
        }

        private void buttonFoodReview_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonFoodReview.Height;
            sidePanel.Top = buttonFoodReview.Top;
            customFoodReview1.BringToFront();
        }

        private void buttonOrderNow_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonOrderNow.Height;
            sidePanel.Top = buttonOrderNow.Top;
            customOrderNow1.BringToFront();
        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            sidePanel.Height = buttonAboutUs.Height;
            sidePanel.Top = buttonAboutUs.Top;
            customAboutUs1.BringToFront();
        }
    }
}

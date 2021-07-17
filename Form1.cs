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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
            SidePanel.Height = buttonTraditional.Height;
            SidePanel.Top = buttonTraditional.Top;
            userControlTraditional1.BringToFront();
        }

        private void buttonTraditional_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonTraditional.Height;
            SidePanel.Top = buttonTraditional.Top;
            userControlTraditional1.BringToFront();
        }

        private void buttonFastFood_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonFastFood.Height;
            SidePanel.Top = buttonFastFood.Top;
            userControlFastFood1.BringToFront();
        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonDrinks.Height;
            SidePanel.Top = buttonDrinks.Top;
            userControlDrinks1.BringToFront();
        }

        private void buttonShakes_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonShakes.Height;
            SidePanel.Top = buttonShakes.Top;
            userControlShakes1.BringToFront();
        }

        private void buttonDessert_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonDessert.Height;
            SidePanel.Top = buttonDessert.Top;
            userControlDessert1.BringToFront();
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonReviews.Height;
            SidePanel.Top = buttonReviews.Top;
            userControlReview1.BringToFront();


        }

        private void buttonOrderNow_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonOrderNow.Height;
            SidePanel.Top = buttonOrderNow.Top;
            userControlOrderNow1.BringToFront();
            
        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonAboutUs.Height;
            SidePanel.Top = buttonAboutUs.Top;
            userControlAboutUs1.BringToFront();
        }

        private void buttonLogOutCustomer_Click(object sender, EventArgs e)
        {
            FormLogin formLogin1  = new FormLogin ();
            formLogin1.Show();
            this.Hide();
        }

        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm1 = new UpdateForm();
            updateForm1.Show();
            this.Hide();
        }
    }
}

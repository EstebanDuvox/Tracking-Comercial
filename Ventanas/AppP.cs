﻿using Tracking_Comercial.SQL;

namespace Tracking_Comercial.Ventanas
{
    public partial class AppP : Form
    {
        public AppP()
        {
            InitializeComponent();
        }

        private void app_Closing(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            RegU a = new RegU();
            a.Show();
        }

    }
}

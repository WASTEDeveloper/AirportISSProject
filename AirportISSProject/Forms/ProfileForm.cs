using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportISSProject.Forms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            panel2.BringToFront();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            maininfoPanel.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            paymentPanel.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            historyPanel.BringToFront();
        }
    }
}

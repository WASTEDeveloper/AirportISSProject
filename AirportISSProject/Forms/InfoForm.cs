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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            newsPanel.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            wayPanel.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            contactsPanel.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            infoPanel.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            faqPanel.BringToFront();
        }
    }
}

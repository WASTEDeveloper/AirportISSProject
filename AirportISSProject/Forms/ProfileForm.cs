using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace AirportISSProject.Forms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
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

        private void guna2CirclePictureBox1_MouseEnter(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Image = Image.FromFile("img/add_photo_nbg_hover.png");
        }

        private void guna2CirclePictureBox1_MouseLeave(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Image = Image.FromFile("img/add_photo_nbg.png");
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FormsConnection.Value2 = false;
        }
    }
}

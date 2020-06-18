using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;
using System.Web.UI.Design;
using AirportISSProject.Forms;

namespace AirportISSProject
{
    public partial class MainForm : Form
    {
        public Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
            label5.Text = (DateTime.Now).ToString();
        }

        public void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            slideImg.Location = new Point(b.Location.X + 148, b.Location.Y - 32);
            slideImg.BringToFront();
            slideImg.Visible = true;
        }

        public void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        public void exitButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExitForm());
            timer2.Enabled = true;
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainArea.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void pictureBox4_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                searchButton.Checked = false;
                ticketButton.Checked = false;
                infoButton.Checked = false;
                profileButton.Checked = false;
                settingsButton.Checked = false;
                exitButton.Checked = false;
                slideImg.Visible = false;
            }
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchForm());
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = (DateTime.Now).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (FormsConnection.Value == false)
            {
                FormsConnection.Value = true;
                pictureBox4_Click(sender, e);
                timer2.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InfoForm());
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm());
        }
    }
}

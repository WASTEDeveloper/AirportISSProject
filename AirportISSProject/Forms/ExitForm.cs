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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        public void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FormsConnection.Value = false;
            Close();
        }
    }
}

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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            guna2DateTimePicker1.MinDate = DateTime.Now;
            guna2DateTimePicker2.MinDate = DateTime.Now;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2DateTimePicker2.Enabled = true;
            }
            else
            {
                guna2DateTimePicker2.Enabled = false;
            }
        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2DateTimePicker2.Enabled = true;
            }
            else
            {
                guna2DateTimePicker2.Enabled = false;
            }
        }
    }
}

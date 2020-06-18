using AirportISSProject.UserControlForms;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportISSProject.Forms
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        private void TicketsForm_Load(object sender, EventArgs e)
        {
            TicketForm_UC[] ticketForm_ = new TicketForm_UC[10];
            for (int i = 0; i < 10; i++)
            {
                ticketForm_[i] = new TicketForm_UC();
                ticketForm_[i].Left = 20;
                ticketForm_[i].Top = ticketForm_[i].Height * i + 10;
                guna2Panel1.Controls.Add(ticketForm_[i]);
            }
        }
    }
}

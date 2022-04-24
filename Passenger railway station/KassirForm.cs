using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Passenger_railway_station
{
    public partial class KassirForm : Form
    {
        public Authorization form;

        public KassirForm()
        {
            InitializeComponent();
        }

        private void chUs_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }

        private void TicketsPrig_Click(object sender, EventArgs e)
        {
            TicketsPrig tp = new TicketsPrig();
            tp.form = this;
            tp.Owner = this;
            tp.TopMost = true;
            tp.Show();
            Hide();
        }

        private void TicketsDal_Click(object sender, EventArgs e)
        {
            TicketsDal td = new TicketsDal();
            td.form = this;
            td.Owner = this;
            td.TopMost = true;
            td.Show();
            Hide();
        }
    }
}

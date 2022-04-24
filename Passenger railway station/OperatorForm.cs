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
    public partial class OperatorForm : Form
    {
        public Authorization form;

        public OperatorForm()
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

        private void Routes_Click(object sender, EventArgs e)
        {
            Routes rs = new Routes();
            rs.frm = this;
            rs.Owner = this;
            rs.TopMost = true;
            rs.Show();
            Hide();
        }

        private void Trains_Click(object sender, EventArgs e)
        {
            Trains ts = new Trains();
            ts.frm = this;
            ts.Owner = this;
            ts.TopMost = true;
            ts.Show();
            Hide();
        }

        private void Trips_Click(object sender, EventArgs e)
        {
            Trips ts = new Trips();
            ts.frm = this;
            ts.Owner = this;
            ts.TopMost = true;
            ts.Show();
            Hide();
        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            Schedule se = new Schedule();
            se.frm = this;
            se.Owner = this;
            se.TopMost = true;
            se.Show();
            Hide();
        }
    }
}

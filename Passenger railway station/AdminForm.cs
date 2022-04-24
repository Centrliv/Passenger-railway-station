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
    public partial class AdminForm : Form
    {
        public Authorization form;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            UsManege um = new UsManege();
            um.form = this;
            um.Owner = this;
            um.TopMost = true;
            um.Show();
            Hide();
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

        private void Facilities_Click(object sender, EventArgs e)
        {
            Facilities fs = new Facilities();
            fs.form = this;
            fs.Owner = this;
            fs.TopMost = true;
            fs.Show();
            Hide();
        }

        private void Routes_Click(object sender, EventArgs e)
        {
            Routes rs = new Routes();
            rs.form = this;
            rs.Owner = this;
            rs.TopMost = true;
            rs.Show();
            Hide();
        }

        private void Trains_Click(object sender, EventArgs e)
        {
            Trains ts = new Trains();
            ts.form = this;
            ts.Owner = this;
            ts.TopMost = true;
            ts.Show();
            Hide();
        }

        private void Trips_Click(object sender, EventArgs e)
        {
            Trips ts = new Trips();
            ts.form = this;
            ts.Owner = this;
            ts.TopMost = true;
            ts.Show();
            Hide();
        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            Schedule se = new Schedule();
            se.form = this;
            se.Owner = this;
            se.TopMost = true;
            se.Show();
            Hide();
        }
    }
}

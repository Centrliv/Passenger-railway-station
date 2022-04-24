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
    public partial class TicketsDal : Form
    {
        public KassirForm form;

        public void UpdateF()
        {
            this.ticketsdalTableAdapter.Fill(this.rpsDataSet.ticketsdal);
        }

        public TicketsDal()
        {
            InitializeComponent();
        }

        private void TicketsDal_Load(object sender, EventArgs e)
        {
            UpdateF();
        }

        private void tdAdd_Click(object sender, EventArgs e)
        {
            AddTickDal atd = new AddTickDal();
            atd.form = this;
            atd.Owner = this;
            atd.TopMost = true;
            atd.ShowDialog();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void TicketsDal_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}

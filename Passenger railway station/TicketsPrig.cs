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
    public partial class TicketsPrig : Form
    {
        public KassirForm form;

        public void UpdateF()
        {
            this.ticketsprigTableAdapter.Fill(this.rpsDataSet.ticketsprig);
        }

        public TicketsPrig()
        {
            InitializeComponent();
        }

        private void TicketsPrig_Load(object sender, EventArgs e)
        {
            UpdateF();
        }

        private void tpAdd_Click(object sender, EventArgs e)
        {
            AddTickPrig atp = new AddTickPrig();
            atp.form = this;
            atp.Owner = this;
            atp.TopMost = true;
            atp.ShowDialog();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void TicketsPrig_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}

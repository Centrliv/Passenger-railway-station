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
    public partial class Schedule : Form
    {
        public AdminForm form;
        public OperatorForm frm;

        public void UpdateF()
        {
            this.raspisanieTableAdapter.Fill(this.rpsDataSet.raspisanie);

            if (schedTable.Rows.Count == 0)
            {
                shcCh.Enabled = false;
            }
            else
            {
                shcCh.Enabled = true;
            }
        }

        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            UpdateF();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            try
            {
                form.Show();
                Hide();
            }
            catch
            {
                frm.Show();
                Hide();
            }
        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                form.Show();
                Hide();
            }
            catch
            {
                frm.Show();
                Hide();
            }
        }

        private void shcCh_Click(object sender, EventArgs e)
        {
            DataBank.idR = int.Parse(schedTable.CurrentRow.Cells[0].Value.ToString());
            DataBank.idP = schedTable.CurrentRow.Cells[1].Value.ToString();
            DataBank.sto = schedTable.CurrentRow.Cells[2].Value.ToString();
            DataBank.stn = schedTable.CurrentRow.Cells[3].Value.ToString();
            DataBank.dto = DateTime.Parse(schedTable.CurrentRow.Cells[4].Value.ToString());
            DataBank.dtp = DateTime.Parse(schedTable.CurrentRow.Cells[5].Value.ToString());
            ChSched cs = new ChSched();
            cs.form = this;
            cs.Owner = this;
            cs.TopMost = true;
            cs.ShowDialog();
        }
    }
}

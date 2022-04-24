using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.MySql;

namespace Passenger_railway_station
{
    public partial class Trains : Form
    {
        public AdminForm form;
        public OperatorForm frm;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public void UpdateF()
        {
            this.poezdTableAdapter1.Fill(this.rpsDataSet.poezd);

            if (trainTable.Rows.Count == 0)
            {
                tCh.Enabled = false;
                tDel.Enabled = false;
                Vans.Enabled = false;
            }
            else
            {
                tCh.Enabled = true;
                tDel.Enabled = true;
                Vans.Enabled = true;
            }
        }

        public Trains()
        {
            InitializeComponent();
        }

        private void Trains_Load(object sender, EventArgs e)
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

        private void Trains_FormClosed(object sender, FormClosedEventArgs e)
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

        private void tAdd_Click(object sender, EventArgs e)
        {
            AddTrain at = new AddTrain();
            at.form = this;
            at.Owner = this;
            at.TopMost = true;
            at.ShowDialog();
        }

        private void tDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранный поезд? \nВсе связанные вагоны будут также удалены", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            if (result == DialogResult.Yes)
            {
                string del = trainTable.CurrentRow.Cells[0].Value.ToString();
                MySqlConnection con = new MySqlConnection(conString);
                cmd.Connection = con;

                cmd.CommandText = string.Format("DELETE FROM poezd WHERE id_poezd = '{0}'", del);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                UpdateF();
            }
        }

        private void tCh_Click(object sender, EventArgs e)
        {
            DataBank.sn = trainTable.CurrentRow.Cells[0].Value.ToString();
            DataBank.model = trainTable.CurrentRow.Cells[1].Value.ToString();
            DataBank.date = trainTable.CurrentRow.Cells[2].Value.ToString();
            DataBank.typeT = trainTable.CurrentRow.Cells[3].Value.ToString();
            ChTrain ct = new ChTrain();
            ct.form = this;
            ct.Owner = this;
            ct.TopMost = true;
            ct.ShowDialog();
        }

        private void Vans_Click(object sender, EventArgs e)
        {
            DataBank.sn = trainTable.CurrentRow.Cells[0].Value.ToString();
            DataBank.typeT = trainTable.CurrentRow.Cells[3].Value.ToString();
            Vans vs = new Vans();
            vs.form = this;
            vs.Owner = this;
            vs.TopMost = true;
            vs.Show();
            Hide();
        }
    }
}

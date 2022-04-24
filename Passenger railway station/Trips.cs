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
    public partial class Trips : Form
    {
        public AdminForm form;
        public OperatorForm frm;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public void UpdateF()
        {
            this.reisyTableAdapter.Fill(this.rpsDataSet.reisy);

            if (tripTable.Rows.Count == 0)
            {
                tDel.Enabled = false;
            }
            else
            {
                tDel.Enabled = true;
            }
        }

        public Trips()
        {
            InitializeComponent();
        }

        private void Trips_Load(object sender, EventArgs e)
        {
            UpdateF();
        }

        private void tCl_Click(object sender, EventArgs e)
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

        private void Trips_FormClosed(object sender, FormClosedEventArgs e)
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

        private void tDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранный рейс?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            if (result == DialogResult.Yes)
            {
                string del = tripTable.CurrentRow.Cells[0].Value.ToString();
                string chstat = tripTable.CurrentRow.Cells[3].Value.ToString();
                MySqlConnection con = new MySqlConnection(conString);
                cmd.Connection = con;

                cmd.CommandText = string.Format("DELETE FROM reisy WHERE id_reis ='{0}'", del);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd.CommandText = string.Format("UPDATE poezd SET status = 0 WHERE id_poezd ='{0}'", chstat);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd.CommandText = string.Format("DELETE FROM raspisanie WHERE id_reis ='{0}'", del);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                UpdateF();
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reisyTableAdapter.Fill(this.rpsDataSet.reisy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tAdd_Click(object sender, EventArgs e)
        {
            AddTrip at = new AddTrip();
            at.form = this;
            at.Owner = this;
            at.TopMost = true;
            at.ShowDialog();
        }
    }
}

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
    public partial class Routes : Form
    {
        public AdminForm form;
        public OperatorForm frm;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public void UpdateF()
        {
            this.routesTableAdapter.Fill(this.rpsDataSet.routes);

            if (routesTable.Rows.Count == 0)
            {
                rCh.Enabled = false;
                rDel.Enabled = false;
                Stations.Enabled = false;
            }
            else
            {
                rCh.Enabled = true;
                rDel.Enabled = true;
                Stations.Enabled = true;
            }
        }

        public Routes()
        {
            InitializeComponent();
        }

        private void Stations_Load(object sender, EventArgs e)
        {
            UpdateF();
        }

        private void rAdd_Click(object sender, EventArgs e)
        {
            AddRoute ar = new AddRoute();
            ar.form = this;
            ar.Owner = this;
            ar.TopMost = true;
            ar.Show();
            Hide();
        }

        private void rDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранный маршрут? \nВсе связанные станции будут также удалены", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            if (result == DialogResult.Yes)
            {
                string del = routesTable.CurrentRow.Cells[0].Value.ToString();
                MySqlConnection con = new MySqlConnection(conString);
                cmd.Connection = con;

                cmd.CommandText = string.Format("DELETE FROM routes WHERE name ='{0}'", del);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                UpdateF();
            }
        }

        private void Routes_FormClosed(object sender, FormClosedEventArgs e)
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

        private void rCl_Click(object sender, EventArgs e)
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

        private void rCh_Click(object sender, EventArgs e)
        {
            DataBank.nameR = routesTable.CurrentRow.Cells[0].Value.ToString();
            DataBank.type = routesTable.CurrentRow.Cells[1].Value.ToString();
            ChRoute cr = new ChRoute();
            cr.form = this;
            cr.Owner = this;
            cr.TopMost = true;
            cr.Show();
            Hide();
        }

        private void Stations_Click(object sender, EventArgs e)
        {
            DataBank.nameR = routesTable.CurrentRow.Cells[0].Value.ToString();
            DataBank.typeR = routesTable.CurrentRow.Cells[1].Value.ToString();
            Stations ss = new Stations();
            ss.form = this;
            ss.Owner = this;
            ss.TopMost = true;
            ss.Show();
            Hide();
        }
    }
}

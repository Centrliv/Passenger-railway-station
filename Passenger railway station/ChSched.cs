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
    public partial class ChSched : Form
    {
        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public Schedule form;

        public ChSched()
        {
            InitializeComponent();
        }

        private void dtd_ValueChanged(object sender, EventArgs e)
        {
            dtd.MaxDate = dtar.Value;
        }

        private void ChSched_Load(object sender, EventArgs e)
        {
            dtd.ValueChanged += dtd_ValueChanged;
            dtar.ValueChanged += dtar_ValueChanged;
            reis.Text = Convert.ToString(DataBank.idR);
            poezd.Text = DataBank.idP;
            st_o.Text = DataBank.sto;
            st_n.Text = DataBank.stn;
            dtd.Value = DataBank.dto;
            dtar.Value = DataBank.dtp;
        }

        private void dtar_ValueChanged(object sender, EventArgs e)
        {
            dtd.MaxDate = dtar.Value;
        }

        private void schedCh_Click(object sender, EventArgs e)
        {
            string dto = dtd.Text;
            string dtp = dtar.Text;
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string com = string.Format("UPDATE raspisanie SET date_time_otpr = @dto, date_time_prib = @dtp WHERE id_reis = {0}", DataBank.idR);
            con.Open();
            cmd.Parameters.AddWithValue("@dto", dto);
            cmd.Parameters.AddWithValue("@dtp", dtp);
            cmd.Connection = con;
            cmd.CommandText = com;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            con.Close();
            cmd.Parameters.Clear();
            form.UpdateF();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ChSched_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}

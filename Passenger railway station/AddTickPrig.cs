using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.MySql;
using Excel = Microsoft.Office.Interop.Excel;

namespace Passenger_railway_station
{
    public partial class AddTickPrig : Form
    {
        public TicketsPrig form;
        private Excel.Application excelapp;
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private Excel.Range excelcells;

        decimal cena = 0;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddTickPrig()
        {
            InitializeComponent();
        }

        private void reis_SelectedIndexChanged(object sender, EventArgs e)
        {
            vagon.Items.Clear();
            vagon.SelectedIndex = -1;
            mesto.Items.Clear();
            mesto.SelectedIndex = -1;
            station.Items.Clear();
            station.SelectedIndex = -1;
            skidka.Items.Clear();
            skidka.SelectedIndex = -1;
            itog.Clear();

            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT id_vagon, vagony.type FROM vagony, reisy WHERE vagony.id_poezd = reisy.id_poezd AND reisy.id_reis = @idR";
            con.Open();
            cmd.Parameters.AddWithValue("@idR", reis.Text.Substring(0, 5));
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.vagon.Items.Add(reader[0].ToString() + "   " + reader[1].ToString());
            }
            con.Close();
            cmd.Parameters.Clear();
            vagon.Enabled = true;

            string SQLcom2 = "SELECT stations.name FROM stations, reisy WHERE stations.name_route = reisy.r_name AND id_reis = @idR";
            con.Open();
            cmd.Parameters.AddWithValue("@idR", reis.Text.Substring(0, 5));
            cmd.Connection = con;

            cmd.CommandText = SQLcom2;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                this.station.Items.Add(read[0].ToString());
            }
            con.Close();
            cmd.Parameters.Clear();
            station.Enabled = true;
        }

        private void AddTickPrig_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT id_reis, r_name FROM reisy WHERE type = 'Пригородный'";
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.reis.Items.Add(reader[0].ToString() + "   " + reader[1].ToString());
            }
            con.Close();
        }

        private void vagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesto.Items.Clear();
            if (mesto.SelectedIndex == -1)
            {
                skidka.SelectedIndex = -1;
                skidka.Enabled = false;
            }
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT num FROM mesta WHERE mesta.status = 0 AND id_vagon = @idV";
            con.Open();
            cmd.Parameters.AddWithValue("@idV", vagon.Text.Substring(0, 5));
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.mesto.Items.Add(reader[0].ToString());
            }
            con.Close();
            cmd.Parameters.Clear();
            mesto.Enabled = true;
        }

        private void mesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            skidka.Items.Clear();
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT title FROM lgoti";
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.skidka.Items.Add(reader[0].ToString());
            }
            con.Close();
            cmd.Parameters.Clear();
            skidka.Enabled = true;
        }

        private void station_SelectedIndexChanged(object sender, EventArgs e)
        {
            skidka.SelectedIndex = -1;
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT cena_sid FROM stations WHERE name = @st";
            con.Open();
            cmd.Parameters.AddWithValue("@st", station.Text);
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cena = Convert.ToDecimal(reader[0].ToString());
            }
            con.Close();
            cmd.Parameters.Clear();
            itog.Text = Convert.ToString(cena);
        }

        private void skidka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skidka.SelectedIndex != -1)
            {
                MySqlConnection con = new MySqlConnection(conString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                string SQLcom = "SELECT size FROM lgoti WHERE title = @st";
                con.Open();
                cmd.Parameters.AddWithValue("@st", skidka.Text);
                cmd.Connection = con;

                cmd.CommandText = SQLcom;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                MySqlDataReader reader = cmd.ExecuteReader();
                string st = "";
                while (reader.Read())
                {
                    st = reader[0].ToString();
                }
                itog.Text = Convert.ToString(cena - cena * Convert.ToInt32(st) / 100);
                con.Close();
                cmd.Parameters.Clear();
            }
        }

        private void spend_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string v = vagon.Text.Substring(0, 5);
            string m = mesto.Text;
            string s = station.Text;
            string sk = skidka.Text;
            decimal itg = Convert.ToDecimal(itog.Text);
            string id_t = "";
            string id_sp = "";

            string SQLcom = "SELECT r_name FROM reisy WHERE id_reis = @rs";
            con.Open();
            cmd.Parameters.AddWithValue("@rs", reis.Text.Substring(0, 5));
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            string g = "Волоколамск";
            MySqlDataReader reader = cmd.ExecuteReader();
            string r = "";
            while (reader.Read())
            {
                r = reader[0].ToString();
            }
            con.Close();
            cmd.Parameters.Clear(); 
            if ((r != "") && (v != "") && (m != "") && (s != "") && (sk != ""))
            {
                string com = "INSERT INTO ticketsprig (dt_prod, kassir, type, reis, st_ot, st_pr, summa, mesto, vagon) VALUES (@dt, @kass, @tp, @rs, @so, @sp, @sum, @mst, @vag)";                
                con.Open();
                cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyy.MM.dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@kass", DataBank.user);
                cmd.Parameters.AddWithValue("@tp", sk);
                cmd.Parameters.AddWithValue("@rs", r);
                cmd.Parameters.AddWithValue("@so", g);
                cmd.Parameters.AddWithValue("@sp", s);
                cmd.Parameters.AddWithValue("@sum", itg);
                cmd.Parameters.AddWithValue("@mst", m);
                cmd.Parameters.AddWithValue("@vag", v);
                cmd.Connection = con;
                cmd.CommandText = com;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                con.Close();
                cmd.Parameters.Clear();

                string com2 = "UPDATE mesta SET status = 1 WHERE id_vagon = @vag AND num = @mst";
                con.Open();
                cmd.Parameters.AddWithValue("@mst", m);
                cmd.Parameters.AddWithValue("@vag", v);
                cmd.Connection = con;
                cmd.CommandText = com2;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                con.Close();
                cmd.Parameters.Clear();
                form.UpdateF();
                Hide();

                string SQcom = "SELECT id_ticket FROM ticketsprig WHERE vagon = @vg AND mesto = @mst";
                con.Open();
                cmd.Parameters.AddWithValue("@vg", v);
                cmd.Parameters.AddWithValue("@mst", m);
                cmd.Connection = con;

                cmd.CommandText = SQcom;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    id_t = rdr[0].ToString();
                }
                con.Close();
                cmd.Parameters.Clear();

                string SQom = "SELECT id_station FROM stations WHERE name_route = @nr AND stations.name = @n";
                con.Open();
                cmd.Parameters.AddWithValue("@nr", r);
                cmd.Parameters.AddWithValue("@n", s);
                cmd.Connection = con;

                cmd.CommandText = SQom;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                MySqlDataReader rr = cmd.ExecuteReader();

                while (rr.Read())
                {
                    id_sp = rr[0].ToString();
                }
                con.Close();
                cmd.Parameters.Clear();

                excelapp = new Excel.Application();
                excelapp.Visible = true;
                excelappworkbooks = excelapp.Workbooks;
                excelappworkbook = excelapp.Workbooks.Open(@"D:\Users\ale_m\Desktop\Passenger railway station\Passenger railway station\Pic\Prig.xlsx",
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing);
                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
                excelcells = excelworksheet.get_Range("B2", "B2");
                excelcells.Value2 = g;
                excelcells = excelworksheet.get_Range("A3", "A3");
                excelcells.Value2 = DataBank.user;
                excelcells = excelworksheet.get_Range("A8", "A8");
                excelcells.Value2 = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
                excelcells = excelworksheet.get_Range("A11", "A11");
                excelcells.Value2 = sk;
                excelcells = excelworksheet.get_Range("B13", "B13");
                excelcells.Value2 = g;
                excelcells = excelworksheet.get_Range("B14", "B14");
                excelcells.Value2 = s;
                excelcells = excelworksheet.get_Range("C15", "C15");
                excelcells.Value2 = itg;
                excelcells = excelworksheet.get_Range("C9", "C9");
                excelcells.Value2 = id_t;
                excelcells = excelworksheet.get_Range("D12", "D12");
                excelcells.Value2 = id_sp;
                excelapp.DisplayAlerts = true;
                excelappworkbooks = excelapp.Workbooks;
                excelappworkbook = excelappworkbooks[1];
                excelappworkbook.Saved = true;

                excelworksheet.PrintOut(
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                excelappworkbook.Close(false, Type.Missing, Type.Missing);

                excelapp.Quit();

            }
            else MessageBox.Show("Одно или несколько полей не заполнены", "Ошибка");
        }

        private void cl_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddTickPrig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
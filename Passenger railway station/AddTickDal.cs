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
    public partial class AddTickDal : Form
    {
        public TicketsDal form;

        private Excel.Application excelapp;
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private Excel.Range excelcells;

        decimal cena = 0;
        string vt = "";

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddTickDal()
        {
            InitializeComponent();
        }

        private void AddTickDal_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT id_reis, r_name FROM reisy WHERE type = 'Дальний'";
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

        private void cl_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddTickDal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
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
                this.vagon.Items.Add(String.Format("{0:D5}     {1}", reader[0], reader[1]));
                vt = reader[1].ToString();
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
            if (vagon.SelectedIndex == 0)
            {
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
            else if (vagon.SelectedIndex == 1)
            {
                string SQLcom = "SELECT cena_plac FROM stations WHERE name = @st";
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
            else if (vagon.SelectedIndex == 2)
            {
                string SQLcom = "SELECT cena_kupe FROM stations WHERE name = @st";
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
            else if (vagon.SelectedIndex == 3)
            {
                string SQLcom = "SELECT cena_sv FROM stations WHERE name = @st";
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
            string td = typedoc.Text;
            string data = num.Text;
            string fio = f_io.Text;
            string r = "";
            string idp = "";
            DateTime dto = DateTime.Now;
            DateTime dtp = DateTime.Now;

            string SQLcom = "SELECT r_name, id_poezd, date_time_otpr, date_time_prib FROM reisy WHERE id_reis = @rs";
            con.Open();
            cmd.Parameters.AddWithValue("@rs", reis.Text.Substring(0, 5));
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            string g = "Волоколамск";
            MySqlDataReader reader = cmd.ExecuteReader();            
            while (reader.Read())
            {
                r = reader[0].ToString();
                idp = reader[1].ToString();
                dto = Convert.ToDateTime(reader[2]);
                dtp = Convert.ToDateTime(reader[3]);
            }
            con.Close();
            cmd.Parameters.Clear();
            if ((r != "") && (v != "") && (m != "") && (s != "") && (sk != "") && (td != "") && (data != "") && (fio != ""))
            {
                string com = "INSERT INTO ticketsdal (id_poezd, dt_otpr, id_vagon, vag_type, lgota, st_otpr, st_nazn, id_mesta, reis, dt_oform, id_kassir, document, id_document, fio, stoim, dt_prib) VALUES (@idp, @dto, @vag, @vagt, @tp, @so, @sp, @mst, @rs, @dt, @kass, @td, @dat, @fio, @sum, @dtp)";
                con.Open();
                cmd.Parameters.AddWithValue("@idp", idp);
                cmd.Parameters.AddWithValue("@dto", dto);
                cmd.Parameters.AddWithValue("@vag", v);
                cmd.Parameters.AddWithValue("@vagt", vt);
                cmd.Parameters.AddWithValue("@tp", sk);
                cmd.Parameters.AddWithValue("@so", g);
                cmd.Parameters.AddWithValue("@sp", s);
                cmd.Parameters.AddWithValue("@mst", m);
                cmd.Parameters.AddWithValue("@rs", r); 
                cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyy.MM.dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@kass", DataBank.user);
                cmd.Parameters.AddWithValue("@td", td);
                cmd.Parameters.AddWithValue("@dat", data);
                cmd.Parameters.AddWithValue("@fio", fio);
                cmd.Parameters.AddWithValue("@sum", itg);
                cmd.Parameters.AddWithValue("@dtp", dtp);
                
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

                string SQcom = "SELECT id_ticket FROM ticketsdal WHERE id_vagon = @vg AND id_mesta = @mst";
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
                excelappworkbook = excelapp.Workbooks.Open(@"D:\Users\ale_m\Desktop\Passenger railway station\Passenger railway station\Pic\Dal.xlsx",
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing);
                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
                excelcells = excelworksheet.get_Range("B5", "B5");
                excelcells.Value2 = idp;
                excelcells = excelworksheet.get_Range("C5", "C5");
                excelcells.Value2 = dto.ToString("yyy.MM.dd HH:mm:ss");
                excelcells = excelworksheet.get_Range("G5", "G5");
                excelcells.Value2 = v;
                excelcells = excelworksheet.get_Range("H5", "H5");
                excelcells.Value2 = vt;
                excelcells = excelworksheet.get_Range("M5", "M5");
                excelcells.Value2 = sk;
                excelcells = excelworksheet.get_Range("B6", "B6");
                excelcells.Value2 = g;
                excelcells = excelworksheet.get_Range("E6", "E6");
                excelcells.Value2 = s;
                excelcells = excelworksheet.get_Range("J6", "J6");
                excelcells.Value2 = id_sp;
                excelcells = excelworksheet.get_Range("C7", "C7");
                excelcells.Value2 = m;
                excelcells = excelworksheet.get_Range("G7", "G7");
                excelcells.Value2 = r;
                excelcells = excelworksheet.get_Range("B8", "B8");
                excelcells.Value2 = id_t;
                excelcells = excelworksheet.get_Range("E8", "E8");
                excelcells.Value2 = DateTime.Now.ToString("ddMMyyyy HHmmss");
                excelcells = excelworksheet.get_Range("H8", "H8");
                excelcells.Value2 = DataBank.user;
                excelcells = excelworksheet.get_Range("B9", "B9");
                excelcells.Value2 = td;
                excelcells = excelworksheet.get_Range("E9", "E9");
                excelcells.Value2 = data;
                excelcells = excelworksheet.get_Range("H9", "H9");
                excelcells.Value2 = fio;
                excelcells = excelworksheet.get_Range("B10", "B10");
                excelcells.Value2 = itg;
                excelcells = excelworksheet.get_Range("D11", "D11");
                excelcells.Value2 = dtp.ToString("yyy.MM.dd HH:mm:ss");    

                excelapp.DisplayAlerts = true;
                excelappworkbooks = excelapp.Workbooks;
                excelappworkbook = excelappworkbooks[1];
                excelappworkbook.Saved = true;

                //excelworksheet.PrintOut(
                //Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                //Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                //GC.Collect();
                //GC.WaitForPendingFinalizers();

                //excelappworkbook.Close(false, Type.Missing, Type.Missing);

                //excelapp.Quit();

            }
            else MessageBox.Show("Одно или несколько полей не заполнены", "Ошибка");
        }

        private void typedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            num.Clear();
        }
    }
}

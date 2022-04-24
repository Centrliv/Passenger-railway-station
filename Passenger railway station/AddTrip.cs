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
    public partial class AddTrip : Form
    {
        public Trips form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddTrip()
        {
            InitializeComponent();
        }

        private void AddTrip_Load(object sender, EventArgs e)
        {
            dtd.ValueChanged += fdate_ValueChanged;
            dtar.ValueChanged += sdate_ValueChanged;
        }

        private void fdate_ValueChanged(object sender, EventArgs e)
        {
            dtar.MinDate = dtd.Value;
        }

        private void sdate_ValueChanged(object sender, EventArgs e)
        {
            dtd.MaxDate = dtar.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            routes.Items.Clear();
            routes.SelectedIndex = -1;

            trains.Items.Clear();
            trains.SelectedIndex = -1;
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT name FROM routes WHERE type = @Rs";
            con.Open();
            cmd.Parameters.AddWithValue("@Rs", types.Text);
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.routes.Items.Add(reader[0].ToString());
            }
            con.Close();
            cmd.Parameters.Clear();

            string SQL = "SELECT id_poezd, model FROM poezd WHERE type = @Rs AND status = 0";
            con.Open();
            cmd.Parameters.AddWithValue("@Rs", types.Text);
            cmd.Connection = con;

            cmd.CommandText = SQL;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                this.trains.Items.Add(read[0].ToString());
            }
            con.Close();

            cmd.Parameters.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            statar.Items.Clear();
            statar.SelectedIndex = -1;
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = "SELECT name FROM stations WHERE name_route = @Nr";
            con.Open();
            cmd.Parameters.AddWithValue("@Nr", routes.Text);
            cmd.Connection = con;

            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.statar.Items.Add(reader[0].ToString());
            }
            con.Close();
            cmd.Parameters.Clear();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddTrip_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            allpl.Text = "";
            freepl.Text = "";
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string SQLcom = string.Format("SELECT count(*) FROM mesta, vagony, poezd WHERE mesta.status = 0 AND mesta.id_vagon = vagony.id_vagon AND vagony.id_poezd = '{0}'", trains.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = SQLcom;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();
            string all = "";
            while (reader.Read())
            {
                all = reader[0].ToString();
            }
            con.Close();
            
            string SQL = string.Format("SELECT count(*) FROM mesta, vagony, poezd WHERE mesta.id_vagon = vagony.id_vagon AND vagony.id_poezd = '{0}'", trains.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = SQL;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader read = cmd.ExecuteReader();
            string free = "";
            while (read.Read())
            {
                free = read[0].ToString();
            }
            con.Close();
            allpl.Text = all;
            freepl.Text = free;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs.Text = "";
            cp.Text = "";
            ck.Text = "";
            csv.Text = "";
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (types.Text == "Дальний")
            {
                string SQLcom = string.Format("SELECT cena_sid, cena_plac, cena_kupe, cena_sv FROM stations WHERE name_route = '{0}' AND name = '{1}'", routes.Text, statar.Text);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = SQLcom;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cs.Text = reader[0].ToString();
                    cp.Text = reader[1].ToString();
                    ck.Text = reader[2].ToString();
                    csv.Text = reader[3].ToString();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                string SQLcom = string.Format("SELECT cena_sid FROM stations WHERE name_route = '{0}' AND name = '{1}'", routes.Text, statar.Text);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = SQLcom;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cs.Text = reader[0].ToString();
                }
                reader.Close();
                con.Close();
            }
        }

        private void tripAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string id = idtrip.Text;
            string type = types.Text;
            string route = routes.Text;
            string train = trains.Text;
            string depart = statd.Text;
            string arriv = statar.Text;
            string datdep = dtd.Text;
            string datarr = dtar.Text;

            if (id != "" && type != "" && route != "" && train != "" && depart != "" && arriv != "" && datdep != "" && datarr != "")
            {
                string SQLcom = "SELECT count(*) FROM reisy WHERE id_reis = @idR";
                con.Open();
                cmd.Parameters.AddWithValue("@idR", id);
                cmd.Connection = con;
                cmd.CommandText = SQLcom;
                long count = (long)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Такой рейс уже существует!", "Ошибка");
                    cmd.Parameters.Clear();
                    con.Close();
                }
                else
                {
                    if (type == "Дальний")
                    {
                        string com = "INSERT INTO reisy (id_reis, type, r_name, id_poezd, st_otpr, st_nazn, mest_obsh, mest_svob, cen_sid, cen_plac, cen_kupe, cen_sv, date_time_otpr, date_time_prib) VALUES (@iD, @tp, @rn, @iDp, @so, @sn, @mo, @ms, @cs, @cp, @ck, @csv, @dto, @dtp)";
                        string SQcom = "UPDATE poezd SET status = 1 WHERE id_poezd = @iDp";
                        string SQco = "INSERT INTO raspisanie (id_reis, id_poezd, st_otpr, st_nazn, date_time_prib, date_time_otpr) VALUES (@iD, @iDp, @so, @sn, @dtp, @dto)";
                        con.Open();
                        cmd.Parameters.AddWithValue("@iD", id);
                        cmd.Parameters.AddWithValue("@tp", type);
                        cmd.Parameters.AddWithValue("@rn", route);
                        cmd.Parameters.AddWithValue("@iDp", train);
                        cmd.Parameters.AddWithValue("@so", depart);
                        cmd.Parameters.AddWithValue("@sn", arriv);
                        cmd.Parameters.AddWithValue("@mo", allpl.Text);
                        cmd.Parameters.AddWithValue("@ms", freepl.Text);
                        cmd.Parameters.AddWithValue("@cs", cs.Text);
                        cmd.Parameters.AddWithValue("@cp", cp.Text);
                        cmd.Parameters.AddWithValue("@ck", ck.Text);
                        cmd.Parameters.AddWithValue("@csv", csv.Text);
                        cmd.Parameters.AddWithValue("@dto", datdep);
                        cmd.Parameters.AddWithValue("@dtp", datarr);
                        cmd.Connection = con;
                        cmd.CommandText = com;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        cmd.CommandText = SQcom;
                        adapter.Fill(table);
                        cmd.CommandText = SQco;
                        adapter.Fill(table);
                        con.Close();
                        cmd.Parameters.Clear();
                        idtrip.Clear();
                        types.SelectedIndex = -1;
                        routes.SelectedIndex = -1;
                        trains.SelectedIndex = -1;
                        statar.SelectedIndex = -1;
                        dtd.Value = DateTime.Now;
                        dtar.Value = DateTime.Now;
                        form.UpdateF();
                    }
                    else
                    {
                        string com = "INSERT INTO reisy (id_reis, type, r_name, id_poezd, st_otpr, st_nazn, mest_obsh, mest_svob, cen_sid, cen_plac, cen_kupe, cen_sv, date_time_otpr, date_time_prib) VALUES (@iD, @tp, @rn, @iDp, @so, @sn, @mo, @ms, @cs, @cp, @ck, @csv, @dto, @dtp);";
                        string SQcom = "UPDATE poezd SET status = 1 WHERE id_poezd = @iDp";
                        string SQco = "INSERT INTO raspisanie (id_reis, id_poezd, st_otpr, st_nazn, date_time_prib, date_time_otpr) VALUES (@iD, @iDp, @so, @sn, @dtp, @dto)";
                        con.Open();
                        cmd.Parameters.AddWithValue("@iD", id);
                        cmd.Parameters.AddWithValue("@tp", type);
                        cmd.Parameters.AddWithValue("@rn", route);
                        cmd.Parameters.AddWithValue("@iDp", train);
                        cmd.Parameters.AddWithValue("@so", depart);
                        cmd.Parameters.AddWithValue("@sn", arriv);
                        cmd.Parameters.AddWithValue("@mo", allpl.Text);
                        cmd.Parameters.AddWithValue("@ms", freepl.Text);
                        cmd.Parameters.AddWithValue("@cs", cs.Text);
                        cmd.Parameters.AddWithValue("@cp", 0);
                        cmd.Parameters.AddWithValue("@ck", 0);
                        cmd.Parameters.AddWithValue("@csv", 0);
                        cmd.Parameters.AddWithValue("@dto", datdep);
                        cmd.Parameters.AddWithValue("@dtp", datarr);
                        cmd.Connection = con;
                        cmd.CommandText = com;                        
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        cmd.CommandText = SQcom;
                        adapter.Fill(table);
                        cmd.CommandText = SQco;
                        adapter.Fill(table);
                        con.Close();
                        cmd.Parameters.Clear();
                        idtrip.Clear();
                        types.SelectedIndex = -1;
                        routes.SelectedIndex = -1;
                        trains.SelectedIndex = -1;
                        statar.SelectedIndex = -1;
                        dtd.Value = DateTime.Now;
                        dtar.Value = DateTime.Now;
                        form.UpdateF();
                    }
                }
            }
            else MessageBox.Show("Одно или несколько полей не заполнены", "Ошибка");
        }

        private void idtrip_MouseClick(object sender, MouseEventArgs e)
        {
            idtrip.SelectionStart = 0;
        }
    }
}

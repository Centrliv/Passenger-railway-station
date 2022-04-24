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
    public partial class ChSt : Form
    {
        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public Stations form;

        public ChSt()
        {
            InitializeComponent();
        }

        private void sCh_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string name = sN.Text;
            string priceSid = sPs.Text;
            string pricePlac = sPp.Text;
            string priceKup = sPk.Text;
            string priceSV = sPl.Text;
            try
            {
                if (DataBank.typeR == "Пригородный")
                {
                    if ((name != "") && (priceSid != ""))
                    {
                        if (name == DataBank.nameS)
                        {
                            string com = string.Format("UPDATE stations SET name = @sN, cena_sid = @sPs WHERE name = '{0}' AND name_route = '{1}'", DataBank.nameS, DataBank.nameR);
                            con.Open();
                            cmd.Parameters.AddWithValue("@sN", name);
                            cmd.Parameters.AddWithValue("@rN", DataBank.nameR);
                            cmd.Parameters.AddWithValue("@sPs", priceSid);
                            cmd.Connection = con;
                            cmd.CommandText = com;
                            adapter.SelectCommand = cmd;
                            adapter.Fill(table);
                            con.Close();
                            cmd.Parameters.Clear();
                            DataBank.nameS = name;
                            form.Stations_Load(sender, e);
                        }
                        else
                        {
                            string SQLcom = "SELECT count(*) FROM stations WHERE name = @sN AND name_route = @rN";
                            con.Open();
                            cmd.Parameters.AddWithValue("@sN", name);
                            cmd.Parameters.AddWithValue("@rN", DataBank.nameR);
                            cmd.Connection = con;
                            cmd.CommandText = SQLcom;
                            long count = (long)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Такая станция на данном маршруте уже существует!", "Ошибка");
                                cmd.Parameters.Clear();
                                con.Close();
                            }
                            else
                            {
                                string com = string.Format("UPDATE stations SET name = @sN, cena_sid = @sPs, cena_plac = @sPp, cena_kupe = @sPk, cena_sv = @sPl WHERE name = '{0}' AND name_route = '{1}'", DataBank.nameS, DataBank.nameR);
                                con.Open();
                                cmd.Parameters.AddWithValue("@sN", name);
                                cmd.Parameters.AddWithValue("@rN", DataBank.nameR);
                                cmd.Parameters.AddWithValue("@sPs", priceSid);
                                cmd.Connection = con;
                                cmd.CommandText = com;
                                adapter.SelectCommand = cmd;
                                adapter.Fill(table);
                                con.Close();
                                cmd.Parameters.Clear();
                                DataBank.nameS = name;
                                form.Stations_Load(sender, e);
                            }
                        }
                    }
                    else MessageBox.Show("Одно или несколько полей не заполнены", "Ошибка");
                }
                else if (DataBank.typeR == "Дальний")
                {
                    if ((name != "") && (priceSid != "") && (pricePlac != "") && (priceKup != "") && (priceSV != ""))
                    {
                        if (name == DataBank.nameS)
                        {
                            string com = string.Format("UPDATE stations SET name = @sN, cena_sid = @sPs, cena_plac = @sPp, cena_kupe = @sPk, cena_sv = @sPl WHERE name = '{0}' AND name_route = '{1}'", DataBank.nameS, DataBank.nameR);
                            con.Open();
                            cmd.Parameters.AddWithValue("@sN", name);
                            cmd.Parameters.AddWithValue("@rN", DataBank.nameR);
                            cmd.Parameters.AddWithValue("@sPs", priceSid);
                            cmd.Parameters.AddWithValue("@sPp", pricePlac);
                            cmd.Parameters.AddWithValue("@sPk", priceKup);
                            cmd.Parameters.AddWithValue("@sPl", priceSV);
                            cmd.Connection = con;
                            cmd.CommandText = com;
                            adapter.SelectCommand = cmd;
                            adapter.Fill(table);
                            con.Close();
                            cmd.Parameters.Clear();
                            DataBank.nameS = name;
                            form.Stations_Load(sender, e);
                        }
                        else
                        {
                            string SQLcom = "SELECT count(*) FROM stations WHERE name = @sN AND name_route = @rN";
                            con.Open();
                            cmd.Parameters.AddWithValue("@sN", name);
                            cmd.Parameters.AddWithValue("@rN", DataBank.nameR);
                            cmd.Connection = con;
                            cmd.CommandText = SQLcom;
                            long count = (long)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Такая станция на данном маршруте уже существует!", "Ошибка");
                                cmd.Parameters.Clear();
                                con.Close();
                            }
                            else
                            {
                                string com = string.Format("UPDATE stations SET name = @sN, cena_sid = @sPs, cena_plac = @sPp, cena_kupe = @sPk, cena_sv = @sPl WHERE name = '{0}' AND name_route = '{1}'", DataBank.nameS, DataBank.nameR);
                                con.Open();
                                cmd.Parameters.AddWithValue("@sN", name);
                                cmd.Parameters.AddWithValue("@rN", DataBank.nameR);
                                cmd.Parameters.AddWithValue("@sPs", priceSid);
                                cmd.Parameters.AddWithValue("@sPp", pricePlac);
                                cmd.Parameters.AddWithValue("@sPk", priceKup);
                                cmd.Parameters.AddWithValue("@sPl", priceSV);
                                cmd.Connection = con;
                                cmd.CommandText = com;
                                adapter.SelectCommand = cmd;
                                adapter.Fill(table);
                                con.Close();
                                cmd.Parameters.Clear();
                                DataBank.nameS = name;
                                form.Stations_Load(sender, e);
                            }
                        }
                    }
                    else MessageBox.Show("Одно или несколько полей не заполнены", "Ошибка");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода цены!", "Ошибка");
            }
        }        

        private void cl_Click(object sender, EventArgs e)
        {
            form.UpdateF();
            Hide();
        }

        private void ChSt_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.UpdateF();
            Hide();
        }

        private void sP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void ChSt_Load(object sender, EventArgs e)
        {
            sN.Text = DataBank.nameS;
            if (DataBank.typeR == "Пригородный")
            {
                sPs.Text = Convert.ToString(DataBank.priceS);
                label3.Visible = false;
                sPp.Visible = false;
                label4.Visible = false;
                sPk.Visible = false;
                label5.Visible = false;
                sPl.Visible = false;
            }
            else
            {
                sPs.Text = Convert.ToString(DataBank.priceS);
                sPp.Text = Convert.ToString(DataBank.priceP);
                sPk.Text = Convert.ToString(DataBank.priceK);
                sPl.Text = Convert.ToString(DataBank.priceSV);
            }
        }
    }
}

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
    public partial class AddSt : Form
    {
        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public Stations form;

        public AddSt()
        {
            InitializeComponent();
        }

        private void sAdd_Click(object sender, EventArgs e)
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
                            string com = "INSERT INTO stations (name, cena_sid, name_route) VALUES (@sN, @sPs, @rN)";
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
                            sN.Clear();
                            sPs.Clear();
                            form.Stations_Load(sender, e);
                        }
                    }
                    else MessageBox.Show("Одно или несколько полей не заполнены", "Ошибка");
                }
                else
                {
                    if ((name != "") && (priceSid != "") && (pricePlac != "") && (priceKup != "") && (priceSV != ""))
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
                            string com = "INSERT INTO stations (name, cena_sid, cena_plac, cena_kupe, cena_sv, name_route) VALUES (@sN, @sPs, @sPp, @sPk, @sPl, @rN)";
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
                            sN.Clear();
                            sPs.Clear();
                            sPp.Clear();
                            sPk.Clear();
                            sPl.Clear();
                            form.Stations_Load(sender, e);
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

        private void AddSt_FormClosed(object sender, FormClosedEventArgs e)
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

        private void AddSt_Load(object sender, EventArgs e)
        {
            if (DataBank.typeR == "Пригородный")
            {
                label3.Visible = false;
                sPp.Visible = false;
                label4.Visible = false;
                sPk.Visible = false;
                label5.Visible = false;
                sPl.Visible = false;
            }
        }
    }
}

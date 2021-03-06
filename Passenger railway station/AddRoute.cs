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
    public partial class AddRoute : Form
    {
        public Routes form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddRoute()
        {
            InitializeComponent();
        }

        private void rAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string name = rN.Text;
            string type;
            if (p.Checked == true)
                type = "Пригородный";
            else
                type = "Дальний";

            if (name != "")
            {
                string SQLcom = "SELECT count(*) FROM routes WHERE name = @rN";
                con.Open();
                cmd.Parameters.AddWithValue("@rN", name);
                cmd.Connection = con;
                cmd.CommandText = SQLcom;
                long count = (long)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Такой маршрут уже существует!", "Ошибка");
                    cmd.Parameters.Clear();
                    con.Close();
                }
                else
                {
                    string com = "INSERT INTO routes (name, type) VALUES (@rN, @rT)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@rN", name);
                    cmd.Parameters.AddWithValue("@rT", type);
                    cmd.Connection = con;
                    cmd.CommandText = com;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    con.Close();
                    cmd.Parameters.Clear();
                    rN.Clear();
                    p.Checked = true;
                }
            }
            else MessageBox.Show("Не заполнено название маршрута", "Ошибка");
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.UpdateF();
            form.Show();
            Hide();
        }

        private void AddRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.UpdateF();
            form.Show();
            Hide();
        }
    }
}

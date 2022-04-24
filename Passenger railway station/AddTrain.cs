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
    public partial class AddTrain : Form
    {
        public Trains form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddTrain()
        {
            InitializeComponent();
        }

        private void facAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string id = tN.Text;
            string model = tM.Text;
            string date = tD.Value.ToShortDateString();
            string type;

            if (p.Checked == true)
                type = "Пригородный";
            else
                type = "Дальний";

            if (id != "" && model != "" && date != "")
            {
                string SQLcom = "SELECT count(*) FROM poezd WHERE id_poezd = @tN";
                con.Open();
                cmd.Parameters.AddWithValue("@tN", id);
                cmd.Connection = con;
                cmd.CommandText = SQLcom;
                long count = (long)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Такой поезд уже существует!", "Ошибка");
                    cmd.Parameters.Clear();
                    con.Close();
                }
                else
                {
                    string com = "INSERT INTO poezd (id_poezd, model, dateent, type, status) VALUES (@tN, @tM, @tD, @tT, @tS)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@tN", id);
                    cmd.Parameters.AddWithValue("@tM", model);
                    cmd.Parameters.AddWithValue("@tD", date);
                    cmd.Parameters.AddWithValue("@tT", type);
                    cmd.Parameters.AddWithValue("@tS", 0);
                    cmd.Connection = con;
                    cmd.CommandText = com;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    con.Close();
                    cmd.Parameters.Clear();
                    tN.Clear();
                    tM.Clear();
                    tD.Value = DateTime.Now;
                    p.Checked = true;
                    form.UpdateF();
                }
            }
            else MessageBox.Show("Не все поля записи заполнены", "Ошибка");
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.UpdateF();
            form.Show();
            Hide();
        }

        private void AddTrain_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.UpdateF();
            form.Show();
            Hide();
        }

        private void tN_MouseClick(object sender, MouseEventArgs e)
        {
            tN.SelectionStart = 0;
        }
    }
}

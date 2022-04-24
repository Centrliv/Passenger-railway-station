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
    public partial class AddFac : Form
    {
        public Facilities form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddFac()
        {
            InitializeComponent();
        }

        private void facAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string tit = facTitle.Text;
            decimal size = facSize.Value;
            string info = facInfo.Text;

            if ((tit != "") && (info != ""))
            {
                string SQLcom = "SELECT count(*) FROM lgoti WHERE title = @fT";
                con.Open();
                cmd.Parameters.AddWithValue("@fT", tit);
                cmd.Connection = con;
                cmd.CommandText = SQLcom;
                long count = (long)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Такая льгота уже существует!", "Ошибка");
                    cmd.Parameters.Clear();
                    con.Close();
                }
                else
                {
                    string com = "INSERT INTO lgoti (title, size, comment) VALUES (@fT, @fS, @fC)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@fT", tit);
                    cmd.Parameters.AddWithValue("@fS", size);
                    cmd.Parameters.AddWithValue("@fC", info);
                    cmd.Connection = con;
                    cmd.CommandText = com;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    con.Close();
                    cmd.Parameters.Clear();
                    facTitle.Clear();
                    facInfo.Clear();
                    facSize.Value = 0;
                }
            }
            else MessageBox.Show("Не все поля заполнены", "Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.UpdateF();
            form.Show();
            Hide();
        }

        private void AddFac_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.UpdateF();
            form.Show();
            Hide();
        }
    }
}

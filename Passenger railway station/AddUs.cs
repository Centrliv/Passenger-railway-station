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
    public partial class AddUs : Form
    {
        public UsManege form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddUs()
        {
            InitializeComponent();
        }

        private void AddUsr_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string n = uname.Text;
            string un = username.Text;
            string p = upass.Text;
            string g = ugroup.Text;
            
            if ((n != "") && (un != "") && (p != "") && (g != ""))
            {
                string SQLcom = "SELECT count(*) FROM users WHERE username = @uL";
                con.Open();
                cmd.Parameters.AddWithValue("@uL", un);
                cmd.Connection = con;
                cmd.CommandText = SQLcom;
                long count = (long) cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Пользователь с указанным логином уже существует!", "Ошибка");
                    cmd.Parameters.Clear();
                    con.Close();
                }                    
                else
                {                        
                    string com = "INSERT INTO users (name, username, pass, groupe) VALUES (@uN, @usN, @uP, @uG)";
                    con.Open();
                    cmd.Parameters.AddWithValue("@uN", n);
                    cmd.Parameters.AddWithValue("@usN", un);
                    cmd.Parameters.AddWithValue("@uP", p);
                    cmd.Parameters.AddWithValue("@uG", g);
                    cmd.Connection = con;
                    cmd.CommandText = com;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    con.Close();
                    uname.Clear();
                    username.Clear();
                    upass.Clear();
                    ugroup.SelectedIndex = -1;
                }
            }
            else MessageBox.Show("Не все поля заполнены", "Ошибка");
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.UpdateF();
            form.Show();
            Hide();
        }

        private void AddUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.UpdateF(); 
            form.Show();
            Hide();
        }
    }
}

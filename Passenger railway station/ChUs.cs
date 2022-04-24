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
    public partial class ChUs : Form
    {
        public UsManege form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public ChUs()
        {
            InitializeComponent();
        }

        private void ChUsr_Click(object sender, EventArgs e)
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
                if (un == DataBank.username)
                {
                    string com = string.Format("UPDATE users SET name = @uN, username = @usN, pass = @uP, groupe = @uG WHERE username = '{0}'", DataBank.username);
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
                }
                else
                {
                    string SQLcom = "SELECT count(*) FROM users WHERE username = @uL";
                    con.Open();
                    cmd.Parameters.AddWithValue("@uL", un);
                    cmd.Connection = con;
                    cmd.CommandText = SQLcom;
                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Пользователь с указанным логином уже существует!", "Ошибка");
                        cmd.Parameters.Clear();
                        con.Close();
                    }
                    else
                    {
                        string com = string.Format("UPDATE users SET name = @uN, username = @usN, pass = @uP, groupe = @uG WHERE username = '{0}'", DataBank.username);
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
                    }
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

        private void ChUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.UpdateF(); 
            form.Show();
            Hide();
        }

        private void ChUs_Load(object sender, EventArgs e)
        {
            if (DataBank.group == "Администратор")
                ugroup.SelectedIndex = 0;
            if (DataBank.group == "Оператор")
                ugroup.SelectedIndex = 1;
            if (DataBank.group == "Кассир")
                ugroup.SelectedIndex = 2;

            uname.Text = DataBank.name;
            username.Text = DataBank.username;
            upass.Text = DataBank.password;
        }
    }
}

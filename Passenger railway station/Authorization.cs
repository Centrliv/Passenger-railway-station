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
    public partial class Authorization : Form
    {
        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);

            string UsLog = log.Text;
            string UsPass = pas.Text;

            if ((UsLog != "") && (UsPass != ""))
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                con.Open();
                string SQLcom = "SELECT username, pass, groupe, name FROM users WHERE username = @uL AND pass = @uP";
                cmd.Parameters.AddWithValue("@uL", UsLog);
                cmd.Parameters.AddWithValue("@uP", UsPass);
                cmd.Connection = con;

                cmd.CommandText = SQLcom;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                MySqlDataReader reader = cmd.ExecuteReader();
                string group = "";
                while (reader.Read())
                {
                    group = reader[2].ToString();
                    DataBank.user = reader[3].ToString();
                }
                if ((table.Rows.Count > 0) && (group == "Администратор"))
                {
                    log.Clear();
                    pas.Clear();
                    cmd.Parameters.Clear();
                    AdminForm af = new AdminForm();
                    af.form = this;
                    af.Owner = this;
                    af.TopMost = true;
                    af.Show();
                    Hide();
                }
                else if ((table.Rows.Count > 0) && (group == "Оператор"))
                {
                    log.Clear();
                    pas.Clear();
                    cmd.Parameters.Clear();
                    OperatorForm of = new OperatorForm();
                    of.form = this;
                    of.Owner = this;
                    of.TopMost = true;
                    of.Show();
                    Hide();
                }
                else if ((table.Rows.Count > 0) && (group == "Кассир"))
                {
                    log.Clear();
                    pas.Clear();
                    cmd.Parameters.Clear();
                    KassirForm kf = new KassirForm();
                    kf.form = this;
                    kf.Owner = this;                    
                    kf.TopMost = true;
                    kf.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неправильное сочетание логин/пароль", "Ошибка авторизации");
                    cmd.Parameters.Clear();
                }
                con.Close();
            }
            else MessageBox.Show("Одно или несколько полей не заполнены", "Ошибка");            
        }
    }
}

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
    public partial class ChTrain : Form
    {
        public Trains form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public ChTrain()
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
                if (id == DataBank.sn)
                {
                    string com = string.Format("UPDATE poezd SET model = @tM, dateent = @tD, type = @tT WHERE id_poezd = '{0}'", DataBank.sn);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tM", model);
                    cmd.Parameters.AddWithValue("@tD", date);
                    cmd.Parameters.AddWithValue("@tT", type);
                    cmd.Connection = con;
                    cmd.CommandText = com;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    con.Close();
                    cmd.Parameters.Clear();
                    form.UpdateF();
                }
                else
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
                        string com = string.Format("UPDATE poezd SET id_poezd = @tN, model = @tM, dateent = @tD, type = @tT WHERE id_poezd = '{0}'", DataBank.sn);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tN", id);
                        cmd.Parameters.AddWithValue("@tM", model);
                        cmd.Parameters.AddWithValue("@tD", date);
                        cmd.Parameters.AddWithValue("@tT", type);
                        cmd.Connection = con;
                        cmd.CommandText = com;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        con.Close();
                        cmd.Parameters.Clear();
                        DataBank.sn = id;
                        form.UpdateF();
                    }
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

        private void ChTrain_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            tN.Text = DataBank.sn;
            tM.Text = DataBank.model;
            tD.Text = DataBank.date;
            if (DataBank.typeT == "Пригородный")
                p.Checked = true;
            else
                d.Checked = true;

            string SQLcom = "SELECT count(*) FROM vagony WHERE id_poezd = @tN";
            con.Open();
            cmd.Parameters.AddWithValue("@tN", DataBank.sn);
            cmd.Connection = con;
            cmd.CommandText = SQLcom;
            long count = (long)cmd.ExecuteScalar();
            if (count > 0)
            {
                p.Enabled = false;
                d.Enabled = false;
                cmd.Parameters.Clear();
                con.Close();
            }
        }

        private void tN_MouseClick(object sender, MouseEventArgs e)
        {
            tN.SelectionStart = 0;
        }
    }
}

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
    public partial class ChVan : Form
    {
        public Vans form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public ChVan()
        {
            InitializeComponent();
        }

        private void vCl_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddVan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void AddVan_Load(object sender, EventArgs e)
        {
            if (DataBank.typeT == "Пригородный")
            {
                type.Items.Remove("Плацкарт");
                type.Items.Remove("Купе");
                type.Items.Remove("СВ (люкс)");
            }
            type.Text = DataBank.typeV;
            id_v.Text = Convert.ToString(DataBank.idV);
            seats.Text = Convert.ToString(DataBank.kolV);
        }

        private void vCh_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string id = Convert.ToString(id_v.Text);
            string tp = type.Text;
            int seat = Convert.ToInt32(seats.Text);

            if ((id != "") && (tp != ""))
            {
                if (id == Convert.ToString(DataBank.idV))
                {
                    string com = string.Format("UPDATE vagony SET id_vagon = @vID, type = @vT, kol = @vS WHERE id_vagon = '{0}'", DataBank.idV);
                    con.Open();
                    cmd.Parameters.AddWithValue("@vID", id);
                    cmd.Parameters.AddWithValue("@vT", tp);
                    cmd.Parameters.AddWithValue("@vS", seat);
                    cmd.Connection = con;
                    cmd.CommandText = com;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    con.Close();
                    cmd.Parameters.Clear();
                    form.Vans_Load(sender, e);
                }
                else
                {
                    string SQLcom = "SELECT count(*) FROM vagony WHERE id_vagon = @vID";
                    con.Open();
                    cmd.Parameters.AddWithValue("@vID", id);
                    cmd.Connection = con;
                    cmd.CommandText = SQLcom;
                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Вагон с таким номером уже существует!", "Ошибка");
                        cmd.Parameters.Clear();
                        con.Close();
                    }
                    else
                    {
                        string com = string.Format("UPDATE vagony SET id_vagon = @vID, type = @vT, kol = @vS WHERE id_vagon = '{0}'", DataBank.idV);
                        con.Open();
                        cmd.Parameters.AddWithValue("@vID", id);
                        cmd.Parameters.AddWithValue("@vT", tp);
                        cmd.Parameters.AddWithValue("@vS", seat);
                        cmd.Connection = con;
                        cmd.CommandText = com;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        con.Close();
                        cmd.Parameters.Clear();
                        form.Vans_Load(sender, e);
                        DataBank.idV = Convert.ToInt32(id);
                    }
                }
            }
            else MessageBox.Show("Не все поля заполнены", "Ошибка");
        }
        private void type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (type.Text == "Сидяий" && DataBank.typeT == "Пригородный")
                seats.Text = "100";
            else
                seats.Text = "60";
            if (type.Text == "Плацкарт")
                seats.Text = "54";
            if (type.Text == "Купе")
                seats.Text = "36";
            if (type.Text == "СВ (люкс)")
                seats.Text = "18";
        }

        private void id_v_MouseClick(object sender, MouseEventArgs e)
        {
            id_v.SelectionStart = 0;
        }
    }
}

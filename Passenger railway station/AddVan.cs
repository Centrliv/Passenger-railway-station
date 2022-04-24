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
    public partial class AddVan : Form
    {
        public Vans form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AddVan()
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
        }

        private void vAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string id = id_v.Text;
            string tp = type.Text;
            string seat = seats.Text;

            string SQcom = "SELECT count(*) FROM vagony WHERE id_poezd = @pID";
            con.Open();
            cmd.Parameters.AddWithValue("@pID", DataBank.sn);
            cmd.Connection = con;
            cmd.CommandText = SQcom;
            long coun = (long)cmd.ExecuteScalar();
            if (DataBank.typeT == "Пригородный" && coun > 11)
            {
                MessageBox.Show("Достигнуто предельное количество вагонов в данном составе!", "Ошибка");
                cmd.Parameters.Clear();
                con.Close();
            }
            else if (DataBank.typeT == "Дальний" && coun > 14)
            {
                MessageBox.Show("Достигнуто предельное количество вагонов в данном составе!", "Ошибка");
                cmd.Parameters.Clear();
                con.Close();
            }
            else
            {
                if ((id != "") && (tp != ""))
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
                        string com = "INSERT INTO vagony (id_vagon, type, kol, id_poezd) VALUES (@vID, @vT, @vS, @pID)";
                        con.Open();
                        cmd.Parameters.AddWithValue("@vID", id);
                        cmd.Parameters.AddWithValue("@vT", tp);
                        cmd.Parameters.AddWithValue("@vS", seat);
                        cmd.Parameters.AddWithValue("@pID", DataBank.sn);
                        cmd.Connection = con;
                        cmd.CommandText = com;
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        con.Close();
                        cmd.Parameters.Clear();
                        id_v.Clear();
                        type.SelectedIndex = -1;
                        seats.Clear();
                        form.Vans_Load(sender, e);

                        string com2 = "INSERT INTO mesta (num, status, id_vagon) VALUES (@mN, @mS, @vID)";
                        for (int i = 1; i < Convert.ToUInt32(seat) + 1; i++)
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@mN", i);
                            cmd.Parameters.AddWithValue("@mS", 0);
                            cmd.Parameters.AddWithValue("@vID", id);
                            cmd.Connection = con;
                            cmd.CommandText = com2;
                            cmd.ExecuteNonQuery();                            
                            con.Close();
                            cmd.Parameters.Clear();
                            con.Close();
                        }
                    }
                }
                else MessageBox.Show("Не все поля заполнены", "Ошибка");
            }
        }
        private void type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (type.Text == "Сидячий" && DataBank.typeT == "Пригородный")
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

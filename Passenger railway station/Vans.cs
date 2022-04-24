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
    public partial class Vans : Form
    {
        public Trains form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public void UpdateF()
        {
            this.vagonyTableAdapter.Fill(this.rpsDataSet.vagony);
            this.Refresh();
            if (vansTable.Rows.Count == 0)
            {
                vCh.Enabled = false;
                vDel.Enabled = false;
            }
            else
            {
                vCh.Enabled = true;
                vDel.Enabled = true;
            }
        }

        public Vans()
        {
            InitializeComponent();
        }

        public void Vans_Load(object sender, EventArgs e)
        {
            if (DataBank.typeT == "Дальний")
                label.Text = "Состав вагонов для поезда " + DataBank.sn;
            else
                label.Text = "Состав вагонов для электрички " + DataBank.sn;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            BindingSource bindingSorce = new BindingSource();
            MySqlConnection con = new MySqlConnection(conString);
            cmd.Connection = con;
            string sql = string.Format("SELECT * FROM vagony WHERE id_poezd = '{0}'", DataBank.sn);
            cmd.CommandText = sql;
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSorce.DataSource = dataset.Tables[0];
            vansTable.DataSource = bindingSorce;

            UpdateF();
        }

        private void vDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранный вагон?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            if (result == DialogResult.Yes)
            {
                string del = vansTable.CurrentRow.Cells[0].Value.ToString();
                MySqlConnection con = new MySqlConnection(conString);
                cmd.Connection = con;

                cmd.CommandText = string.Format("DELETE FROM vagony WHERE id_vagon = '{0}'", del);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Vans_Load(sender, e);
            }
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void Vans_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }

        private void vAdd_Click(object sender, EventArgs e)
        {
            AddVan av = new AddVan();
            av.form = this;
            av.Owner = this;
            av.TopMost = true;
            av.ShowDialog();
        }

        private void vCh_Click(object sender, EventArgs e)
        {
            DataBank.idV = int.Parse(vansTable.CurrentRow.Cells[0].Value.ToString());
            DataBank.typeV = vansTable.CurrentRow.Cells[1].Value.ToString();
            DataBank.kolV = int.Parse(vansTable.CurrentRow.Cells[2].Value.ToString());
            ChVan av = new ChVan();
            av.form = this;
            av.Owner = this;
            av.TopMost = true;
            av.ShowDialog();
        }
    }
}

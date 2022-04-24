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
    public partial class Stations : Form
    {
        public Routes form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public void UpdateF()
        {
            this.stationsTableAdapter.Fill(this.rpsDataSet.stations);

            if (statTable.Rows.Count == 0)
            {
                sCh.Enabled = false;
                sDel.Enabled = false;
            }
            else
            {
                sCh.Enabled = true;
                sDel.Enabled = true;
            }
        }

        public Stations()
        {
            InitializeComponent();
        }

        public void Stations_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            BindingSource bindingSorce = new BindingSource();
            MySqlConnection con = new MySqlConnection(conString);
            cmd.Connection = con;
            string sql = string.Format("SELECT * FROM stations WHERE name_route = '{0}'", DataBank.nameR);
            cmd.CommandText = sql;
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSorce.DataSource = dataset.Tables[0];
            statTable.DataSource = bindingSorce;

            UpdateF();
            label2.Text = DataBank.nameR;
            if (DataBank.typeR == "Пригородный")
            {
                cenaplacDataGridViewTextBoxColumn.Visible = false;
                cenakupeDataGridViewTextBoxColumn.Visible = false;
                cenasvDataGridViewTextBoxColumn.Visible = false;
            }
        }

        private void sCl_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void sAdd_Click(object sender, EventArgs e)
        {
            AddSt sa = new AddSt();
            sa.form = this;
            sa.Owner = this;
            sa.TopMost = true;
            sa.ShowDialog();
        }

        private void Stations_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }

        private void sDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранную станцию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            if (result == DialogResult.Yes)
            {
                string del = statTable.CurrentRow.Cells[1].Value.ToString();
                MySqlConnection con = new MySqlConnection(conString);
                cmd.Connection = con;

                cmd.CommandText = string.Format("DELETE FROM stations WHERE name = '{0}' AND name_route = '{1}'", del, DataBank.nameR);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Stations_Load(sender, e);
            }
        }

        private void sCh_Click(object sender, EventArgs e)
        {
            DataBank.nameS = statTable.CurrentRow.Cells[1].Value.ToString();
            DataBank.priceS = decimal.Parse(statTable.CurrentRow.Cells[2].Value.ToString());
            DataBank.priceP = decimal.Parse(statTable.CurrentRow.Cells[3].Value.ToString());
            DataBank.priceK = decimal.Parse(statTable.CurrentRow.Cells[4].Value.ToString());
            DataBank.priceSV = decimal.Parse(statTable.CurrentRow.Cells[5].Value.ToString());
            DataBank.nameR = statTable.CurrentRow.Cells[6].Value.ToString();
            ChSt cs = new ChSt();
            cs.form = this;
            cs.Owner = this;
            cs.TopMost = true;
            cs.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stationsTableAdapter.FillBy(this.rpsDataSet.stations);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

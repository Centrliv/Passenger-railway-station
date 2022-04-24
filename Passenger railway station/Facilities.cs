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
    public partial class Facilities : Form
    {
        public AdminForm form;

        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public void UpdateF()
        {
            this.lgotiTableAdapter.Fill(this.rpsDataSet.lgoti);

            if (facTable.Rows.Count == 0)
            {
                facCh.Enabled = false;
                facDel.Enabled = false;
            }
            else
            {
                facCh.Enabled = true;
                facDel.Enabled = true;
            }
        }

         public void DeleteS()
        {
            DialogResult result = MessageBox.Show("Удалить выбранную льготу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            if (result == DialogResult.Yes)
            {
                string del = facTable.CurrentRow.Cells[0].Value.ToString();
                MySqlConnection con = new MySqlConnection(conString);
                cmd.Connection = con;

                cmd.CommandText = string.Format("DELETE FROM lgoti WHERE title ='{0}'", del);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                UpdateF();
            }
         }

        public Facilities()
        {
            InitializeComponent();
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            UpdateF();
        }

        private void facAdd_Click(object sender, EventArgs e)
        {
            AddFac af = new AddFac();
            af.form = this;
            af.Owner = this;
            af.TopMost = true;
            af.Show();
            Hide();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void Facilities_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }

        public void facDel_Click(object sender, EventArgs e)
        {
            DeleteS();
        }

        private void facCh_Click(object sender, EventArgs e)
        {
            DataBank.title = facTable.CurrentRow.Cells[0].Value.ToString();
            DataBank.size = decimal.Parse(facTable.CurrentRow.Cells[1].Value.ToString());
            DataBank.info = facTable.CurrentRow.Cells[2].Value.ToString();
            ChFac cf = new ChFac();
            cf.form = this;
            cf.Owner = this;
            cf.TopMost = true;
            cf.Show();
            Hide();
        }

        private void facTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeleteS();
        }
    }
}

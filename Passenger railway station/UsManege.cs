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
    public partial class UsManege : Form
    {
        static string conString = "User Id=root;Password=123456;Host=localhost;Database=rail_pass_station;Unicode=True;Persist Security Info=True";
        MySqlCommand cmd = new MySqlCommand();

        public AdminForm form;

        public UsManege()
        {
            InitializeComponent();
        }
        
        public void UpdateF()
        {
            this.usersTableAdapter.Fill(this.rpsDataSet.users);
        }

        public void CellCheck()
        {
            string check = UserTable.CurrentRow.Cells[1].Value.ToString();
            if (check == "Admin")
            {
                usDel.Enabled = false;
                usCh.Enabled = false;
            }
            else
            {
                usCh.Enabled = true;
                usDel.Enabled = true;
            }
        }

        public void UsManege_Load(object sender, EventArgs e)
        {            
            this.usersTableAdapter.Fill(this.rpsDataSet.users);
            CellCheck();
        }

        private void usAdd_Click(object sender, EventArgs e)
        {
            AddUs au = new AddUs();
            au.form = this;
            au.Owner = this;
            au.TopMost = true;
            au.Show();
            Hide();
        }

        private void usCh_Click(object sender, EventArgs e)
        {
            DataBank.name = UserTable.CurrentRow.Cells[0].Value.ToString();
            DataBank.username = UserTable.CurrentRow.Cells[1].Value.ToString();
            DataBank.password = UserTable.CurrentRow.Cells[2].Value.ToString();
            DataBank.group = UserTable.CurrentRow.Cells[3].Value.ToString();
            ChUs cu = new ChUs();
            cu.form = this;
            cu.Owner = this;
            cu.TopMost = true;
            cu.Show();
            Hide();
        }

        private void cl_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void UsManege_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }

        private void usDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранного пользователя?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.TopMost = true;
            if (result == DialogResult.Yes)
            {
                string del = UserTable.CurrentRow.Cells[1].Value.ToString();
                MySqlConnection con = new MySqlConnection(conString);
                cmd.Connection = con;

                cmd.CommandText = string.Format("DELETE FROM users WHERE username ='{0}'", del);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                UpdateF();
            }
        }

        private void UserTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellCheck();
        }

        private void UserTable_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CellCheck();
        }

        private void UserTable_Sorted(object sender, EventArgs e)
        {
            CellCheck();
        }
    }
}

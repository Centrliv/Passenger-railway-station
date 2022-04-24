namespace Passenger_railway_station
{
    partial class UsManege
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.usAdd = new System.Windows.Forms.Button();
            this.usDel = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.UserTable = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.usersTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.usersTableAdapter();
            this.usCh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usAdd
            // 
            this.usAdd.Location = new System.Drawing.Point(12, 168);
            this.usAdd.Name = "usAdd";
            this.usAdd.Size = new System.Drawing.Size(103, 31);
            this.usAdd.TabIndex = 1;
            this.usAdd.Text = "Добавить";
            this.usAdd.UseVisualStyleBackColor = true;
            this.usAdd.Click += new System.EventHandler(this.usAdd_Click);
            // 
            // usDel
            // 
            this.usDel.Location = new System.Drawing.Point(230, 168);
            this.usDel.Name = "usDel";
            this.usDel.Size = new System.Drawing.Size(103, 31);
            this.usDel.TabIndex = 3;
            this.usDel.Text = "Удалить";
            this.usDel.UseVisualStyleBackColor = true;
            this.usDel.Click += new System.EventHandler(this.usDel_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(404, 168);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(103, 31);
            this.cl.TabIndex = 4;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // UserTable
            // 
            this.UserTable.AllowUserToAddRows = false;
            this.UserTable.AutoGenerateColumns = false;
            this.UserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.groupeDataGridViewTextBoxColumn});
            this.UserTable.DataSource = this.usersBindingSource;
            this.UserTable.Location = new System.Drawing.Point(12, 7);
            this.UserTable.MultiSelect = false;
            this.UserTable.Name = "UserTable";
            this.UserTable.ReadOnly = true;
            this.UserTable.Size = new System.Drawing.Size(495, 155);
            this.UserTable.TabIndex = 5;
            this.UserTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserTable_CellClick);
            this.UserTable.Sorted += new System.EventHandler(this.UserTable_Sorted);
            this.UserTable.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.UserTable_UserDeletedRow);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 112.3096F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Фамилия И. О.";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 112.3096F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.FillWeight = 112.3096F;
            this.passDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupeDataGridViewTextBoxColumn
            // 
            this.groupeDataGridViewTextBoxColumn.DataPropertyName = "groupe";
            this.groupeDataGridViewTextBoxColumn.FillWeight = 112.3096F;
            this.groupeDataGridViewTextBoxColumn.HeaderText = "Права";
            this.groupeDataGridViewTextBoxColumn.Name = "groupeDataGridViewTextBoxColumn";
            this.groupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usCh
            // 
            this.usCh.Location = new System.Drawing.Point(121, 168);
            this.usCh.Name = "usCh";
            this.usCh.Size = new System.Drawing.Size(103, 31);
            this.usCh.TabIndex = 2;
            this.usCh.Text = "Изменить";
            this.usCh.UseVisualStyleBackColor = true;
            this.usCh.Click += new System.EventHandler(this.usCh_Click);
            // 
            // UsManege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 205);
            this.Controls.Add(this.UserTable);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.usDel);
            this.Controls.Add(this.usCh);
            this.Controls.Add(this.usAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsManege";
            this.Text = "Управление операторами";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsManege_FormClosed);
            this.Load += new System.EventHandler(this.UsManege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usAdd;
        private System.Windows.Forms.Button usDel;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView UserTable;
        public rpsDataSet rpsDataSet;
        public System.Windows.Forms.BindingSource usersBindingSource;
        public rpsDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button usCh;
    }
}
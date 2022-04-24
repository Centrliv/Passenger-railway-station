namespace Passenger_railway_station
{
    partial class Stations
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
            this.statTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sCl = new System.Windows.Forms.Button();
            this.sDel = new System.Windows.Forms.Button();
            this.sCh = new System.Windows.Forms.Button();
            this.sAdd = new System.Windows.Forms.Button();
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.stationsTableAdapter();
            this.idstationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaplacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenakupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenasvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namerouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statTable
            // 
            this.statTable.AllowUserToAddRows = false;
            this.statTable.AllowUserToDeleteRows = false;
            this.statTable.AutoGenerateColumns = false;
            this.statTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cenasidDataGridViewTextBoxColumn,
            this.cenaplacDataGridViewTextBoxColumn,
            this.cenakupeDataGridViewTextBoxColumn,
            this.cenasvDataGridViewTextBoxColumn,
            this.namerouteDataGridViewTextBoxColumn});
            this.statTable.DataSource = this.stationsBindingSource;
            this.statTable.Location = new System.Drawing.Point(12, 58);
            this.statTable.MultiSelect = false;
            this.statTable.Name = "statTable";
            this.statTable.ReadOnly = true;
            this.statTable.Size = new System.Drawing.Size(587, 209);
            this.statTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Остновки для маршрута";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 23);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sCl
            // 
            this.sCl.Location = new System.Drawing.Point(503, 273);
            this.sCl.Name = "sCl";
            this.sCl.Size = new System.Drawing.Size(96, 29);
            this.sCl.TabIndex = 9;
            this.sCl.Text = "Закрыть";
            this.sCl.UseVisualStyleBackColor = true;
            this.sCl.Click += new System.EventHandler(this.sCl_Click);
            // 
            // sDel
            // 
            this.sDel.Location = new System.Drawing.Point(216, 273);
            this.sDel.Name = "sDel";
            this.sDel.Size = new System.Drawing.Size(96, 29);
            this.sDel.TabIndex = 8;
            this.sDel.Text = "Удалить";
            this.sDel.UseVisualStyleBackColor = true;
            this.sDel.Click += new System.EventHandler(this.sDel_Click);
            // 
            // sCh
            // 
            this.sCh.Location = new System.Drawing.Point(114, 273);
            this.sCh.Name = "sCh";
            this.sCh.Size = new System.Drawing.Size(96, 29);
            this.sCh.TabIndex = 7;
            this.sCh.Text = "Изменить";
            this.sCh.UseVisualStyleBackColor = true;
            this.sCh.Click += new System.EventHandler(this.sCh_Click);
            // 
            // sAdd
            // 
            this.sAdd.Location = new System.Drawing.Point(12, 273);
            this.sAdd.Name = "sAdd";
            this.sAdd.Size = new System.Drawing.Size(96, 29);
            this.sAdd.TabIndex = 6;
            this.sAdd.Text = "Добавить";
            this.sAdd.UseVisualStyleBackColor = true;
            this.sAdd.Click += new System.EventHandler(this.sAdd_Click);
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "stations";
            this.stationsBindingSource.DataSource = this.rpsDataSet;
            // 
            // stationsTableAdapter
            // 
            this.stationsTableAdapter.ClearBeforeFill = true;
            // 
            // idstationDataGridViewTextBoxColumn
            // 
            this.idstationDataGridViewTextBoxColumn.DataPropertyName = "id_station";
            this.idstationDataGridViewTextBoxColumn.HeaderText = "id_station";
            this.idstationDataGridViewTextBoxColumn.Name = "idstationDataGridViewTextBoxColumn";
            this.idstationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstationDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenasidDataGridViewTextBoxColumn
            // 
            this.cenasidDataGridViewTextBoxColumn.DataPropertyName = "cena_sid";
            this.cenasidDataGridViewTextBoxColumn.HeaderText = "Цена сидячий";
            this.cenasidDataGridViewTextBoxColumn.Name = "cenasidDataGridViewTextBoxColumn";
            this.cenasidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaplacDataGridViewTextBoxColumn
            // 
            this.cenaplacDataGridViewTextBoxColumn.DataPropertyName = "cena_plac";
            this.cenaplacDataGridViewTextBoxColumn.HeaderText = "Цена плацкарт";
            this.cenaplacDataGridViewTextBoxColumn.Name = "cenaplacDataGridViewTextBoxColumn";
            this.cenaplacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenakupeDataGridViewTextBoxColumn
            // 
            this.cenakupeDataGridViewTextBoxColumn.DataPropertyName = "cena_kupe";
            this.cenakupeDataGridViewTextBoxColumn.HeaderText = "Цена купе";
            this.cenakupeDataGridViewTextBoxColumn.Name = "cenakupeDataGridViewTextBoxColumn";
            this.cenakupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenasvDataGridViewTextBoxColumn
            // 
            this.cenasvDataGridViewTextBoxColumn.DataPropertyName = "cena_sv";
            this.cenasvDataGridViewTextBoxColumn.HeaderText = "Цена СВ (люкс)";
            this.cenasvDataGridViewTextBoxColumn.Name = "cenasvDataGridViewTextBoxColumn";
            this.cenasvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namerouteDataGridViewTextBoxColumn
            // 
            this.namerouteDataGridViewTextBoxColumn.DataPropertyName = "name_route";
            this.namerouteDataGridViewTextBoxColumn.HeaderText = "name_route";
            this.namerouteDataGridViewTextBoxColumn.Name = "namerouteDataGridViewTextBoxColumn";
            this.namerouteDataGridViewTextBoxColumn.ReadOnly = true;
            this.namerouteDataGridViewTextBoxColumn.Visible = false;
            // 
            // Stations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 314);
            this.Controls.Add(this.sCl);
            this.Controls.Add(this.sDel);
            this.Controls.Add(this.sCh);
            this.Controls.Add(this.sAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Stations";
            this.Text = "Остановки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stations_FormClosed);
            this.Load += new System.EventHandler(this.Stations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sCl;
        private System.Windows.Forms.Button sDel;
        private System.Windows.Forms.Button sCh;
        private System.Windows.Forms.Button sAdd;
        public System.Windows.Forms.DataGridView statTable;
        public rpsDataSet rpsDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaplacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenakupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenasvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namerouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private rpsDataSetTableAdapters.stationsTableAdapter stationsTableAdapter;
    }
}
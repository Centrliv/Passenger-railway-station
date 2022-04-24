namespace Passenger_railway_station
{
    partial class Routes
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
            this.rAdd = new System.Windows.Forms.Button();
            this.rCh = new System.Windows.Forms.Button();
            this.rDel = new System.Windows.Forms.Button();
            this.rCl = new System.Windows.Forms.Button();
            this.routesTable = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.routesTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.routesTableAdapter();
            this.Stations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.routesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rAdd
            // 
            this.rAdd.Location = new System.Drawing.Point(444, 12);
            this.rAdd.Name = "rAdd";
            this.rAdd.Size = new System.Drawing.Size(96, 29);
            this.rAdd.TabIndex = 2;
            this.rAdd.Text = "Добавить";
            this.rAdd.UseVisualStyleBackColor = true;
            this.rAdd.Click += new System.EventHandler(this.rAdd_Click);
            // 
            // rCh
            // 
            this.rCh.Location = new System.Drawing.Point(444, 47);
            this.rCh.Name = "rCh";
            this.rCh.Size = new System.Drawing.Size(96, 29);
            this.rCh.TabIndex = 3;
            this.rCh.Text = "Изменить";
            this.rCh.UseVisualStyleBackColor = true;
            this.rCh.Click += new System.EventHandler(this.rCh_Click);
            // 
            // rDel
            // 
            this.rDel.Location = new System.Drawing.Point(444, 82);
            this.rDel.Name = "rDel";
            this.rDel.Size = new System.Drawing.Size(96, 29);
            this.rDel.TabIndex = 4;
            this.rDel.Text = "Удалить";
            this.rDel.UseVisualStyleBackColor = true;
            this.rDel.Click += new System.EventHandler(this.rDel_Click);
            // 
            // rCl
            // 
            this.rCl.Location = new System.Drawing.Point(444, 307);
            this.rCl.Name = "rCl";
            this.rCl.Size = new System.Drawing.Size(96, 29);
            this.rCl.TabIndex = 5;
            this.rCl.Text = "Закрыть";
            this.rCl.UseVisualStyleBackColor = true;
            this.rCl.Click += new System.EventHandler(this.rCl_Click);
            // 
            // routesTable
            // 
            this.routesTable.AllowUserToAddRows = false;
            this.routesTable.AllowUserToDeleteRows = false;
            this.routesTable.AutoGenerateColumns = false;
            this.routesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.routesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.routesTable.DataSource = this.routesBindingSource;
            this.routesTable.Location = new System.Drawing.Point(12, 12);
            this.routesTable.Name = "routesTable";
            this.routesTable.ReadOnly = true;
            this.routesTable.Size = new System.Drawing.Size(426, 324);
            this.routesTable.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "routes";
            this.routesBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // Stations
            // 
            this.Stations.Location = new System.Drawing.Point(444, 188);
            this.Stations.Name = "Stations";
            this.Stations.Size = new System.Drawing.Size(96, 29);
            this.Stations.TabIndex = 9;
            this.Stations.Text = "Станции";
            this.Stations.UseVisualStyleBackColor = true;
            this.Stations.Click += new System.EventHandler(this.Stations_Click);
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 348);
            this.Controls.Add(this.Stations);
            this.Controls.Add(this.routesTable);
            this.Controls.Add(this.rCl);
            this.Controls.Add(this.rDel);
            this.Controls.Add(this.rCh);
            this.Controls.Add(this.rAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Routes";
            this.Text = "Маршруты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Routes_FormClosed);
            this.Load += new System.EventHandler(this.Stations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rAdd;
        private System.Windows.Forms.Button rCh;
        private System.Windows.Forms.Button rDel;
        private System.Windows.Forms.Button rCl;
        private System.Windows.Forms.DataGridView routesTable;
        private rpsDataSet rpsDataSet;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private rpsDataSetTableAdapters.routesTableAdapter routesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Stations;
    }
}
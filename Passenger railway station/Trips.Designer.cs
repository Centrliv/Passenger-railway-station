namespace Passenger_railway_station
{
    partial class Trips
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tripTable = new System.Windows.Forms.DataGridView();
            this.idreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpoezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnaznDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestobshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestsvobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.censidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenplacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cen_kupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.censvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeotprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimepribDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reisyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.tCl = new System.Windows.Forms.Button();
            this.tDel = new System.Windows.Forms.Button();
            this.tAdd = new System.Windows.Forms.Button();
            this.reisyTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.reisyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reisyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tripTable
            // 
            this.tripTable.AllowUserToAddRows = false;
            this.tripTable.AllowUserToDeleteRows = false;
            this.tripTable.AutoGenerateColumns = false;
            this.tripTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tripTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tripTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreisDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.rnameDataGridViewTextBoxColumn,
            this.idpoezdDataGridViewTextBoxColumn,
            this.stotprDataGridViewTextBoxColumn,
            this.stnaznDataGridViewTextBoxColumn,
            this.mestobshDataGridViewTextBoxColumn,
            this.mestsvobDataGridViewTextBoxColumn,
            this.censidDataGridViewTextBoxColumn,
            this.cenplacDataGridViewTextBoxColumn,
            this.cen_kupe,
            this.censvDataGridViewTextBoxColumn,
            this.datetimeotprDataGridViewTextBoxColumn,
            this.datetimepribDataGridViewTextBoxColumn});
            this.tripTable.DataSource = this.reisyBindingSource;
            this.tripTable.Location = new System.Drawing.Point(13, 12);
            this.tripTable.Name = "tripTable";
            this.tripTable.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tripTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tripTable.Size = new System.Drawing.Size(1243, 441);
            this.tripTable.TabIndex = 0;
            // 
            // idreisDataGridViewTextBoxColumn
            // 
            this.idreisDataGridViewTextBoxColumn.DataPropertyName = "id_reis";
            this.idreisDataGridViewTextBoxColumn.HeaderText = "Рейс";
            this.idreisDataGridViewTextBoxColumn.Name = "idreisDataGridViewTextBoxColumn";
            this.idreisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип следования";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rnameDataGridViewTextBoxColumn
            // 
            this.rnameDataGridViewTextBoxColumn.DataPropertyName = "r_name";
            this.rnameDataGridViewTextBoxColumn.HeaderText = "Маршрут";
            this.rnameDataGridViewTextBoxColumn.Name = "rnameDataGridViewTextBoxColumn";
            this.rnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpoezdDataGridViewTextBoxColumn
            // 
            this.idpoezdDataGridViewTextBoxColumn.DataPropertyName = "id_poezd";
            this.idpoezdDataGridViewTextBoxColumn.HeaderText = "Поезд";
            this.idpoezdDataGridViewTextBoxColumn.Name = "idpoezdDataGridViewTextBoxColumn";
            this.idpoezdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stotprDataGridViewTextBoxColumn
            // 
            this.stotprDataGridViewTextBoxColumn.DataPropertyName = "st_otpr";
            this.stotprDataGridViewTextBoxColumn.HeaderText = "Станция отправления";
            this.stotprDataGridViewTextBoxColumn.Name = "stotprDataGridViewTextBoxColumn";
            this.stotprDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stnaznDataGridViewTextBoxColumn
            // 
            this.stnaznDataGridViewTextBoxColumn.DataPropertyName = "st_nazn";
            this.stnaznDataGridViewTextBoxColumn.HeaderText = "Станция назначения";
            this.stnaznDataGridViewTextBoxColumn.Name = "stnaznDataGridViewTextBoxColumn";
            this.stnaznDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mestobshDataGridViewTextBoxColumn
            // 
            this.mestobshDataGridViewTextBoxColumn.DataPropertyName = "mest_obsh";
            this.mestobshDataGridViewTextBoxColumn.HeaderText = "Мест всего";
            this.mestobshDataGridViewTextBoxColumn.Name = "mestobshDataGridViewTextBoxColumn";
            this.mestobshDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mestsvobDataGridViewTextBoxColumn
            // 
            this.mestsvobDataGridViewTextBoxColumn.DataPropertyName = "mest_svob";
            this.mestsvobDataGridViewTextBoxColumn.HeaderText = "Мест свободно";
            this.mestsvobDataGridViewTextBoxColumn.Name = "mestsvobDataGridViewTextBoxColumn";
            this.mestsvobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // censidDataGridViewTextBoxColumn
            // 
            this.censidDataGridViewTextBoxColumn.DataPropertyName = "cen_sid";
            this.censidDataGridViewTextBoxColumn.HeaderText = "Цена сидячий";
            this.censidDataGridViewTextBoxColumn.Name = "censidDataGridViewTextBoxColumn";
            this.censidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenplacDataGridViewTextBoxColumn
            // 
            this.cenplacDataGridViewTextBoxColumn.DataPropertyName = "cen_plac";
            this.cenplacDataGridViewTextBoxColumn.HeaderText = "Цена плацкарт";
            this.cenplacDataGridViewTextBoxColumn.Name = "cenplacDataGridViewTextBoxColumn";
            this.cenplacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cen_kupe
            // 
            this.cen_kupe.DataPropertyName = "cen_kupe";
            this.cen_kupe.HeaderText = "Цена купе";
            this.cen_kupe.Name = "cen_kupe";
            this.cen_kupe.ReadOnly = true;
            // 
            // censvDataGridViewTextBoxColumn
            // 
            this.censvDataGridViewTextBoxColumn.DataPropertyName = "cen_sv";
            this.censvDataGridViewTextBoxColumn.HeaderText = "Цена СВ (люкс)";
            this.censvDataGridViewTextBoxColumn.Name = "censvDataGridViewTextBoxColumn";
            this.censvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeotprDataGridViewTextBoxColumn
            // 
            this.datetimeotprDataGridViewTextBoxColumn.DataPropertyName = "date_time_otpr";
            this.datetimeotprDataGridViewTextBoxColumn.HeaderText = "Дата, время отправления";
            this.datetimeotprDataGridViewTextBoxColumn.Name = "datetimeotprDataGridViewTextBoxColumn";
            this.datetimeotprDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimepribDataGridViewTextBoxColumn
            // 
            this.datetimepribDataGridViewTextBoxColumn.DataPropertyName = "date_time_prib";
            this.datetimepribDataGridViewTextBoxColumn.HeaderText = "Дата, время прибытия";
            this.datetimepribDataGridViewTextBoxColumn.Name = "datetimepribDataGridViewTextBoxColumn";
            this.datetimepribDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reisyBindingSource
            // 
            this.reisyBindingSource.DataMember = "reisy";
            this.reisyBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCl
            // 
            this.tCl.Location = new System.Drawing.Point(1158, 459);
            this.tCl.Name = "tCl";
            this.tCl.Size = new System.Drawing.Size(96, 29);
            this.tCl.TabIndex = 9;
            this.tCl.Text = "Закрыть";
            this.tCl.UseVisualStyleBackColor = true;
            this.tCl.Click += new System.EventHandler(this.tCl_Click);
            // 
            // tDel
            // 
            this.tDel.Location = new System.Drawing.Point(115, 459);
            this.tDel.Name = "tDel";
            this.tDel.Size = new System.Drawing.Size(96, 29);
            this.tDel.TabIndex = 8;
            this.tDel.Text = "Удалить";
            this.tDel.UseVisualStyleBackColor = true;
            this.tDel.Click += new System.EventHandler(this.tDel_Click);
            // 
            // tAdd
            // 
            this.tAdd.Location = new System.Drawing.Point(13, 459);
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(96, 29);
            this.tAdd.TabIndex = 6;
            this.tAdd.Text = "Добавить";
            this.tAdd.UseVisualStyleBackColor = true;
            this.tAdd.Click += new System.EventHandler(this.tAdd_Click);
            // 
            // reisyTableAdapter
            // 
            this.reisyTableAdapter.ClearBeforeFill = true;
            // 
            // Trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 508);
            this.Controls.Add(this.tCl);
            this.Controls.Add(this.tDel);
            this.Controls.Add(this.tAdd);
            this.Controls.Add(this.tripTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Trips";
            this.Text = "Рейсы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Trips_FormClosed);
            this.Load += new System.EventHandler(this.Trips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reisyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tripTable;
        private rpsDataSet rpsDataSet;
        private System.Windows.Forms.BindingSource reisyBindingSource;
        private rpsDataSetTableAdapters.reisyTableAdapter reisyTableAdapter;
        private System.Windows.Forms.Button tCl;
        private System.Windows.Forms.Button tDel;
        private System.Windows.Forms.Button tAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpoezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnaznDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestobshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestsvobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn censidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenplacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cen_kupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn censvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeotprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimepribDataGridViewTextBoxColumn;
    }
}
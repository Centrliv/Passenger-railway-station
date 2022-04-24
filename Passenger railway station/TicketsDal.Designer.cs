namespace Passenger_railway_station
{
    partial class TicketsDal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketsdalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.ticketsdalTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.ticketsdalTableAdapter();
            this.idticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpoezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvagonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lgotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnaznDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtotprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpribDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtoformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkassirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl = new System.Windows.Forms.Button();
            this.tdAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsdalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idticketDataGridViewTextBoxColumn,
            this.reisDataGridViewTextBoxColumn,
            this.idpoezdDataGridViewTextBoxColumn,
            this.idvagonDataGridViewTextBoxColumn,
            this.idmestaDataGridViewTextBoxColumn,
            this.vagtypeDataGridViewTextBoxColumn,
            this.lgotaDataGridViewTextBoxColumn,
            this.stotprDataGridViewTextBoxColumn,
            this.stnaznDataGridViewTextBoxColumn,
            this.dtotprDataGridViewTextBoxColumn,
            this.dtpribDataGridViewTextBoxColumn,
            this.dtoformDataGridViewTextBoxColumn,
            this.idkassirDataGridViewTextBoxColumn,
            this.documentDataGridViewTextBoxColumn,
            this.iddocumentDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.stoimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsdalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(978, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // ticketsdalBindingSource
            // 
            this.ticketsdalBindingSource.DataMember = "ticketsdal";
            this.ticketsdalBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsdalTableAdapter
            // 
            this.ticketsdalTableAdapter.ClearBeforeFill = true;
            // 
            // idticketDataGridViewTextBoxColumn
            // 
            this.idticketDataGridViewTextBoxColumn.DataPropertyName = "id_ticket";
            this.idticketDataGridViewTextBoxColumn.HeaderText = "№ билета";
            this.idticketDataGridViewTextBoxColumn.Name = "idticketDataGridViewTextBoxColumn";
            this.idticketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reisDataGridViewTextBoxColumn
            // 
            this.reisDataGridViewTextBoxColumn.DataPropertyName = "reis";
            this.reisDataGridViewTextBoxColumn.HeaderText = "Рейс";
            this.reisDataGridViewTextBoxColumn.Name = "reisDataGridViewTextBoxColumn";
            this.reisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpoezdDataGridViewTextBoxColumn
            // 
            this.idpoezdDataGridViewTextBoxColumn.DataPropertyName = "id_poezd";
            this.idpoezdDataGridViewTextBoxColumn.HeaderText = "Поезд";
            this.idpoezdDataGridViewTextBoxColumn.Name = "idpoezdDataGridViewTextBoxColumn";
            this.idpoezdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvagonDataGridViewTextBoxColumn
            // 
            this.idvagonDataGridViewTextBoxColumn.DataPropertyName = "id_vagon";
            this.idvagonDataGridViewTextBoxColumn.HeaderText = "Вагон";
            this.idvagonDataGridViewTextBoxColumn.Name = "idvagonDataGridViewTextBoxColumn";
            this.idvagonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmestaDataGridViewTextBoxColumn
            // 
            this.idmestaDataGridViewTextBoxColumn.DataPropertyName = "id_mesta";
            this.idmestaDataGridViewTextBoxColumn.HeaderText = "Место";
            this.idmestaDataGridViewTextBoxColumn.Name = "idmestaDataGridViewTextBoxColumn";
            this.idmestaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vagtypeDataGridViewTextBoxColumn
            // 
            this.vagtypeDataGridViewTextBoxColumn.DataPropertyName = "vag_type";
            this.vagtypeDataGridViewTextBoxColumn.HeaderText = "Тип размещения";
            this.vagtypeDataGridViewTextBoxColumn.Name = "vagtypeDataGridViewTextBoxColumn";
            this.vagtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lgotaDataGridViewTextBoxColumn
            // 
            this.lgotaDataGridViewTextBoxColumn.DataPropertyName = "lgota";
            this.lgotaDataGridViewTextBoxColumn.HeaderText = "Тип билета";
            this.lgotaDataGridViewTextBoxColumn.Name = "lgotaDataGridViewTextBoxColumn";
            this.lgotaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dtotprDataGridViewTextBoxColumn
            // 
            this.dtotprDataGridViewTextBoxColumn.DataPropertyName = "dt_otpr";
            this.dtotprDataGridViewTextBoxColumn.HeaderText = "Дата/время отправления";
            this.dtotprDataGridViewTextBoxColumn.Name = "dtotprDataGridViewTextBoxColumn";
            this.dtotprDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtpribDataGridViewTextBoxColumn
            // 
            this.dtpribDataGridViewTextBoxColumn.DataPropertyName = "dt_prib";
            this.dtpribDataGridViewTextBoxColumn.HeaderText = "Дата/время прибытия";
            this.dtpribDataGridViewTextBoxColumn.Name = "dtpribDataGridViewTextBoxColumn";
            this.dtpribDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtoformDataGridViewTextBoxColumn
            // 
            this.dtoformDataGridViewTextBoxColumn.DataPropertyName = "dt_oform";
            this.dtoformDataGridViewTextBoxColumn.HeaderText = "Дата/время продажи";
            this.dtoformDataGridViewTextBoxColumn.Name = "dtoformDataGridViewTextBoxColumn";
            this.dtoformDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idkassirDataGridViewTextBoxColumn
            // 
            this.idkassirDataGridViewTextBoxColumn.DataPropertyName = "id_kassir";
            this.idkassirDataGridViewTextBoxColumn.HeaderText = "Кассир";
            this.idkassirDataGridViewTextBoxColumn.Name = "idkassirDataGridViewTextBoxColumn";
            this.idkassirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentDataGridViewTextBoxColumn
            // 
            this.documentDataGridViewTextBoxColumn.DataPropertyName = "document";
            this.documentDataGridViewTextBoxColumn.HeaderText = "Документ";
            this.documentDataGridViewTextBoxColumn.Name = "documentDataGridViewTextBoxColumn";
            this.documentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddocumentDataGridViewTextBoxColumn
            // 
            this.iddocumentDataGridViewTextBoxColumn.DataPropertyName = "id_document";
            this.iddocumentDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.iddocumentDataGridViewTextBoxColumn.Name = "iddocumentDataGridViewTextBoxColumn";
            this.iddocumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Фамилия И.О.";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoimDataGridViewTextBoxColumn
            // 
            this.stoimDataGridViewTextBoxColumn.DataPropertyName = "stoim";
            this.stoimDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.stoimDataGridViewTextBoxColumn.Name = "stoimDataGridViewTextBoxColumn";
            this.stoimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(887, 320);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(103, 31);
            this.cl.TabIndex = 10;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // tdAdd
            // 
            this.tdAdd.Location = new System.Drawing.Point(12, 320);
            this.tdAdd.Name = "tdAdd";
            this.tdAdd.Size = new System.Drawing.Size(103, 31);
            this.tdAdd.TabIndex = 9;
            this.tdAdd.Text = "Добавить";
            this.tdAdd.UseVisualStyleBackColor = true;
            this.tdAdd.Click += new System.EventHandler(this.tdAdd_Click);
            // 
            // TicketsDal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 359);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.tdAdd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TicketsDal";
            this.Text = "Продажа билетов (пригородные)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicketsDal_FormClosed);
            this.Load += new System.EventHandler(this.TicketsDal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsdalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private rpsDataSet rpsDataSet;
        private System.Windows.Forms.BindingSource ticketsdalBindingSource;
        private rpsDataSetTableAdapters.ticketsdalTableAdapter ticketsdalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpoezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvagonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lgotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnaznDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtotprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtpribDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtoformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkassirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button tdAdd;
    }
}
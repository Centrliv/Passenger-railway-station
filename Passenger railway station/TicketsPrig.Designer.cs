namespace Passenger_railway_station
{
    partial class TicketsPrig
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
            this.TickPrigTable = new System.Windows.Forms.DataGridView();
            this.idticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kassirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsprigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.cl = new System.Windows.Forms.Button();
            this.tpAdd = new System.Windows.Forms.Button();
            this.ticketsprigTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.ticketsprigTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TickPrigTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsprigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TickPrigTable
            // 
            this.TickPrigTable.AllowUserToAddRows = false;
            this.TickPrigTable.AllowUserToDeleteRows = false;
            this.TickPrigTable.AutoGenerateColumns = false;
            this.TickPrigTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TickPrigTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TickPrigTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idticketDataGridViewTextBoxColumn,
            this.dtprodDataGridViewTextBoxColumn,
            this.reisDataGridViewTextBoxColumn,
            this.vagonDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn,
            this.stotDataGridViewTextBoxColumn,
            this.stprDataGridViewTextBoxColumn,
            this.kassirDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.TickPrigTable.DataSource = this.ticketsprigBindingSource;
            this.TickPrigTable.Location = new System.Drawing.Point(12, 12);
            this.TickPrigTable.Name = "TickPrigTable";
            this.TickPrigTable.ReadOnly = true;
            this.TickPrigTable.Size = new System.Drawing.Size(831, 335);
            this.TickPrigTable.TabIndex = 0;
            // 
            // idticketDataGridViewTextBoxColumn
            // 
            this.idticketDataGridViewTextBoxColumn.DataPropertyName = "id_ticket";
            this.idticketDataGridViewTextBoxColumn.HeaderText = "№ билета";
            this.idticketDataGridViewTextBoxColumn.Name = "idticketDataGridViewTextBoxColumn";
            this.idticketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtprodDataGridViewTextBoxColumn
            // 
            this.dtprodDataGridViewTextBoxColumn.DataPropertyName = "dt_prod";
            this.dtprodDataGridViewTextBoxColumn.HeaderText = "Дата/время продажи";
            this.dtprodDataGridViewTextBoxColumn.Name = "dtprodDataGridViewTextBoxColumn";
            this.dtprodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reisDataGridViewTextBoxColumn
            // 
            this.reisDataGridViewTextBoxColumn.DataPropertyName = "reis";
            this.reisDataGridViewTextBoxColumn.HeaderText = "Рейс";
            this.reisDataGridViewTextBoxColumn.Name = "reisDataGridViewTextBoxColumn";
            this.reisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vagonDataGridViewTextBoxColumn
            // 
            this.vagonDataGridViewTextBoxColumn.DataPropertyName = "vagon";
            this.vagonDataGridViewTextBoxColumn.HeaderText = "Вагон";
            this.vagonDataGridViewTextBoxColumn.Name = "vagonDataGridViewTextBoxColumn";
            this.vagonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Место";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            this.mestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stotDataGridViewTextBoxColumn
            // 
            this.stotDataGridViewTextBoxColumn.DataPropertyName = "st_ot";
            this.stotDataGridViewTextBoxColumn.HeaderText = "Станция отправления";
            this.stotDataGridViewTextBoxColumn.Name = "stotDataGridViewTextBoxColumn";
            this.stotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stprDataGridViewTextBoxColumn
            // 
            this.stprDataGridViewTextBoxColumn.DataPropertyName = "st_pr";
            this.stprDataGridViewTextBoxColumn.HeaderText = "Станция назначения";
            this.stprDataGridViewTextBoxColumn.Name = "stprDataGridViewTextBoxColumn";
            this.stprDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kassirDataGridViewTextBoxColumn
            // 
            this.kassirDataGridViewTextBoxColumn.DataPropertyName = "kassir";
            this.kassirDataGridViewTextBoxColumn.HeaderText = "Кассир";
            this.kassirDataGridViewTextBoxColumn.Name = "kassirDataGridViewTextBoxColumn";
            this.kassirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketsprigBindingSource
            // 
            this.ticketsprigBindingSource.DataMember = "ticketsprig";
            this.ticketsprigBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(740, 353);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(103, 31);
            this.cl.TabIndex = 8;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // tpAdd
            // 
            this.tpAdd.Location = new System.Drawing.Point(12, 353);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Size = new System.Drawing.Size(103, 31);
            this.tpAdd.TabIndex = 5;
            this.tpAdd.Text = "Добавить";
            this.tpAdd.UseVisualStyleBackColor = true;
            this.tpAdd.Click += new System.EventHandler(this.tpAdd_Click);
            // 
            // ticketsprigTableAdapter
            // 
            this.ticketsprigTableAdapter.ClearBeforeFill = true;
            // 
            // TicketsPrig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 390);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.tpAdd);
            this.Controls.Add(this.TickPrigTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TicketsPrig";
            this.Text = "Продажа билетов (пригородные)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicketsPrig_FormClosed);
            this.Load += new System.EventHandler(this.TicketsPrig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TickPrigTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsprigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TickPrigTable;
        private rpsDataSet rpsDataSet;
        private System.Windows.Forms.BindingSource ticketsprigBindingSource;
        private rpsDataSetTableAdapters.ticketsprigTableAdapter ticketsprigTableAdapter;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button tpAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kassirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
    }
}
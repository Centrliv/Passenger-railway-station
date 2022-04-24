namespace Passenger_railway_station
{
    partial class Schedule
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
            this.schedTable = new System.Windows.Forms.DataGridView();
            this.raspisanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.raspisanieTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.raspisanieTableAdapter();
            this.cl = new System.Windows.Forms.Button();
            this.shcCh = new System.Windows.Forms.Button();
            this.idreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpoezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnaznDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeotprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimepribDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.schedTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // schedTable
            // 
            this.schedTable.AllowUserToAddRows = false;
            this.schedTable.AllowUserToDeleteRows = false;
            this.schedTable.AutoGenerateColumns = false;
            this.schedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreisDataGridViewTextBoxColumn,
            this.idpoezdDataGridViewTextBoxColumn,
            this.stotprDataGridViewTextBoxColumn,
            this.stnaznDataGridViewTextBoxColumn,
            this.datetimeotprDataGridViewTextBoxColumn,
            this.datetimepribDataGridViewTextBoxColumn});
            this.schedTable.DataSource = this.raspisanieBindingSource;
            this.schedTable.Location = new System.Drawing.Point(12, 12);
            this.schedTable.Name = "schedTable";
            this.schedTable.ReadOnly = true;
            this.schedTable.Size = new System.Drawing.Size(682, 267);
            this.schedTable.TabIndex = 0;
            // 
            // raspisanieBindingSource
            // 
            this.raspisanieBindingSource.DataMember = "raspisanie";
            this.raspisanieBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raspisanieTableAdapter
            // 
            this.raspisanieTableAdapter.ClearBeforeFill = true;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(586, 288);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(108, 28);
            this.cl.TabIndex = 31;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // shcCh
            // 
            this.shcCh.Location = new System.Drawing.Point(12, 288);
            this.shcCh.Name = "shcCh";
            this.shcCh.Size = new System.Drawing.Size(108, 28);
            this.shcCh.TabIndex = 30;
            this.shcCh.Text = "Изменить";
            this.shcCh.UseVisualStyleBackColor = true;
            this.shcCh.Click += new System.EventHandler(this.shcCh_Click);
            // 
            // idreisDataGridViewTextBoxColumn
            // 
            this.idreisDataGridViewTextBoxColumn.DataPropertyName = "id_reis";
            this.idreisDataGridViewTextBoxColumn.HeaderText = "Рейс";
            this.idreisDataGridViewTextBoxColumn.Name = "idreisDataGridViewTextBoxColumn";
            this.idreisDataGridViewTextBoxColumn.ReadOnly = true;
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
            // datetimeotprDataGridViewTextBoxColumn
            // 
            this.datetimeotprDataGridViewTextBoxColumn.DataPropertyName = "date_time_otpr";
            this.datetimeotprDataGridViewTextBoxColumn.HeaderText = "Дата/время отправления";
            this.datetimeotprDataGridViewTextBoxColumn.Name = "datetimeotprDataGridViewTextBoxColumn";
            this.datetimeotprDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimepribDataGridViewTextBoxColumn
            // 
            this.datetimepribDataGridViewTextBoxColumn.DataPropertyName = "date_time_prib";
            this.datetimepribDataGridViewTextBoxColumn.HeaderText = "Дата/время прибытия";
            this.datetimepribDataGridViewTextBoxColumn.Name = "datetimepribDataGridViewTextBoxColumn";
            this.datetimepribDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 325);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.shcCh);
            this.Controls.Add(this.schedTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Schedule";
            this.Text = "Распиание";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Schedule_FormClosed);
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView schedTable;
        private rpsDataSet rpsDataSet;
        private System.Windows.Forms.BindingSource raspisanieBindingSource;
        private rpsDataSetTableAdapters.raspisanieTableAdapter raspisanieTableAdapter;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button shcCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpoezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnaznDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeotprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimepribDataGridViewTextBoxColumn;
    }
}
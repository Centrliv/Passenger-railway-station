namespace Passenger_railway_station
{
    partial class Vans
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
            this.vansTable = new System.Windows.Forms.DataGridView();
            this.vagonyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.vagonyTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.vagonyTableAdapter();
            this.label = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Button();
            this.vDel = new System.Windows.Forms.Button();
            this.vCh = new System.Windows.Forms.Button();
            this.vAdd = new System.Windows.Forms.Button();
            this.idvagonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpoezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vansTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagonyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vansTable
            // 
            this.vansTable.AllowUserToAddRows = false;
            this.vansTable.AllowUserToDeleteRows = false;
            this.vansTable.AutoGenerateColumns = false;
            this.vansTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vansTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vansTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvagonDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.kolDataGridViewTextBoxColumn,
            this.idpoezdDataGridViewTextBoxColumn});
            this.vansTable.DataSource = this.vagonyBindingSource;
            this.vansTable.Location = new System.Drawing.Point(12, 35);
            this.vansTable.Name = "vansTable";
            this.vansTable.ReadOnly = true;
            this.vansTable.Size = new System.Drawing.Size(433, 377);
            this.vansTable.TabIndex = 0;
            // 
            // vagonyBindingSource
            // 
            this.vagonyBindingSource.DataMember = "vagony";
            this.vagonyBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vagonyTableAdapter
            // 
            this.vagonyTableAdapter.ClearBeforeFill = true;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(433, 23);
            this.label.TabIndex = 3;
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(359, 418);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(86, 31);
            this.cl.TabIndex = 9;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // vDel
            // 
            this.vDel.Location = new System.Drawing.Point(196, 418);
            this.vDel.Name = "vDel";
            this.vDel.Size = new System.Drawing.Size(86, 31);
            this.vDel.TabIndex = 8;
            this.vDel.Text = "Удалить";
            this.vDel.UseVisualStyleBackColor = true;
            this.vDel.Click += new System.EventHandler(this.vDel_Click);
            // 
            // vCh
            // 
            this.vCh.Location = new System.Drawing.Point(104, 418);
            this.vCh.Name = "vCh";
            this.vCh.Size = new System.Drawing.Size(86, 31);
            this.vCh.TabIndex = 7;
            this.vCh.Text = "Изменить";
            this.vCh.UseVisualStyleBackColor = true;
            this.vCh.Click += new System.EventHandler(this.vCh_Click);
            // 
            // vAdd
            // 
            this.vAdd.Location = new System.Drawing.Point(12, 418);
            this.vAdd.Name = "vAdd";
            this.vAdd.Size = new System.Drawing.Size(86, 31);
            this.vAdd.TabIndex = 6;
            this.vAdd.Text = "Добавить";
            this.vAdd.UseVisualStyleBackColor = true;
            this.vAdd.Click += new System.EventHandler(this.vAdd_Click);
            // 
            // idvagonDataGridViewTextBoxColumn
            // 
            this.idvagonDataGridViewTextBoxColumn.DataPropertyName = "id_vagon";
            dataGridViewCellStyle1.Format = "D5";
            dataGridViewCellStyle1.NullValue = null;
            this.idvagonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idvagonDataGridViewTextBoxColumn.HeaderText = "Номер вагона";
            this.idvagonDataGridViewTextBoxColumn.Name = "idvagonDataGridViewTextBoxColumn";
            this.idvagonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип размещения";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kolDataGridViewTextBoxColumn
            // 
            this.kolDataGridViewTextBoxColumn.DataPropertyName = "kol";
            this.kolDataGridViewTextBoxColumn.HeaderText = "Количество мест";
            this.kolDataGridViewTextBoxColumn.Name = "kolDataGridViewTextBoxColumn";
            this.kolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpoezdDataGridViewTextBoxColumn
            // 
            this.idpoezdDataGridViewTextBoxColumn.DataPropertyName = "id_poezd";
            this.idpoezdDataGridViewTextBoxColumn.HeaderText = "id_poezd";
            this.idpoezdDataGridViewTextBoxColumn.Name = "idpoezdDataGridViewTextBoxColumn";
            this.idpoezdDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpoezdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Vans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 456);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.vDel);
            this.Controls.Add(this.vCh);
            this.Controls.Add(this.vAdd);
            this.Controls.Add(this.label);
            this.Controls.Add(this.vansTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Vans";
            this.Text = "Вагоны";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vans_FormClosed);
            this.Load += new System.EventHandler(this.Vans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vansTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagonyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vansTable;
        private rpsDataSet rpsDataSet;
        private System.Windows.Forms.BindingSource vagonyBindingSource;
        private rpsDataSetTableAdapters.vagonyTableAdapter vagonyTableAdapter;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button vDel;
        private System.Windows.Forms.Button vCh;
        private System.Windows.Forms.Button vAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvagonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpoezdDataGridViewTextBoxColumn;
    }
}
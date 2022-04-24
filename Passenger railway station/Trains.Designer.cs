namespace Passenger_railway_station
{
    partial class Trains
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
            this.trainTable = new System.Windows.Forms.DataGridView();
            this.cl = new System.Windows.Forms.Button();
            this.tDel = new System.Windows.Forms.Button();
            this.tCh = new System.Windows.Forms.Button();
            this.tAdd = new System.Windows.Forms.Button();
            this.Vans = new System.Windows.Forms.Button();
            this.idpoezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poezdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.poezdTableAdapter1 = new Passenger_railway_station.rpsDataSetTableAdapters.poezdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trainTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poezdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // trainTable
            // 
            this.trainTable.AllowUserToAddRows = false;
            this.trainTable.AllowUserToDeleteRows = false;
            this.trainTable.AutoGenerateColumns = false;
            this.trainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpoezdDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.dateentDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.trainTable.DataSource = this.poezdBindingSource;
            this.trainTable.Location = new System.Drawing.Point(12, 12);
            this.trainTable.Name = "trainTable";
            this.trainTable.ReadOnly = true;
            this.trainTable.Size = new System.Drawing.Size(462, 248);
            this.trainTable.TabIndex = 0;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(480, 229);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(103, 31);
            this.cl.TabIndex = 5;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // tDel
            // 
            this.tDel.Location = new System.Drawing.Point(480, 86);
            this.tDel.Name = "tDel";
            this.tDel.Size = new System.Drawing.Size(103, 31);
            this.tDel.TabIndex = 3;
            this.tDel.Text = "Удалить";
            this.tDel.UseVisualStyleBackColor = true;
            this.tDel.Click += new System.EventHandler(this.tDel_Click);
            // 
            // tCh
            // 
            this.tCh.Location = new System.Drawing.Point(480, 49);
            this.tCh.Name = "tCh";
            this.tCh.Size = new System.Drawing.Size(103, 31);
            this.tCh.TabIndex = 2;
            this.tCh.Text = "Изменить";
            this.tCh.UseVisualStyleBackColor = true;
            this.tCh.Click += new System.EventHandler(this.tCh_Click);
            // 
            // tAdd
            // 
            this.tAdd.Location = new System.Drawing.Point(480, 12);
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(103, 31);
            this.tAdd.TabIndex = 1;
            this.tAdd.Text = "Добавить";
            this.tAdd.UseVisualStyleBackColor = true;
            this.tAdd.Click += new System.EventHandler(this.tAdd_Click);
            // 
            // Vans
            // 
            this.Vans.Location = new System.Drawing.Point(480, 158);
            this.Vans.Name = "Vans";
            this.Vans.Size = new System.Drawing.Size(103, 31);
            this.Vans.TabIndex = 4;
            this.Vans.Text = "Вагоны";
            this.Vans.UseVisualStyleBackColor = true;
            this.Vans.Click += new System.EventHandler(this.Vans_Click);
            // 
            // idpoezdDataGridViewTextBoxColumn
            // 
            this.idpoezdDataGridViewTextBoxColumn.DataPropertyName = "id_poezd";
            this.idpoezdDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.idpoezdDataGridViewTextBoxColumn.Name = "idpoezdDataGridViewTextBoxColumn";
            this.idpoezdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateentDataGridViewTextBoxColumn
            // 
            this.dateentDataGridViewTextBoxColumn.DataPropertyName = "dateent";
            this.dateentDataGridViewTextBoxColumn.HeaderText = "Дата ввода";
            this.dateentDataGridViewTextBoxColumn.Name = "dateentDataGridViewTextBoxColumn";
            this.dateentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poezdBindingSource
            // 
            this.poezdBindingSource.DataMember = "poezd";
            this.poezdBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poezdTableAdapter1
            // 
            this.poezdTableAdapter1.ClearBeforeFill = true;
            // 
            // Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 270);
            this.Controls.Add(this.Vans);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.tDel);
            this.Controls.Add(this.tCh);
            this.Controls.Add(this.tAdd);
            this.Controls.Add(this.trainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Trains";
            this.Text = "Поезда";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Trains_FormClosed);
            this.Load += new System.EventHandler(this.Trains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poezdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView trainTable;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button tDel;
        private System.Windows.Forms.Button tCh;
        private System.Windows.Forms.Button tAdd;
        private System.Windows.Forms.Button Vans;
        private rpsDataSet rpsDataSet;
        private System.Windows.Forms.BindingSource poezdBindingSource;
        private rpsDataSetTableAdapters.poezdTableAdapter poezdTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpoezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}
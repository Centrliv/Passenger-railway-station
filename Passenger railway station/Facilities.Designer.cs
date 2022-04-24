namespace Passenger_railway_station
{
    partial class Facilities
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
            this.lgotiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpsDataSet = new Passenger_railway_station.rpsDataSet();
            this.lgotiTableAdapter = new Passenger_railway_station.rpsDataSetTableAdapters.lgotiTableAdapter();
            this.facDel = new System.Windows.Forms.Button();
            this.facCh = new System.Windows.Forms.Button();
            this.facAdd = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lgotiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lgotiBindingSource
            // 
            this.lgotiBindingSource.DataMember = "lgoti";
            this.lgotiBindingSource.DataSource = this.rpsDataSet;
            // 
            // rpsDataSet
            // 
            this.rpsDataSet.DataSetName = "rpsDataSet";
            this.rpsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lgotiTableAdapter
            // 
            this.lgotiTableAdapter.ClearBeforeFill = true;
            // 
            // facDel
            // 
            this.facDel.Location = new System.Drawing.Point(230, 241);
            this.facDel.Name = "facDel";
            this.facDel.Size = new System.Drawing.Size(103, 31);
            this.facDel.TabIndex = 3;
            this.facDel.Text = "Удалить";
            this.facDel.UseVisualStyleBackColor = true;
            this.facDel.Click += new System.EventHandler(this.facDel_Click);
            // 
            // facCh
            // 
            this.facCh.Location = new System.Drawing.Point(121, 241);
            this.facCh.Name = "facCh";
            this.facCh.Size = new System.Drawing.Size(103, 31);
            this.facCh.TabIndex = 2;
            this.facCh.Text = "Изменить";
            this.facCh.UseVisualStyleBackColor = true;
            this.facCh.Click += new System.EventHandler(this.facCh_Click);
            // 
            // facAdd
            // 
            this.facAdd.Location = new System.Drawing.Point(12, 241);
            this.facAdd.Name = "facAdd";
            this.facAdd.Size = new System.Drawing.Size(103, 31);
            this.facAdd.TabIndex = 1;
            this.facAdd.Text = "Добавить";
            this.facAdd.UseVisualStyleBackColor = true;
            this.facAdd.Click += new System.EventHandler(this.facAdd_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(480, 241);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(103, 31);
            this.cl.TabIndex = 4;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Размер, %";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facTable
            // 
            this.facTable.AllowUserToAddRows = false;
            this.facTable.AutoGenerateColumns = false;
            this.facTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.facTable.DataSource = this.lgotiBindingSource;
            this.facTable.Location = new System.Drawing.Point(12, 12);
            this.facTable.MultiSelect = false;
            this.facTable.Name = "facTable";
            this.facTable.ReadOnly = true;
            this.facTable.Size = new System.Drawing.Size(571, 223);
            this.facTable.TabIndex = 0;
            this.facTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.facTable_UserDeletingRow);
            // 
            // Facilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 277);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.facDel);
            this.Controls.Add(this.facCh);
            this.Controls.Add(this.facAdd);
            this.Controls.Add(this.facTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Facilities";
            this.Text = "Льготы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facilities_FormClosed);
            this.Load += new System.EventHandler(this.Facilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lgotiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button facDel;
        private System.Windows.Forms.Button facCh;
        private System.Windows.Forms.Button facAdd;
        private System.Windows.Forms.Button cl;
        public rpsDataSet rpsDataSet;
        public System.Windows.Forms.BindingSource lgotiBindingSource;
        public rpsDataSetTableAdapters.lgotiTableAdapter lgotiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView facTable;

    }
}
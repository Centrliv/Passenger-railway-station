namespace Passenger_railway_station
{
    partial class AddTickPrig
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
            this.reis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vagon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mesto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.station = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.skidka = new System.Windows.Forms.ComboBox();
            this.itog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Button();
            this.spend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reis
            // 
            this.reis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reis.FormattingEnabled = true;
            this.reis.Location = new System.Drawing.Point(15, 25);
            this.reis.Name = "reis";
            this.reis.Size = new System.Drawing.Size(330, 21);
            this.reis.TabIndex = 0;
            this.reis.SelectedIndexChanged += new System.EventHandler(this.reis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рейс:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вагон:";
            // 
            // vagon
            // 
            this.vagon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vagon.Enabled = false;
            this.vagon.FormattingEnabled = true;
            this.vagon.Location = new System.Drawing.Point(15, 65);
            this.vagon.Name = "vagon";
            this.vagon.Size = new System.Drawing.Size(153, 21);
            this.vagon.TabIndex = 2;
            this.vagon.SelectedIndexChanged += new System.EventHandler(this.vagon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Место:";
            // 
            // mesto
            // 
            this.mesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesto.Enabled = false;
            this.mesto.FormattingEnabled = true;
            this.mesto.Location = new System.Drawing.Point(192, 65);
            this.mesto.Name = "mesto";
            this.mesto.Size = new System.Drawing.Size(153, 21);
            this.mesto.TabIndex = 4;
            this.mesto.SelectedIndexChanged += new System.EventHandler(this.mesto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Станция назначения:";
            // 
            // station
            // 
            this.station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.station.Enabled = false;
            this.station.FormattingEnabled = true;
            this.station.Location = new System.Drawing.Point(15, 105);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(153, 21);
            this.station.TabIndex = 6;
            this.station.SelectedIndexChanged += new System.EventHandler(this.station_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип билета:";
            // 
            // skidka
            // 
            this.skidka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skidka.Enabled = false;
            this.skidka.FormattingEnabled = true;
            this.skidka.Location = new System.Drawing.Point(15, 145);
            this.skidka.Name = "skidka";
            this.skidka.Size = new System.Drawing.Size(153, 21);
            this.skidka.TabIndex = 8;
            this.skidka.SelectedIndexChanged += new System.EventHandler(this.skidka_SelectedIndexChanged);
            // 
            // itog
            // 
            this.itog.Enabled = false;
            this.itog.Location = new System.Drawing.Point(192, 145);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(153, 20);
            this.itog.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Итог:";
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(237, 181);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(108, 28);
            this.cl.TabIndex = 13;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // spend
            // 
            this.spend.Location = new System.Drawing.Point(15, 181);
            this.spend.Name = "spend";
            this.spend.Size = new System.Drawing.Size(153, 28);
            this.spend.TabIndex = 12;
            this.spend.Text = "Провести и печатать";
            this.spend.UseVisualStyleBackColor = true;
            this.spend.Click += new System.EventHandler(this.spend_Click);
            // 
            // AddTickPrig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 219);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.spend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skidka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.station);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vagon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTickPrig";
            this.Text = "Продажа пригородного билета";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTickPrig_FormClosed);
            this.Load += new System.EventHandler(this.AddTickPrig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vagon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox station;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox skidka;
        private System.Windows.Forms.TextBox itog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button spend;
    }
}
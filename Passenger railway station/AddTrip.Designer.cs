namespace Passenger_railway_station
{
    partial class AddTrip
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
            this.label1 = new System.Windows.Forms.Label();
            this.idtrip = new System.Windows.Forms.MaskedTextBox();
            this.types = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.routes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trains = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.allpl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtd = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtar = new System.Windows.Forms.DateTimePicker();
            this.cl = new System.Windows.Forms.Button();
            this.tpipAdd = new System.Windows.Forms.Button();
            this.cs = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.Label();
            this.ck = new System.Windows.Forms.Label();
            this.csv = new System.Windows.Forms.Label();
            this.statd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.freepl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер рейса:";
            // 
            // idtrip
            // 
            this.idtrip.Location = new System.Drawing.Point(15, 25);
            this.idtrip.Mask = "AAAAA";
            this.idtrip.Name = "idtrip";
            this.idtrip.Size = new System.Drawing.Size(74, 20);
            this.idtrip.TabIndex = 1;
            this.idtrip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idtrip_MouseClick);
            // 
            // types
            // 
            this.types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.types.FormattingEnabled = true;
            this.types.Items.AddRange(new object[] {
            "Пригородный",
            "Дальний"});
            this.types.Location = new System.Drawing.Point(15, 64);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(220, 21);
            this.types.TabIndex = 2;
            this.types.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип следования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Маршрут:";
            // 
            // routes
            // 
            this.routes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.routes.FormattingEnabled = true;
            this.routes.Location = new System.Drawing.Point(15, 104);
            this.routes.Name = "routes";
            this.routes.Size = new System.Drawing.Size(220, 21);
            this.routes.TabIndex = 5;
            this.routes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поезд:";
            // 
            // trains
            // 
            this.trains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trains.FormattingEnabled = true;
            this.trains.Location = new System.Drawing.Point(15, 144);
            this.trains.Name = "trains";
            this.trains.Size = new System.Drawing.Size(220, 21);
            this.trains.TabIndex = 7;
            this.trains.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Станция отправления:";
            // 
            // statar
            // 
            this.statar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statar.FormattingEnabled = true;
            this.statar.Location = new System.Drawing.Point(15, 224);
            this.statar.Name = "statar";
            this.statar.Size = new System.Drawing.Size(220, 21);
            this.statar.TabIndex = 11;
            this.statar.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Станция назначения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Всего мест:";
            // 
            // allpl
            // 
            this.allpl.AutoSize = true;
            this.allpl.Location = new System.Drawing.Point(269, 27);
            this.allpl.Name = "allpl";
            this.allpl.Size = new System.Drawing.Size(0, 13);
            this.allpl.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Цена сидячий:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Цена плацкарт:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Цена купе:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(399, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Цена СВ (люкс):";
            // 
            // dtd
            // 
            this.dtd.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtd.Location = new System.Drawing.Point(271, 146);
            this.dtd.Name = "dtd";
            this.dtd.Size = new System.Drawing.Size(239, 20);
            this.dtd.TabIndex = 24;
            this.dtd.ValueChanged += new System.EventHandler(this.fdate_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Дата, время отправления:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(268, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Дата, время прибытия:";
            // 
            // dtar
            // 
            this.dtar.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtar.Location = new System.Drawing.Point(271, 187);
            this.dtar.Name = "dtar";
            this.dtar.Size = new System.Drawing.Size(239, 20);
            this.dtar.TabIndex = 26;
            this.dtar.ValueChanged += new System.EventHandler(this.sdate_ValueChanged);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(402, 219);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(108, 28);
            this.cl.TabIndex = 29;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // tpipAdd
            // 
            this.tpipAdd.Location = new System.Drawing.Point(272, 219);
            this.tpipAdd.Name = "tpipAdd";
            this.tpipAdd.Size = new System.Drawing.Size(108, 28);
            this.tpipAdd.TabIndex = 28;
            this.tpipAdd.Text = "Добавить";
            this.tpipAdd.UseVisualStyleBackColor = true;
            this.tpipAdd.Click += new System.EventHandler(this.tripAdd_Click);
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Location = new System.Drawing.Point(268, 66);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(0, 13);
            this.cs.TabIndex = 30;
            // 
            // cp
            // 
            this.cp.AutoSize = true;
            this.cp.Location = new System.Drawing.Point(399, 66);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(0, 13);
            this.cp.TabIndex = 31;
            // 
            // ck
            // 
            this.ck.AutoSize = true;
            this.ck.Location = new System.Drawing.Point(268, 106);
            this.ck.Name = "ck";
            this.ck.Size = new System.Drawing.Size(0, 13);
            this.ck.TabIndex = 32;
            // 
            // csv
            // 
            this.csv.AutoSize = true;
            this.csv.Location = new System.Drawing.Point(399, 106);
            this.csv.Name = "csv";
            this.csv.Size = new System.Drawing.Size(0, 13);
            this.csv.TabIndex = 33;
            // 
            // statd
            // 
            this.statd.Enabled = false;
            this.statd.Location = new System.Drawing.Point(15, 184);
            this.statd.Name = "statd";
            this.statd.Size = new System.Drawing.Size(220, 20);
            this.statd.TabIndex = 34;
            this.statd.Text = "Волоколамск";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Мест свободно:";
            // 
            // freepl
            // 
            this.freepl.AutoSize = true;
            this.freepl.Location = new System.Drawing.Point(399, 27);
            this.freepl.Name = "freepl";
            this.freepl.Size = new System.Drawing.Size(0, 13);
            this.freepl.TabIndex = 15;
            // 
            // AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 257);
            this.Controls.Add(this.statd);
            this.Controls.Add(this.csv);
            this.Controls.Add(this.ck);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.tpipAdd);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.freepl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.allpl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trains);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.routes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.types);
            this.Controls.Add(this.idtrip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTrip";
            this.Text = "Добавление рейса";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTrip_FormClosed);
            this.Load += new System.EventHandler(this.AddTrip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox idtrip;
        private System.Windows.Forms.ComboBox types;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox routes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox trains;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label allpl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtar;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button tpipAdd;
        private System.Windows.Forms.Label cs;
        private System.Windows.Forms.Label cp;
        private System.Windows.Forms.Label ck;
        private System.Windows.Forms.Label csv;
        private System.Windows.Forms.TextBox statd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label freepl;
    }
}
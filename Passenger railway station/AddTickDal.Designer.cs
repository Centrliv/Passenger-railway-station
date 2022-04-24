namespace Passenger_railway_station
{
    partial class AddTickDal
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
            this.cl = new System.Windows.Forms.Button();
            this.spend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.itog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.skidka = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.station = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mesto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vagon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.typedoc = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.f_io = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(411, 289);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(108, 28);
            this.cl.TabIndex = 27;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // spend
            // 
            this.spend.Location = new System.Drawing.Point(12, 289);
            this.spend.Name = "spend";
            this.spend.Size = new System.Drawing.Size(153, 28);
            this.spend.TabIndex = 26;
            this.spend.Text = "Провести и печатать";
            this.spend.UseVisualStyleBackColor = true;
            this.spend.Click += new System.EventHandler(this.spend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Итог:";
            // 
            // itog
            // 
            this.itog.Enabled = false;
            this.itog.Location = new System.Drawing.Point(360, 252);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(159, 20);
            this.itog.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Тип билета:";
            // 
            // skidka
            // 
            this.skidka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skidka.Enabled = false;
            this.skidka.FormattingEnabled = true;
            this.skidka.Location = new System.Drawing.Point(6, 111);
            this.skidka.Name = "skidka";
            this.skidka.Size = new System.Drawing.Size(153, 21);
            this.skidka.TabIndex = 22;
            this.skidka.SelectedIndexChanged += new System.EventHandler(this.skidka_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Станция назначения:";
            // 
            // station
            // 
            this.station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.station.Enabled = false;
            this.station.FormattingEnabled = true;
            this.station.Location = new System.Drawing.Point(348, 71);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(153, 21);
            this.station.TabIndex = 20;
            this.station.SelectedIndexChanged += new System.EventHandler(this.station_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Место:";
            // 
            // mesto
            // 
            this.mesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesto.Enabled = false;
            this.mesto.FormattingEnabled = true;
            this.mesto.Location = new System.Drawing.Point(177, 71);
            this.mesto.Name = "mesto";
            this.mesto.Size = new System.Drawing.Size(153, 21);
            this.mesto.TabIndex = 18;
            this.mesto.SelectedIndexChanged += new System.EventHandler(this.mesto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Вагон:";
            // 
            // vagon
            // 
            this.vagon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vagon.Enabled = false;
            this.vagon.FormattingEnabled = true;
            this.vagon.Location = new System.Drawing.Point(6, 71);
            this.vagon.Name = "vagon";
            this.vagon.Size = new System.Drawing.Size(153, 21);
            this.vagon.TabIndex = 16;
            this.vagon.SelectedIndexChanged += new System.EventHandler(this.vagon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Рейс:";
            // 
            // reis
            // 
            this.reis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reis.FormattingEnabled = true;
            this.reis.Location = new System.Drawing.Point(6, 31);
            this.reis.Name = "reis";
            this.reis.Size = new System.Drawing.Size(324, 21);
            this.reis.TabIndex = 14;
            this.reis.SelectedIndexChanged += new System.EventHandler(this.reis_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Тип документа:";
            // 
            // typedoc
            // 
            this.typedoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typedoc.FormattingEnabled = true;
            this.typedoc.Items.AddRange(new object[] {
            "Паспорт",
            "Свидетельство",
            "Удостоверение"});
            this.typedoc.Location = new System.Drawing.Point(6, 39);
            this.typedoc.Name = "typedoc";
            this.typedoc.Size = new System.Drawing.Size(153, 21);
            this.typedoc.TabIndex = 28;
            this.typedoc.SelectedIndexChanged += new System.EventHandler(this.typedoc_SelectedIndexChanged);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(178, 39);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(153, 20);
            this.num.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Серия, номер:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Фамилия, И.О.:";
            // 
            // f_io
            // 
            this.f_io.Location = new System.Drawing.Point(348, 40);
            this.f_io.Name = "f_io";
            this.f_io.Size = new System.Drawing.Size(153, 20);
            this.f_io.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.skidka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.station);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vagon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reis);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 145);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения о маршруте:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.f_io);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.num);
            this.groupBox2.Controls.Add(this.typedoc);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 74);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сведения о пассажире";
            // 
            // AddTickDal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.spend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTickDal";
            this.Text = "Продажа билета дальнего следования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTickDal_FormClosed);
            this.Load += new System.EventHandler(this.AddTickDal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button spend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox skidka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox station;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vagon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox reis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox typedoc;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox f_io;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
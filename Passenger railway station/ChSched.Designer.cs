namespace Passenger_railway_station
{
    partial class ChSched
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
            this.schedCh = new System.Windows.Forms.Button();
            this.reis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poezd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.st_o = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.st_n = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtar = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(242, 168);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(108, 28);
            this.cl.TabIndex = 31;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // schedCh
            // 
            this.schedCh.Location = new System.Drawing.Point(12, 168);
            this.schedCh.Name = "schedCh";
            this.schedCh.Size = new System.Drawing.Size(108, 28);
            this.schedCh.TabIndex = 30;
            this.schedCh.Text = "Изменить";
            this.schedCh.UseVisualStyleBackColor = true;
            this.schedCh.Click += new System.EventHandler(this.schedCh_Click);
            // 
            // reis
            // 
            this.reis.Enabled = false;
            this.reis.Location = new System.Drawing.Point(12, 25);
            this.reis.Name = "reis";
            this.reis.Size = new System.Drawing.Size(100, 20);
            this.reis.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Рейс:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Поезд:";
            // 
            // poezd
            // 
            this.poezd.Enabled = false;
            this.poezd.Location = new System.Drawing.Point(166, 25);
            this.poezd.Name = "poezd";
            this.poezd.Size = new System.Drawing.Size(100, 20);
            this.poezd.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Станция отправления:";
            // 
            // st_o
            // 
            this.st_o.Enabled = false;
            this.st_o.Location = new System.Drawing.Point(12, 78);
            this.st_o.Name = "st_o";
            this.st_o.Size = new System.Drawing.Size(156, 20);
            this.st_o.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Станция назначения:";
            // 
            // st_n
            // 
            this.st_n.Enabled = false;
            this.st_n.Location = new System.Drawing.Point(194, 78);
            this.st_n.Name = "st_n";
            this.st_n.Size = new System.Drawing.Size(156, 20);
            this.st_n.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(191, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Дата, время прибытия:";
            // 
            // dtar
            // 
            this.dtar.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtar.Location = new System.Drawing.Point(194, 132);
            this.dtar.Name = "dtar";
            this.dtar.Size = new System.Drawing.Size(156, 20);
            this.dtar.TabIndex = 42;
            this.dtar.ValueChanged += new System.EventHandler(this.dtar_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Дата, время отправления:";
            // 
            // dtd
            // 
            this.dtd.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dtd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtd.Location = new System.Drawing.Point(12, 132);
            this.dtd.Name = "dtd";
            this.dtd.Size = new System.Drawing.Size(156, 20);
            this.dtd.TabIndex = 40;
            this.dtd.ValueChanged += new System.EventHandler(this.dtd_ValueChanged);
            // 
            // ChSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 207);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.st_n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.st_o);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poezd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reis);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.schedCh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChSched";
            this.Text = "Изменение расписания";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChSched_FormClosed);
            this.Load += new System.EventHandler(this.ChSched_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button schedCh;
        private System.Windows.Forms.TextBox reis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poezd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox st_o;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox st_n;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtd;
    }
}
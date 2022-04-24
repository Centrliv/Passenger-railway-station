namespace Passenger_railway_station
{
    partial class ChRoute
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
            this.rN = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.GroupBox();
            this.d = new System.Windows.Forms.RadioButton();
            this.p = new System.Windows.Forms.RadioButton();
            this.rCh = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.type.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // rN
            // 
            this.rN.Location = new System.Drawing.Point(15, 25);
            this.rN.Name = "rN";
            this.rN.Size = new System.Drawing.Size(257, 20);
            this.rN.TabIndex = 1;
            // 
            // type
            // 
            this.type.Controls.Add(this.d);
            this.type.Controls.Add(this.p);
            this.type.Location = new System.Drawing.Point(15, 62);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(256, 48);
            this.type.TabIndex = 2;
            this.type.TabStop = false;
            this.type.Text = "Тип следования:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(151, 19);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(70, 17);
            this.d.TabIndex = 1;
            this.d.Text = "Дальний";
            this.d.UseVisualStyleBackColor = true;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Checked = true;
            this.p.Location = new System.Drawing.Point(36, 19);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(94, 17);
            this.p.TabIndex = 0;
            this.p.TabStop = true;
            this.p.Text = "Пригородный";
            this.p.UseVisualStyleBackColor = true;
            // 
            // rCh
            // 
            this.rCh.Location = new System.Drawing.Point(15, 116);
            this.rCh.Name = "rCh";
            this.rCh.Size = new System.Drawing.Size(100, 29);
            this.rCh.TabIndex = 3;
            this.rCh.Text = "Изменить";
            this.rCh.UseVisualStyleBackColor = true;
            this.rCh.Click += new System.EventHandler(this.rCh_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(171, 116);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(100, 29);
            this.cl.TabIndex = 4;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // ChRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.rCh);
            this.Controls.Add(this.type);
            this.Controls.Add(this.rN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChRoute";
            this.Text = "Изменение маршрута";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRoute_FormClosed);
            this.Load += new System.EventHandler(this.ChRoute_Load);
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rN;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.RadioButton p;
        private System.Windows.Forms.Button rCh;
        private System.Windows.Forms.Button cl;
    }
}
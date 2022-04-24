namespace Passenger_railway_station
{
    partial class ChSt
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
            this.sN = new System.Windows.Forms.TextBox();
            this.sCh = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.sPl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sPk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sPp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sPs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // sN
            // 
            this.sN.Location = new System.Drawing.Point(15, 25);
            this.sN.Name = "sN";
            this.sN.Size = new System.Drawing.Size(257, 20);
            this.sN.TabIndex = 1;
            // 
            // sCh
            // 
            this.sCh.Location = new System.Drawing.Point(15, 129);
            this.sCh.Name = "sCh";
            this.sCh.Size = new System.Drawing.Size(107, 28);
            this.sCh.TabIndex = 4;
            this.sCh.Text = "Изменить";
            this.sCh.UseVisualStyleBackColor = true;
            this.sCh.Click += new System.EventHandler(this.sCh_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(165, 129);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(107, 28);
            this.cl.TabIndex = 5;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // sPl
            // 
            this.sPl.Location = new System.Drawing.Point(153, 103);
            this.sPl.MaxLength = 9;
            this.sPl.Name = "sPl";
            this.sPl.Size = new System.Drawing.Size(119, 20);
            this.sPl.TabIndex = 20;
            this.sPl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Цена СВ (люкс):";
            // 
            // sPk
            // 
            this.sPk.Location = new System.Drawing.Point(15, 103);
            this.sPk.MaxLength = 9;
            this.sPk.Name = "sPk";
            this.sPk.Size = new System.Drawing.Size(119, 20);
            this.sPk.TabIndex = 18;
            this.sPk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Цена купе:";
            // 
            // sPp
            // 
            this.sPp.Location = new System.Drawing.Point(153, 64);
            this.sPp.MaxLength = 9;
            this.sPp.Name = "sPp";
            this.sPp.Size = new System.Drawing.Size(119, 20);
            this.sPp.TabIndex = 16;
            this.sPp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена плацкарт:";
            // 
            // sPs
            // 
            this.sPs.Location = new System.Drawing.Point(15, 64);
            this.sPs.MaxLength = 9;
            this.sPs.Name = "sPs";
            this.sPs.Size = new System.Drawing.Size(119, 20);
            this.sPs.TabIndex = 14;
            this.sPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цена сидячий:";
            // 
            // ChSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.sPl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sPk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sPp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sPs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.sCh);
            this.Controls.Add(this.sN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChSt";
            this.Text = "Изменение станции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChSt_FormClosed);
            this.Load += new System.EventHandler(this.ChSt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sN;
        private System.Windows.Forms.Button sCh;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.TextBox sPl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sPk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sPp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sPs;
        private System.Windows.Forms.Label label6;
    }
}
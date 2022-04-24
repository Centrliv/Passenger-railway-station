namespace Passenger_railway_station
{
    partial class AddSt
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
            this.label2 = new System.Windows.Forms.Label();
            this.sAdd = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.sPs = new System.Windows.Forms.TextBox();
            this.sPp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sPk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sPl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена сидячий:";
            // 
            // sAdd
            // 
            this.sAdd.Location = new System.Drawing.Point(15, 129);
            this.sAdd.Name = "sAdd";
            this.sAdd.Size = new System.Drawing.Size(107, 28);
            this.sAdd.TabIndex = 4;
            this.sAdd.Text = "Добавить";
            this.sAdd.UseVisualStyleBackColor = true;
            this.sAdd.Click += new System.EventHandler(this.sAdd_Click);
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
            // sPs
            // 
            this.sPs.Location = new System.Drawing.Point(15, 64);
            this.sPs.MaxLength = 9;
            this.sPs.Name = "sPs";
            this.sPs.Size = new System.Drawing.Size(119, 20);
            this.sPs.TabIndex = 6;
            this.sPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sPs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sP_KeyPress);
            // 
            // sPp
            // 
            this.sPp.Location = new System.Drawing.Point(153, 64);
            this.sPp.MaxLength = 9;
            this.sPp.Name = "sPp";
            this.sPp.Size = new System.Drawing.Size(119, 20);
            this.sPp.TabIndex = 8;
            this.sPp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена плацкарт:";
            // 
            // sPk
            // 
            this.sPk.Location = new System.Drawing.Point(15, 103);
            this.sPk.MaxLength = 9;
            this.sPk.Name = "sPk";
            this.sPk.Size = new System.Drawing.Size(119, 20);
            this.sPk.TabIndex = 10;
            this.sPk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена купе:";
            // 
            // sPl
            // 
            this.sPl.Location = new System.Drawing.Point(153, 103);
            this.sPl.MaxLength = 9;
            this.sPl.Name = "sPl";
            this.sPl.Size = new System.Drawing.Size(119, 20);
            this.sPl.TabIndex = 12;
            this.sPl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цена СВ (люкс):";
            // 
            // AddSt
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
            this.Controls.Add(this.cl);
            this.Controls.Add(this.sAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSt";
            this.Text = "Добавление станции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddSt_FormClosed);
            this.Load += new System.EventHandler(this.AddSt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sAdd;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.TextBox sPs;
        private System.Windows.Forms.TextBox sPp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sPk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sPl;
        private System.Windows.Forms.Label label5;
    }
}
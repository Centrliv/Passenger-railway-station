namespace Passenger_railway_station
{
    partial class ChTrain
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
            this.label2 = new System.Windows.Forms.Label();
            this.tM = new System.Windows.Forms.TextBox();
            this.tN = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Button();
            this.trCh = new System.Windows.Forms.Button();
            this.tD = new System.Windows.Forms.DateTimePicker();
            this.type = new System.Windows.Forms.GroupBox();
            this.d = new System.Windows.Forms.RadioButton();
            this.p = new System.Windows.Forms.RadioButton();
            this.type.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серийный номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель:";
            // 
            // tM
            // 
            this.tM.Location = new System.Drawing.Point(12, 64);
            this.tM.Name = "tM";
            this.tM.Size = new System.Drawing.Size(260, 20);
            this.tM.TabIndex = 2;
            // 
            // tN
            // 
            this.tN.Location = new System.Drawing.Point(12, 25);
            this.tN.Mask = "AAAAA";
            this.tN.Name = "tN";
            this.tN.Size = new System.Drawing.Size(260, 20);
            this.tN.TabIndex = 4;
            this.tN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tN_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата ввода в эксплуатацию:";
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(164, 183);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(108, 28);
            this.cl.TabIndex = 10;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // trCh
            // 
            this.trCh.Location = new System.Drawing.Point(12, 183);
            this.trCh.Name = "trCh";
            this.trCh.Size = new System.Drawing.Size(108, 28);
            this.trCh.TabIndex = 9;
            this.trCh.Text = "Изменить";
            this.trCh.UseVisualStyleBackColor = true;
            this.trCh.Click += new System.EventHandler(this.facAdd_Click);
            // 
            // tD
            // 
            this.tD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tD.Location = new System.Drawing.Point(12, 103);
            this.tD.Name = "tD";
            this.tD.Size = new System.Drawing.Size(260, 20);
            this.tD.TabIndex = 11;
            this.tD.Value = new System.DateTime(2019, 12, 18, 16, 31, 33, 0);
            // 
            // type
            // 
            this.type.Controls.Add(this.d);
            this.type.Controls.Add(this.p);
            this.type.Location = new System.Drawing.Point(12, 129);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(260, 48);
            this.type.TabIndex = 13;
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
            // ChTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.type);
            this.Controls.Add(this.tD);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.trCh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tM);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChTrain";
            this.Text = "Изменение поезда";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTrain_FormClosed);
            this.Load += new System.EventHandler(this.ChTrain_Load);
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tM;
        private System.Windows.Forms.MaskedTextBox tN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button trCh;
        private System.Windows.Forms.DateTimePicker tD;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.RadioButton p;
    }
}
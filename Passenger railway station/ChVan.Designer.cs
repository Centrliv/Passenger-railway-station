namespace Passenger_railway_station
{
    partial class ChVan
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
            this.type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_v = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seats = new System.Windows.Forms.MaskedTextBox();
            this.vCl = new System.Windows.Forms.Button();
            this.vCh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Сидячий",
            "Плацкарт",
            "Купе",
            "СВ (люкс)"});
            this.type.Location = new System.Drawing.Point(119, 25);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(164, 21);
            this.type.TabIndex = 0;
            this.type.SelectedValueChanged += new System.EventHandler(this.type_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер вагона:";
            // 
            // id_v
            // 
            this.id_v.Location = new System.Drawing.Point(12, 25);
            this.id_v.Mask = "00000";
            this.id_v.Name = "id_v";
            this.id_v.Size = new System.Drawing.Size(94, 20);
            this.id_v.TabIndex = 2;
            this.id_v.MouseClick += new System.Windows.Forms.MouseEventHandler(this.id_v_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип размещения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество мест:";
            // 
            // seats
            // 
            this.seats.Enabled = false;
            this.seats.Location = new System.Drawing.Point(12, 74);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(94, 20);
            this.seats.TabIndex = 5;
            // 
            // vCl
            // 
            this.vCl.Location = new System.Drawing.Point(204, 66);
            this.vCl.Name = "vCl";
            this.vCl.Size = new System.Drawing.Size(79, 29);
            this.vCl.TabIndex = 11;
            this.vCl.Text = "Закрыть";
            this.vCl.UseVisualStyleBackColor = true;
            this.vCl.Click += new System.EventHandler(this.vCl_Click);
            // 
            // vCh
            // 
            this.vCh.Location = new System.Drawing.Point(119, 66);
            this.vCh.Name = "vCh";
            this.vCh.Size = new System.Drawing.Size(79, 29);
            this.vCh.TabIndex = 10;
            this.vCh.Text = "Изменить";
            this.vCh.UseVisualStyleBackColor = true;
            this.vCh.Click += new System.EventHandler(this.vCh_Click);
            // 
            // ChVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 107);
            this.Controls.Add(this.vCl);
            this.Controls.Add(this.vCh);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_v);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChVan";
            this.Text = "Изменение вагона";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddVan_FormClosed);
            this.Load += new System.EventHandler(this.AddVan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox id_v;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox seats;
        private System.Windows.Forms.Button vCl;
        private System.Windows.Forms.Button vCh;
    }
}
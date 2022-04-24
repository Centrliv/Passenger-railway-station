namespace Passenger_railway_station
{
    partial class KassirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KassirForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TicketsPrig = new System.Windows.Forms.Button();
            this.chUs = new System.Windows.Forms.Button();
            this.TicketsDal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TicketsPrig
            // 
            this.TicketsPrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketsPrig.Location = new System.Drawing.Point(273, 12);
            this.TicketsPrig.Name = "TicketsPrig";
            this.TicketsPrig.Size = new System.Drawing.Size(190, 43);
            this.TicketsPrig.TabIndex = 4;
            this.TicketsPrig.Text = "Продажа пригородных билетов";
            this.TicketsPrig.UseVisualStyleBackColor = true;
            this.TicketsPrig.Click += new System.EventHandler(this.TicketsPrig_Click);
            // 
            // chUs
            // 
            this.chUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chUs.Location = new System.Drawing.Point(273, 118);
            this.chUs.Name = "chUs";
            this.chUs.Size = new System.Drawing.Size(190, 31);
            this.chUs.TabIndex = 7;
            this.chUs.Text = "Смена пользователя";
            this.chUs.UseVisualStyleBackColor = true;
            this.chUs.Click += new System.EventHandler(this.chUs_Click);
            // 
            // TicketsDal
            // 
            this.TicketsDal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketsDal.Location = new System.Drawing.Point(273, 61);
            this.TicketsDal.Name = "TicketsDal";
            this.TicketsDal.Size = new System.Drawing.Size(190, 43);
            this.TicketsDal.TabIndex = 8;
            this.TicketsDal.Text = "Продажа билетов дельнего следования";
            this.TicketsDal.UseVisualStyleBackColor = true;
            this.TicketsDal.Click += new System.EventHandler(this.TicketsDal_Click);
            // 
            // KassirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 159);
            this.Controls.Add(this.TicketsDal);
            this.Controls.Add(this.chUs);
            this.Controls.Add(this.TicketsPrig);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KassirForm";
            this.Text = "Пассажирский железнодорожный вокзал";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TicketsPrig;
        private System.Windows.Forms.Button chUs;
        private System.Windows.Forms.Button TicketsDal;
    }
}
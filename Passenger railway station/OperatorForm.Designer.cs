namespace Passenger_railway_station
{
    partial class OperatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trips = new System.Windows.Forms.Button();
            this.Routes = new System.Windows.Forms.Button();
            this.Trains = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.Button();
            this.chUs = new System.Windows.Forms.Button();
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
            // Trips
            // 
            this.Trips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Trips.Location = new System.Drawing.Point(273, 110);
            this.Trips.Name = "Trips";
            this.Trips.Size = new System.Drawing.Size(190, 43);
            this.Trips.TabIndex = 2;
            this.Trips.Text = "Рейсы";
            this.Trips.UseVisualStyleBackColor = true;
            this.Trips.Click += new System.EventHandler(this.Trips_Click);
            // 
            // Routes
            // 
            this.Routes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Routes.Location = new System.Drawing.Point(273, 61);
            this.Routes.Name = "Routes";
            this.Routes.Size = new System.Drawing.Size(190, 43);
            this.Routes.TabIndex = 3;
            this.Routes.Text = "Маршруты";
            this.Routes.UseVisualStyleBackColor = true;
            this.Routes.Click += new System.EventHandler(this.Routes_Click);
            // 
            // Trains
            // 
            this.Trains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Trains.Location = new System.Drawing.Point(273, 12);
            this.Trains.Name = "Trains";
            this.Trains.Size = new System.Drawing.Size(190, 43);
            this.Trains.TabIndex = 4;
            this.Trains.Text = "Поезда";
            this.Trains.UseVisualStyleBackColor = true;
            this.Trains.Click += new System.EventHandler(this.Trains_Click);
            // 
            // Schedule
            // 
            this.Schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Schedule.Location = new System.Drawing.Point(12, 155);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(247, 43);
            this.Schedule.TabIndex = 5;
            this.Schedule.Text = "Расписание";
            this.Schedule.UseVisualStyleBackColor = true;
            this.Schedule.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // chUs
            // 
            this.chUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chUs.Location = new System.Drawing.Point(273, 167);
            this.chUs.Name = "chUs";
            this.chUs.Size = new System.Drawing.Size(190, 31);
            this.chUs.TabIndex = 7;
            this.chUs.Text = "Смена пользователя";
            this.chUs.UseVisualStyleBackColor = true;
            this.chUs.Click += new System.EventHandler(this.chUs_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 210);
            this.Controls.Add(this.chUs);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.Trains);
            this.Controls.Add(this.Routes);
            this.Controls.Add(this.Trips);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OperatorForm";
            this.Text = "Пассажирский железнодорожный вокзал";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Trips;
        private System.Windows.Forms.Button Routes;
        private System.Windows.Forms.Button Trains;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Button chUs;
    }
}
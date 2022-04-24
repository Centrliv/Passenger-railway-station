namespace Passenger_railway_station
{
    partial class ChUs
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
            this.uname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ugroup = new System.Windows.Forms.ComboBox();
            this.cl = new System.Windows.Forms.Button();
            this.ChUsr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.upass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(12, 63);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(262, 20);
            this.uname.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Роль:";
            // 
            // ugroup
            // 
            this.ugroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ugroup.FormattingEnabled = true;
            this.ugroup.Items.AddRange(new object[] {
            "Администратор",
            "Оператор",
            "Кассир"});
            this.ugroup.Location = new System.Drawing.Point(12, 23);
            this.ugroup.Name = "ugroup";
            this.ugroup.Size = new System.Drawing.Size(262, 21);
            this.ugroup.TabIndex = 14;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(164, 167);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(110, 30);
            this.cl.TabIndex = 23;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // ChUsr
            // 
            this.ChUsr.Location = new System.Drawing.Point(12, 167);
            this.ChUsr.Name = "ChUsr";
            this.ChUsr.Size = new System.Drawing.Size(110, 30);
            this.ChUsr.TabIndex = 22;
            this.ChUsr.Text = "Изменить";
            this.ChUsr.UseVisualStyleBackColor = true;
            this.ChUsr.Click += new System.EventHandler(this.ChUsr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Пароль:";
            // 
            // upass
            // 
            this.upass.Location = new System.Drawing.Point(12, 141);
            this.upass.Name = "upass";
            this.upass.Size = new System.Drawing.Size(262, 20);
            this.upass.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Логин:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 102);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(262, 20);
            this.username.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Фамилия И. О.:";
            // 
            // ChUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ugroup);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.ChUsr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChUs";
            this.Text = "Изменение пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChUs_FormClosed);
            this.Load += new System.EventHandler(this.ChUs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ugroup;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button ChUsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox upass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
    }
}
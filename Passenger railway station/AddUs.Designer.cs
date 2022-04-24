namespace Passenger_railway_station
{
    partial class AddUs
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
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUsr = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ugroup = new System.Windows.Forms.ComboBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия И. О.:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 102);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(262, 20);
            this.username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // upass
            // 
            this.upass.Location = new System.Drawing.Point(12, 141);
            this.upass.Name = "upass";
            this.upass.Size = new System.Drawing.Size(262, 20);
            this.upass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // AddUsr
            // 
            this.AddUsr.Location = new System.Drawing.Point(12, 167);
            this.AddUsr.Name = "AddUsr";
            this.AddUsr.Size = new System.Drawing.Size(110, 30);
            this.AddUsr.TabIndex = 6;
            this.AddUsr.Text = "Добавить";
            this.AddUsr.UseVisualStyleBackColor = true;
            this.AddUsr.Click += new System.EventHandler(this.AddUsr_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(164, 167);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(110, 30);
            this.cl.TabIndex = 7;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
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
            this.ugroup.TabIndex = 1;
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(12, 63);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(262, 20);
            this.uname.TabIndex = 2;
            // 
            // AddUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ugroup);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.AddUsr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUs";
            this.Text = "Добаление пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUs_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox upass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUsr;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ugroup;
        private System.Windows.Forms.TextBox uname;
    }
}
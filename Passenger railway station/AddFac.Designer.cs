namespace Passenger_railway_station
{
    partial class AddFac
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
            this.facTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.facInfo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.facSize = new System.Windows.Forms.NumericUpDown();
            this.facAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facSize)).BeginInit();
            this.SuspendLayout();
            // 
            // facTitle
            // 
            this.facTitle.Location = new System.Drawing.Point(12, 30);
            this.facTitle.Name = "facTitle";
            this.facTitle.Size = new System.Drawing.Size(271, 20);
            this.facTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Информация:";
            // 
            // facInfo
            // 
            this.facInfo.Location = new System.Drawing.Point(12, 105);
            this.facInfo.Name = "facInfo";
            this.facInfo.Size = new System.Drawing.Size(271, 96);
            this.facInfo.TabIndex = 4;
            this.facInfo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размер скидки, %:";
            // 
            // facSize
            // 
            this.facSize.Location = new System.Drawing.Point(163, 60);
            this.facSize.Name = "facSize";
            this.facSize.Size = new System.Drawing.Size(120, 20);
            this.facSize.TabIndex = 6;
            // 
            // facAdd
            // 
            this.facAdd.Location = new System.Drawing.Point(12, 207);
            this.facAdd.Name = "facAdd";
            this.facAdd.Size = new System.Drawing.Size(108, 28);
            this.facAdd.TabIndex = 7;
            this.facAdd.Text = "Добавить";
            this.facAdd.UseVisualStyleBackColor = true;
            this.facAdd.Click += new System.EventHandler(this.facAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 243);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.facAdd);
            this.Controls.Add(this.facSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.facInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFac";
            this.Text = "Добавление льготы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddFac_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.facSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox facTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox facInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown facSize;
        private System.Windows.Forms.Button facAdd;
        private System.Windows.Forms.Button button2;
    }
}
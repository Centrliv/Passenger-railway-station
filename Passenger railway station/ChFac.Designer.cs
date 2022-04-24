namespace Passenger_railway_station
{
    partial class ChFac
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
            this.cl = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.facSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // facTitle
            // 
            this.facTitle.Location = new System.Drawing.Point(12, 30);
            this.facTitle.Name = "facTitle";
            this.facTitle.Size = new System.Drawing.Size(271, 20);
            this.facTitle.TabIndex = 0;
            this.facTitle.TextChanged += new System.EventHandler(this.facTitle_TextChanged);
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
            this.facInfo.TabIndex = 2;
            this.facInfo.Text = "";
            this.facInfo.TextChanged += new System.EventHandler(this.facInfo_TextChanged);
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
            this.facSize.TabIndex = 1;
            this.facSize.ValueChanged += new System.EventHandler(this.facSize_ValueChanged);
            // 
            // facAdd
            // 
            this.facAdd.Location = new System.Drawing.Point(12, 207);
            this.facAdd.Name = "facAdd";
            this.facAdd.Size = new System.Drawing.Size(108, 28);
            this.facAdd.TabIndex = 3;
            this.facAdd.Text = "Изменить";
            this.facAdd.UseVisualStyleBackColor = true;
            this.facAdd.Click += new System.EventHandler(this.facAdd_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(175, 207);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(108, 28);
            this.cl.TabIndex = 4;
            this.cl.Text = "Закрыть";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 241);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(295, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // ChFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 263);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.facAdd);
            this.Controls.Add(this.facSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.facInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChFac";
            this.Text = "Добавление льготы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddFac_FormClosed);
            this.Load += new System.EventHandler(this.ChFac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
    }
}
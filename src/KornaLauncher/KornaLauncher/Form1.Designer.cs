namespace KornaLauncher
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stopB = new System.Windows.Forms.Button();
            this.showLogsB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playB
            // 
            this.playB.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.playB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.playB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playB.Location = new System.Drawing.Point(353, 150);
            this.playB.Name = "playB";
            this.playB.Size = new System.Drawing.Size(156, 46);
            this.playB.TabIndex = 1;
            this.playB.Text = "Oyna";
            this.playB.UseVisualStyleBackColor = true;
            this.playB.Click += new System.EventHandler(this.playB_Click);
            this.playB.MouseEnter += new System.EventHandler(this.playB_MouseEnter);
            this.playB.MouseLeave += new System.EventHandler(this.playB_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // stopB
            // 
            this.stopB.Enabled = false;
            this.stopB.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.stopB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stopB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.stopB.ForeColor = System.Drawing.Color.Firebrick;
            this.stopB.Location = new System.Drawing.Point(353, 98);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(156, 46);
            this.stopB.TabIndex = 4;
            this.stopB.Text = "Durdur ve Çık";
            this.stopB.UseVisualStyleBackColor = true;
            this.stopB.Visible = false;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // showLogsB
            // 
            this.showLogsB.Enabled = false;
            this.showLogsB.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.showLogsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.showLogsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showLogsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.showLogsB.ForeColor = System.Drawing.Color.Lime;
            this.showLogsB.Location = new System.Drawing.Point(206, 162);
            this.showLogsB.Name = "showLogsB";
            this.showLogsB.Size = new System.Drawing.Size(141, 34);
            this.showLogsB.TabIndex = 5;
            this.showLogsB.Text = "Logları Göster";
            this.showLogsB.UseVisualStyleBackColor = true;
            this.showLogsB.Visible = false;
            this.showLogsB.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(381, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "WEB\'de aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KornaLauncher.Properties.Resources.michaelsoft_games;
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(521, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showLogsB);
            this.Controls.Add(this.stopB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playB);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KornaLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button playB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Button showLogsB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}


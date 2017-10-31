namespace Bot
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
            this.cikti = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.guilds = new System.Windows.Forms.ComboBox();
            this.textc = new System.Windows.Forms.ComboBox();
            this.voicec = new System.Windows.Forms.ComboBox();
            this.users = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cikti
            // 
            this.cikti.Location = new System.Drawing.Point(12, 12);
            this.cikti.Name = "cikti";
            this.cikti.Size = new System.Drawing.Size(315, 148);
            this.cikti.TabIndex = 0;
            this.cikti.Text = "";
            this.cikti.TextChanged += new System.EventHandler(this.cikti_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guilds
            // 
            this.guilds.FormattingEnabled = true;
            this.guilds.Location = new System.Drawing.Point(382, 12);
            this.guilds.Name = "guilds";
            this.guilds.Size = new System.Drawing.Size(121, 21);
            this.guilds.TabIndex = 2;
            this.guilds.SelectedIndexChanged += new System.EventHandler(this.guilds_SelectedIndexChanged);
            // 
            // textc
            // 
            this.textc.FormattingEnabled = true;
            this.textc.Location = new System.Drawing.Point(382, 39);
            this.textc.Name = "textc";
            this.textc.Size = new System.Drawing.Size(121, 21);
            this.textc.TabIndex = 3;
            // 
            // voicec
            // 
            this.voicec.FormattingEnabled = true;
            this.voicec.Location = new System.Drawing.Point(382, 66);
            this.voicec.Name = "voicec";
            this.voicec.Size = new System.Drawing.Size(121, 21);
            this.voicec.TabIndex = 4;
            // 
            // users
            // 
            this.users.FormattingEnabled = true;
            this.users.Location = new System.Drawing.Point(382, 93);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(121, 21);
            this.users.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 203);
            this.Controls.Add(this.users);
            this.Controls.Add(this.voicec);
            this.Controls.Add(this.textc);
            this.Controls.Add(this.guilds);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cikti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox guilds;
        private System.Windows.Forms.ComboBox textc;
        private System.Windows.Forms.ComboBox voicec;
        private System.Windows.Forms.ComboBox users;
    }
}


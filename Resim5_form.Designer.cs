namespace PROJE1
{
    partial class Resim5_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button_sec = new System.Windows.Forms.Button();
            this.button_kaldır = new System.Windows.Forms.Button();
            this.button_uygula = new System.Windows.Forms.Button();
            this.button_kontrol = new System.Windows.Forms.Button();
            this.listBox_seçim = new System.Windows.Forms.ListBox();
            this.listBox_hazır = new System.Windows.Forms.ListBox();
            this.listBox_sonuc = new System.Windows.Forms.ListBox();
            this.button_geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJE1.Properties.Resources.soket_f;
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(551, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(177, 94);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(734, 4);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(165, 94);
            this.checkedListBox2.TabIndex = 2;
            // 
            // button_sec
            // 
            this.button_sec.BackColor = System.Drawing.Color.Black;
            this.button_sec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sec.ForeColor = System.Drawing.Color.White;
            this.button_sec.Location = new System.Drawing.Point(551, 104);
            this.button_sec.Name = "button_sec";
            this.button_sec.Size = new System.Drawing.Size(83, 23);
            this.button_sec.TabIndex = 3;
            this.button_sec.Text = "Hepsini Seç";
            this.button_sec.UseVisualStyleBackColor = false;
            this.button_sec.Click += new System.EventHandler(this.button_sec_Click);
            // 
            // button_kaldır
            // 
            this.button_kaldır.BackColor = System.Drawing.Color.Black;
            this.button_kaldır.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kaldır.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaldır.ForeColor = System.Drawing.Color.White;
            this.button_kaldır.Location = new System.Drawing.Point(639, 104);
            this.button_kaldır.Name = "button_kaldır";
            this.button_kaldır.Size = new System.Drawing.Size(89, 23);
            this.button_kaldır.TabIndex = 4;
            this.button_kaldır.Text = "Seçimi Kaldır";
            this.button_kaldır.UseVisualStyleBackColor = false;
            this.button_kaldır.Click += new System.EventHandler(this.button_kaldır_Click);
            // 
            // button_uygula
            // 
            this.button_uygula.BackColor = System.Drawing.Color.Black;
            this.button_uygula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_uygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_uygula.ForeColor = System.Drawing.Color.White;
            this.button_uygula.Location = new System.Drawing.Point(741, 104);
            this.button_uygula.Name = "button_uygula";
            this.button_uygula.Size = new System.Drawing.Size(76, 23);
            this.button_uygula.TabIndex = 5;
            this.button_uygula.Text = "Uygula";
            this.button_uygula.UseVisualStyleBackColor = false;
            this.button_uygula.Click += new System.EventHandler(this.button_uygula_Click);
            // 
            // button_kontrol
            // 
            this.button_kontrol.BackColor = System.Drawing.Color.Black;
            this.button_kontrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kontrol.ForeColor = System.Drawing.Color.White;
            this.button_kontrol.Location = new System.Drawing.Point(823, 104);
            this.button_kontrol.Name = "button_kontrol";
            this.button_kontrol.Size = new System.Drawing.Size(76, 23);
            this.button_kontrol.TabIndex = 6;
            this.button_kontrol.Text = "Kontrol Et";
            this.button_kontrol.UseVisualStyleBackColor = false;
            this.button_kontrol.Click += new System.EventHandler(this.button_kontrol_Click);
            // 
            // listBox_seçim
            // 
            this.listBox_seçim.FormattingEnabled = true;
            this.listBox_seçim.Location = new System.Drawing.Point(551, 176);
            this.listBox_seçim.Name = "listBox_seçim";
            this.listBox_seçim.Size = new System.Drawing.Size(83, 225);
            this.listBox_seçim.TabIndex = 7;
            // 
            // listBox_hazır
            // 
            this.listBox_hazır.FormattingEnabled = true;
            this.listBox_hazır.Location = new System.Drawing.Point(645, 175);
            this.listBox_hazır.Name = "listBox_hazır";
            this.listBox_hazır.Size = new System.Drawing.Size(83, 225);
            this.listBox_hazır.TabIndex = 8;
            // 
            // listBox_sonuc
            // 
            this.listBox_sonuc.FormattingEnabled = true;
            this.listBox_sonuc.Location = new System.Drawing.Point(741, 175);
            this.listBox_sonuc.Name = "listBox_sonuc";
            this.listBox_sonuc.Size = new System.Drawing.Size(158, 225);
            this.listBox_sonuc.TabIndex = 9;
            // 
            // button_geri
            // 
            this.button_geri.BackColor = System.Drawing.Color.Black;
            this.button_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_geri.ForeColor = System.Drawing.Color.White;
            this.button_geri.Location = new System.Drawing.Point(823, 406);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(76, 23);
            this.button_geri.TabIndex = 10;
            this.button_geri.Text = "Geri";
            this.button_geri.UseVisualStyleBackColor = false;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(548, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seçim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(642, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(738, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kontrol Sonuç";
            // 
            // Resim5_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.listBox_sonuc);
            this.Controls.Add(this.listBox_hazır);
            this.Controls.Add(this.listBox_seçim);
            this.Controls.Add(this.button_kontrol);
            this.Controls.Add(this.button_uygula);
            this.Controls.Add(this.button_kaldır);
            this.Controls.Add(this.button_sec);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Resim5_form";
            this.Text = "Resim5_form";
            this.Load += new System.EventHandler(this.Resim3_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button button_sec;
        private System.Windows.Forms.Button button_kaldır;
        private System.Windows.Forms.Button button_uygula;
        private System.Windows.Forms.Button button_kontrol;
        private System.Windows.Forms.ListBox listBox_seçim;
        private System.Windows.Forms.ListBox listBox_hazır;
        private System.Windows.Forms.ListBox listBox_sonuc;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
namespace PROJE1
{
    partial class resim1_form
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnDene = new System.Windows.Forms.Button();
            this.listbox_dene = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJE1.Properties.Resources.soket_a;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Location = new System.Drawing.Point(748, 29);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 23);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(93, 199);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(173, 107);
            this.btn1.TabIndex = 3;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(272, 199);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(165, 107);
            this.btn2.TabIndex = 4;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(443, 199);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(165, 107);
            this.btn3.TabIndex = 5;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(723, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Location = new System.Drawing.Point(768, 187);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(712, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 95);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(713, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Koordinat Bilgileri:";
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.Location = new System.Drawing.Point(768, 384);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 10;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kapat.Location = new System.Drawing.Point(768, 413);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat.TabIndex = 11;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(712, 216);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(131, 121);
            this.listBox2.TabIndex = 12;
            // 
            // btn_listele
            // 
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listele.Location = new System.Drawing.Point(768, 343);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 13;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(93, 342);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(32, 20);
            this.txt1.TabIndex = 14;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(272, 343);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(32, 20);
            this.txt2.TabIndex = 15;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(443, 343);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(32, 20);
            this.txt3.TabIndex = 16;
            // 
            // btnDene
            // 
            this.btnDene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDene.Location = new System.Drawing.Point(712, 404);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(50, 23);
            this.btnDene.TabIndex = 17;
            this.btnDene.Text = "DENE";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // listbox_dene
            // 
            this.listbox_dene.FormattingEnabled = true;
            this.listbox_dene.Location = new System.Drawing.Point(709, 341);
            this.listbox_dene.Name = "listbox_dene";
            this.listbox_dene.Size = new System.Drawing.Size(53, 56);
            this.listbox_dene.TabIndex = 18;
            // 
            // resim1_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 439);
            this.Controls.Add(this.listbox_dene);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "resim1_form";
            this.Text = "Resim1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnDene;
        private System.Windows.Forms.ListBox listbox_dene;
    }
}
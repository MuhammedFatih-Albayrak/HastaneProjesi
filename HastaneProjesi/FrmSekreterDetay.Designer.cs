namespace HastaneProjesi
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.richTextBoxDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBranslar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnRandevuPaneli = new System.Windows.Forms.Button();
            this.BtnBransPaneli = new System.Windows.Forms.Button();
            this.BtnDoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranslar)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(131, 100);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(109, 29);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(131, 50);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(145, 29);
            this.LblTC.TabIndex = 2;
            this.LblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOlustur);
            this.groupBox2.Controls.Add(this.richTextBoxDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(13, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOlustur.Location = new System.Drawing.Point(32, 297);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(253, 65);
            this.BtnOlustur.TabIndex = 1;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // richTextBoxDuyuru
            // 
            this.richTextBoxDuyuru.Location = new System.Drawing.Point(11, 46);
            this.richTextBoxDuyuru.Name = "richTextBoxDuyuru";
            this.richTextBoxDuyuru.Size = new System.Drawing.Size(292, 245);
            this.richTextBoxDuyuru.TabIndex = 0;
            this.richTextBoxDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.MskTC);
            this.groupBox3.Controls.Add(this.checkBoxDurum);
            this.groupBox3.Controls.Add(this.CmbDoktor);
            this.groupBox3.Controls.Add(this.CmbBrans);
            this.groupBox3.Controls.Add(this.MskSaat);
            this.groupBox3.Controls.Add(this.MskTarih);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(340, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 559);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Location = new System.Drawing.Point(116, 437);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(194, 76);
            this.BtnKaydet.TabIndex = 17;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Location = new System.Drawing.Point(64, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "TC:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(116, 309);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(194, 35);
            this.MskTC.TabIndex = 13;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Location = new System.Drawing.Point(116, 350);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(108, 33);
            this.checkBoxDurum.TabIndex = 12;
            this.checkBoxDurum.Text = "Durum";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(116, 268);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(194, 35);
            this.CmbDoktor.TabIndex = 11;
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(116, 226);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(194, 35);
            this.CmbBrans.TabIndex = 10;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(116, 184);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(194, 35);
            this.MskSaat.TabIndex = 9;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            this.MskSaat.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskSaat_MaskInputRejected);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(116, 142);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(194, 35);
            this.MskTarih.TabIndex = 8;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(116, 100);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(194, 35);
            this.Txtid.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(21, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewBranslar);
            this.groupBox4.Location = new System.Drawing.Point(689, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 283);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridViewBranslar
            // 
            this.dataGridViewBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBranslar.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewBranslar.Name = "dataGridViewBranslar";
            this.dataGridViewBranslar.RowTemplate.Height = 24;
            this.dataGridViewBranslar.Size = new System.Drawing.Size(544, 249);
            this.dataGridViewBranslar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewDoktorlar);
            this.groupBox5.Location = new System.Drawing.Point(692, 289);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(547, 275);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridViewDoktorlar
            // 
            this.dataGridViewDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoktorlar.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewDoktorlar.Name = "dataGridViewDoktorlar";
            this.dataGridViewDoktorlar.RowTemplate.Height = 24;
            this.dataGridViewDoktorlar.Size = new System.Drawing.Size(541, 241);
            this.dataGridViewDoktorlar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnRandevuPaneli);
            this.groupBox6.Controls.Add(this.BtnBransPaneli);
            this.groupBox6.Controls.Add(this.BtnDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(13, 565);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1226, 114);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(932, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 56);
            this.button1.TabIndex = 21;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRandevuPaneli
            // 
            this.BtnRandevuPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRandevuPaneli.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandevuPaneli.Location = new System.Drawing.Point(628, 34);
            this.BtnRandevuPaneli.Name = "BtnRandevuPaneli";
            this.BtnRandevuPaneli.Size = new System.Drawing.Size(280, 56);
            this.BtnRandevuPaneli.TabIndex = 20;
            this.BtnRandevuPaneli.Text = "Randevu Paneli";
            this.BtnRandevuPaneli.UseVisualStyleBackColor = false;
            this.BtnRandevuPaneli.Click += new System.EventHandler(this.BtnRandevuPaneli_Click);
            // 
            // BtnBransPaneli
            // 
            this.BtnBransPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnBransPaneli.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBransPaneli.Location = new System.Drawing.Point(327, 34);
            this.BtnBransPaneli.Name = "BtnBransPaneli";
            this.BtnBransPaneli.Size = new System.Drawing.Size(280, 56);
            this.BtnBransPaneli.TabIndex = 19;
            this.BtnBransPaneli.Text = "Branş Paneli";
            this.BtnBransPaneli.UseVisualStyleBackColor = false;
            this.BtnBransPaneli.Click += new System.EventHandler(this.BtnBransPaneli_Click);
            // 
            // BtnDoktorPaneli
            // 
            this.BtnDoktorPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnDoktorPaneli.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoktorPaneli.ForeColor = System.Drawing.Color.Black;
            this.BtnDoktorPaneli.Location = new System.Drawing.Point(23, 34);
            this.BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            this.BtnDoktorPaneli.Size = new System.Drawing.Size(280, 56);
            this.BtnDoktorPaneli.TabIndex = 18;
            this.BtnDoktorPaneli.Text = "Doktor Paneli";
            this.BtnDoktorPaneli.UseVisualStyleBackColor = false;
            this.BtnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1251, 686);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranslar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.RichTextBox richTextBoxDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewBranslar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewDoktorlar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRandevuPaneli;
        private System.Windows.Forms.Button BtnBransPaneli;
        private System.Windows.Forms.Button BtnDoktorPaneli;
        private System.Windows.Forms.Button button1;
    }
}
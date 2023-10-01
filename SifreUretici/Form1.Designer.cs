namespace SifreUretici
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudUzunluk = new NumericUpDown();
            nudSayi = new NumericUpDown();
            lblSifreUzunlugu = new Label();
            lblSifreSayisi = new Label();
            grpSifre = new GroupBox();
            btnUret = new Button();
            cboxOzelKarakter = new CheckBox();
            cboxRakam = new CheckBox();
            cboxBuyukHarf = new CheckBox();
            cboxKucukHarf = new CheckBox();
            lboxSifreler = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudUzunluk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSayi).BeginInit();
            grpSifre.SuspendLayout();
            SuspendLayout();
            // 
            // nudUzunluk
            // 
            nudUzunluk.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nudUzunluk.Location = new Point(263, 369);
            nudUzunluk.Name = "nudUzunluk";
            nudUzunluk.Size = new Size(150, 32);
            nudUzunluk.TabIndex = 0;
            // 
            // nudSayi
            // 
            nudSayi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nudSayi.Location = new Point(263, 431);
            nudSayi.Name = "nudSayi";
            nudSayi.Size = new Size(150, 32);
            nudSayi.TabIndex = 1;
            // 
            // lblSifreUzunlugu
            // 
            lblSifreUzunlugu.AutoSize = true;
            lblSifreUzunlugu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifreUzunlugu.Location = new Point(21, 371);
            lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            lblSifreUzunlugu.Size = new Size(146, 25);
            lblSifreUzunlugu.TabIndex = 2;
            lblSifreUzunlugu.Text = "Şifre Uzunluğu :";
            // 
            // lblSifreSayisi
            // 
            lblSifreSayisi.AutoSize = true;
            lblSifreSayisi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifreSayisi.Location = new Point(21, 433);
            lblSifreSayisi.Name = "lblSifreSayisi";
            lblSifreSayisi.Size = new Size(111, 25);
            lblSifreSayisi.TabIndex = 3;
            lblSifreSayisi.Text = "Şifre Sayısı :";
            // 
            // grpSifre
            // 
            grpSifre.Controls.Add(btnUret);
            grpSifre.Controls.Add(cboxOzelKarakter);
            grpSifre.Controls.Add(cboxRakam);
            grpSifre.Controls.Add(cboxBuyukHarf);
            grpSifre.Controls.Add(cboxKucukHarf);
            grpSifre.Controls.Add(nudUzunluk);
            grpSifre.Controls.Add(lblSifreSayisi);
            grpSifre.Controls.Add(nudSayi);
            grpSifre.Controls.Add(lblSifreUzunlugu);
            grpSifre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpSifre.Location = new Point(12, 12);
            grpSifre.Name = "grpSifre";
            grpSifre.Size = new Size(460, 616);
            grpSifre.TabIndex = 4;
            grpSifre.TabStop = false;
            grpSifre.Text = "PARAMETRELER";
            // 
            // btnUret
            // 
            btnUret.Location = new Point(21, 503);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(392, 65);
            btnUret.TabIndex = 5;
            btnUret.Text = "ÜRET";
            btnUret.UseVisualStyleBackColor = true;
            btnUret.Click += btnUret_Click;
            // 
            // cboxOzelKarakter
            // 
            cboxOzelKarakter.AutoSize = true;
            cboxOzelKarakter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboxOzelKarakter.Location = new Point(21, 273);
            cboxOzelKarakter.Name = "cboxOzelKarakter";
            cboxOzelKarakter.Size = new Size(147, 29);
            cboxOzelKarakter.TabIndex = 4;
            cboxOzelKarakter.Text = "Özel Karakter";
            cboxOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // cboxRakam
            // 
            cboxRakam.AutoSize = true;
            cboxRakam.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboxRakam.Location = new Point(21, 208);
            cboxRakam.Name = "cboxRakam";
            cboxRakam.Size = new Size(90, 29);
            cboxRakam.TabIndex = 4;
            cboxRakam.Text = "Rakam";
            cboxRakam.UseVisualStyleBackColor = true;
            // 
            // cboxBuyukHarf
            // 
            cboxBuyukHarf.AutoSize = true;
            cboxBuyukHarf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboxBuyukHarf.Location = new Point(21, 143);
            cboxBuyukHarf.Name = "cboxBuyukHarf";
            cboxBuyukHarf.Size = new Size(126, 29);
            cboxBuyukHarf.TabIndex = 4;
            cboxBuyukHarf.Text = "Büyük Harf";
            cboxBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cboxKucukHarf
            // 
            cboxKucukHarf.AutoSize = true;
            cboxKucukHarf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboxKucukHarf.Location = new Point(21, 78);
            cboxKucukHarf.Name = "cboxKucukHarf";
            cboxKucukHarf.Size = new Size(126, 29);
            cboxKucukHarf.TabIndex = 4;
            cboxKucukHarf.Text = "Küçük Harf";
            cboxKucukHarf.UseVisualStyleBackColor = true;
            // 
            // lboxSifreler
            // 
            lboxSifreler.FormattingEnabled = true;
            lboxSifreler.ItemHeight = 20;
            lboxSifreler.Location = new Point(478, 24);
            lboxSifreler.Name = "lboxSifreler";
            lboxSifreler.Size = new Size(480, 604);
            lboxSifreler.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 645);
            Controls.Add(lboxSifreler);
            Controls.Add(grpSifre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudUzunluk).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSayi).EndInit();
            grpSifre.ResumeLayout(false);
            grpSifre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nudUzunluk;
        private NumericUpDown nudSayi;
        private Label lblSifreUzunlugu;
        private Label lblSifreSayisi;
        private GroupBox grpSifre;
        private Button btnUret;
        private CheckBox cboxOzelKarakter;
        private CheckBox cboxRakam;
        private CheckBox cboxBuyukHarf;
        private CheckBox cboxKucukHarf;
        private ListBox lboxSifreler;
    }
}
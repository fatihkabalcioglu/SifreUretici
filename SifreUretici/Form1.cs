using System.Runtime.InteropServices;
using System;
using System.Text;

namespace SifreUretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnUret_Click(object sender, EventArgs e)
        {
            string sifre = "";
            string buyukHarf = "abcdefghijklmnopqursuvwxyz";
            string kucukHarf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string rakam = "1234567890";
            string ozelKarakter = @"~!@#$%^&*()+=-";


            int sifreUzunlugu = (int)nudUzunluk.Value;
            int sifreSayisi = (int)nudSayi.Value;

            if (cboxKucukHarf.Checked == true)
            {
                sifre += kucukHarf;
            }

            if (cboxBuyukHarf.Checked == true)
            {
                sifre += buyukHarf;
            }

            if (cboxRakam.Checked == true)
            {
                sifre += rakam;
            }

            if (cboxOzelKarakter.Checked == true)
            {
                sifre += ozelKarakter;
            }

            Random rnd = new Random();
            StringBuilder sifreOlusturucu = new StringBuilder();

            for (int i = 0; i < sifreSayisi; i++)
            {
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    int index = rnd.Next(sifre.Length);
                    sifreOlusturucu.Append(sifre[index]);
                }
                lboxSifreler.Items.Add(sifreOlusturucu.ToString());
                sifreOlusturucu.Clear();
            }
        }
    }
}
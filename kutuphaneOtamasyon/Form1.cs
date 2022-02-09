using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtamasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelenAd = txtKullaniciAd.Text;
            string gelenSifre = txtSifre.Text;
            kutuphaneOtamasyonEntities db = new kutuphaneOtamasyonEntities();
            var personel = db.Personeller.Where(x => x.Personel_KullaniciAdi.Equals(gelenAd) && x.Personel_Sifre.Equals(gelenSifre));
            if (personel==null)
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI LÜTFEN TEKRAR DENEYİNİZ");
            }
            else
            {
                MessageBox.Show("HOŞ GELDİNİZ");
                IslemPaneli ıslemPaneli = new IslemPaneli();
                ıslemPaneli.Show();
                this.Hide();
            }
        }
    }
}

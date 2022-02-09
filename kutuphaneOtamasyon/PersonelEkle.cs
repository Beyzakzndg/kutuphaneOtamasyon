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
    public partial class PersonelEkle : Form
    {
        kutuphaneOtamasyonEntities db = new kutuphaneOtamasyonEntities();
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Personel_Ad = txtPersonelAd.Text;
            personeller.Personel_Soyad = txtPersonelSoyad.Text;
            personeller.Personel_Tc = txtPersonelKimlik.Text;
            personeller.Persone_Tel = txtPersonelTel.Text;
            personeller.Personel_Mail = txtPersonelMail.Text;
            personeller.Personel_Adres = txtPersonelAdres.Text;
            personeller.Personel_KullaniciAdi = txtPersonelKullanici.Text;
            personeller.Personel_Sifre = txtPersonelSifre.Text;
            if (radioE.Checked==true)
            {
                personeller.Personel_Cinsiyet = "ERKEK";
            }
            else if (radioK.Checked==true)
            {
                personeller.Personel_Cinsiyet = "KIZ";
            }
            db.Personeller.Add(personeller);
            db.SaveChanges();
            Listele();
        }
        public void Listele()
        {
            
            var personel = db.Personeller.ToList();
            dataGridView1.DataSource = personel.ToList();
        }
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

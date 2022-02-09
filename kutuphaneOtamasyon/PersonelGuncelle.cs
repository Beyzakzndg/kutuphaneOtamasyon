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
    public partial class PersonelGuncelle : Form
    {
        kutuphaneOtamasyonEntities db = new kutuphaneOtamasyonEntities();
        public PersonelGuncelle()
        {
            InitializeComponent();
        }
        public void Listele()
        {

            var personel = db.Personeller.ToList();
            dataGridView1.DataSource = personel.ToList();
        }
        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPersonelSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPersonelTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPersonelMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPersonelAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPersonelKullanici.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtPersonelSifre.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[9].Value.ToString().Equals("Erkek"))
                radioE.Checked = true;

            else
                radioK.Checked =true;
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var personel = db.Personeller.Where(x => x.Personel_Id == secilenId).FirstOrDefault();
            personel.Personel_Ad = txtPersonelAd.Text;
            personel.Personel_Soyad = txtPersonelSoyad.Text;
            personel.Persone_Tel = txtPersonelTel.Text;
            personel.Personel_Mail = txtPersonelMail.Text;
            personel.Personel_Adres = txtPersonelAdres.Text;
            personel.Personel_KullaniciAdi = txtPersonelKullanici.Text;
            personel.Personel_Sifre = txtPersonelSifre.Text;
            if (radioE.Checked==true)
            {
                personel.Personel_Cinsiyet = "Erkek";
            }
            else
            {
                personel.Personel_Cinsiyet = "Kız";
            }
            db.SaveChanges();
            Listele();
        }
    }
}

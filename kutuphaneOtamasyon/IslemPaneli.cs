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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            btnPersonelEkle.Visible = false;
            btnPersonelGuncelle.Visible = false;
            btnPersonelSil.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnPersonelEkle.Visible == false)
            {
                btnPersonelEkle.Visible = true;
                btnPersonelGuncelle.Visible = true;
                btnPersonelSil.Visible = true;
            }
            PersonelListele pListe = new PersonelListele();
            pListe.MdiParent = this;
            pListe.Show();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.MdiParent = this;
            personelEkle.Show();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            PersonelSil personelSil = new PersonelSil();
            personelSil.MdiParent = this;
            personelSil.Show();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle personelGuncelle = new PersonelGuncelle();
            personelGuncelle.MdiParent = this;
            personelGuncelle.Show();
        }
    }
}

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
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            kutuphaneOtamasyonEntities db = new kutuphaneOtamasyonEntities();
            var personel = db.Personeller.ToList();
            dataGridView1.DataSource = personel.ToList();
        }
        private void PersonelListele_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

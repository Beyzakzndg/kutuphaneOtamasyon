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
    public partial class PersonelSil : Form
    {
        kutuphaneOtamasyonEntities db = new kutuphaneOtamasyonEntities();
        public PersonelSil()
        {
            InitializeComponent();
        }
        public void Listele()
        {
           
            var personel = db.Personeller.ToList();
            dataGridView1.DataSource = personel.ToList();
        }
        private void PersonelSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var personel = db.Personeller.Where(x => x.Personel_Id == secilenId).FirstOrDefault();
            db.Personeller.Remove(personel);
            db.SaveChanges();
            Listele();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        
            void firmalar()
            {
                var degerler = from x in db.TblFirmalar
                               select new
                               {
                                   x.ID,
                                   x.Ad,
                                   x.Yetkili,
                                   x.Telefon,
                                   x.Mail,
                                   x.Sektor,
                                   x.il,
                                   x.Adres
                                   
                               };
                gridControl1.DataSource = degerler.ToList();

            }

        

        private void BtnListele_Click(object sender, EventArgs e)
        {
            firmalar();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblFirmalar t = new TblFirmalar();
            t.Ad = txtAd.Text;
            t.Yetkili = txtYetkili.Text;
            t.Mail = txtMail.Text;
            t.Telefon = txtTelefon.Text;
            t.Sektor = txtSektor.Text;
            db.TblFirmalar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Firma Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           firmalar();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtAd.Text);
            var deger = db.TblFirmalar.Find(x);
            db.SaveChanges();
            XtraMessageBox.Show("Personel Başarıyla Silindi, silinen personeller listesinden tüm silinmis personel bilgilerine ulaşabilirsiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firmalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtYetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtSektor.Text = gridView1.GetFocusedRowCellValue("Sektor").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtAd.Text);
            var deger = db.TblFirmalar.Find(x);
            deger.Ad = txtAd.Text;
            deger.Yetkili = txtYetkili.Text;
            deger.Mail = txtMail.Text;
            deger.Telefon = txtTelefon.Text;
            deger.Sektor = txtSektor.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Personel Başarıyla Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            firmalar();
        }
    }
}

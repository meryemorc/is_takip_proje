using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.Aciklama
                                       }).ToList();

            lblAktifGorev.Text = db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            lblPasifGorev.Text = db.TblGorevler.Where(x => x.Durum == false).Count().ToString();
            lblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Durumlar", int.Parse(lblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Durumlar", int.Parse(lblPasifGorev.Text));


        }
    }
}

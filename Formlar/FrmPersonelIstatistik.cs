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
    public partial class FrmPersonelIstatistik : Form
    {
        public FrmPersonelIstatistik()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            lblDepartman.Text = db.TblDepartmanlar.Count().ToString();
            lblFirma.Text = db.TblFirmalar.Count().ToString();
            lblToplamPersonel.Text = db.TblPersonel.Count().ToString();
            lblAktif.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            lblPasif.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();
            LblSonGörev.Text = db.TblGorevler.OrderByDescending(x=>x.ID).Select(x => x.Aciklama).FirstOrDefault();
            lblSonGorevTarih.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            lblSehir.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            LblSektor.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblBugunAcilan.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y=>y.Key).FirstOrDefault();
            lblAyınPersoneli.Text = db.TblPersonel.Where(x => x.ID == d1).Select(y => y.Ad + y.Soyad).FirstOrDefault().ToString();
            lblAyınDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == db.TblPersonel.Where(t =>t.ID==d1).Select(z=>z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
        }
    }
}

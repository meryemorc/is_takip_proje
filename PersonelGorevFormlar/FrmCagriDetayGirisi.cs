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

namespace is_takip_proje.PersonelGorevFormlar
{
    public partial class FrmCagriDetayGirisi : Form
    {
        public FrmCagriDetayGirisi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        public int id;
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
        {
            txtCagriId.Enabled = false;
            txtCagriId.Text = id.ToString();
            string saat, tarih;
            tarih =DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            txtTarih.Text = tarih;
            txtSaat.Text = saat;
        }
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(txtCagriId.Text);
            t.Saat = txtSaat.Text;
            t.Tarih =DateTime.Parse(txtTarih.Text);
            t.Aciklama = txtAciklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı detayı başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

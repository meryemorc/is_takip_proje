using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblGorevler t = new TblGorevler();
            t.Aciklama =txtAciklama.Text;
            t.Durum = checkEdit1.Checked;
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih = DateTime.Parse(txtTarih.Text);
            t.GorevVeren = 1;
            db.TblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblPersonel
                                select new
                                {
                                    x.ID,
                                    AdSoyad = x.Ad +" "+ x.Soyad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;
        }
    }
}

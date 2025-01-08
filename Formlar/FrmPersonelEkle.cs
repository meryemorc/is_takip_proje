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
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            TblPersonel t = new TblPersonel();
            t.Ad = txtAd.Text;
            t.Soyad = txtSoyad.Text;
            t.Mail = txtMail.Text;
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblPersonel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Personel Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

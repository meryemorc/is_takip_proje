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

namespace is_takip_proje.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        //PersonelGorevFormlar.FrmPersonelFormu frm = new PersonelGorevFormlar.FrmPersonelFormu();

        DbisTakipEntities db = new DbisTakipEntities();
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == txtKullanici.Text
            && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (adminvalue != null)
            {
                XtraMessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonel.Where(x => x.Mail == txtKullanici.Text
         && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                XtraMessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PersonelGorevFormlar.FrmPersonelFormu fr = new PersonelGorevFormlar.FrmPersonelFormu();
                fr.mail=txtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

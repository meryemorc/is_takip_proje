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

namespace is_takip_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanlar frm = new Formlar.FrmDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller frm2 = new Formlar.FrmPersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void BtnPersonelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.FrmPersonelIstatistik frm3 = new Formlar.FrmPersonelIstatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }
        Formlar.FrmGorevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)  { 
                frm4 = new Formlar.FrmGorevListesi();
            frm4.MdiParent = this;
            frm4.Show();
            }
        }

        private void BtnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev fr = new Formlar.FrmGorev();
            fr.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay fr = new Formlar.FrmGorevDetay();
            fr.Show();
        }
        Formlar.FrmAnaForm frm5;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.FrmAnaForm();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
        Formlar.FrmAktifCagrilar fr;
        private void btnAktifCagrılar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if ( fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        Formlar.FrmPasifCagrilar frm6;
        private void btnPasifCagrılar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Formlar.FrmPasifCagrilar();
                frm6.MdiParent = this;
                frm6.Show();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanEkle frm = new Formlar.FrmDepartmanEkle();
            frm.Show();
        }

        private void btnPersonelEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelEkle frm = new Formlar.FrmPersonelEkle();
            frm.Show();
        }

        private void BtnFirmaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFirmalar frm = new Formlar.FrmFirmalar();
            frm.MdiParent = this;
            frm.Show();
        }

        

        private void btnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar frm = new Formlar.FrmKurlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Projede alacağınız her türlü hata için test@gmail.com mail adresi üzerinden bize ulaşabilirsiniz.\nBuna ek olarak +90 (123) (45-67) numaralı telefondan direkt arayarak veya Whatsapp uygulaması üzerinden sorularınızı bize iletirseniz en hızlı şekilde dönüş sağlayıp probleminizi çözmeniz için yardımcı olabiliriz.", 
            "Bilgi", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);


        }

        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYoutube frm = new Formlar.FrmYoutube();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}

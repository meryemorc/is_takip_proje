using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;


namespace is_takip_proje.Formlar
{
    public partial class FrmCagriAtama : Form
    {
        public FrmCagriAtama()
        {
            InitializeComponent();
        }
        public int id;
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmCagriAtama_Load(object sender, EventArgs e)
        {
            //Lookupedit için verilerin listelenmesi
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad
                            }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;



            txtCagriId.Text= id.ToString();
            var gelenveri = db.TblCagrilar.Find(id);
            txtAciklama.Text = gelenveri.Aciklama;
            txtTarih.Text = gelenveri.Tarih.ToString();
            txtKonu.Text = gelenveri.Konu;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TblCagrilar.Find(id);
            gelenveri.Konu =txtKonu.Text;
            gelenveri.Tarih = DateTime.Parse(txtTarih.Text);
            gelenveri.Aciklama = txtAciklama.Text;
            gelenveri.CagriPersonel = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
        }
    }
}

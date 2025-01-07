﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorevFormlar
{
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }

        

        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            PersonelGorevFormlar.FrmAktifGörevler frm = new PersonelGorevFormlar.FrmAktifGörevler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlar.FrmPasifGorevler frm = new PersonelGorevFormlar.FrmPasifGorevler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlar.FrmCagriListesi frm = new PersonelGorevFormlar.FrmCagriListesi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

﻿using System;
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
    public partial class FrmPasifCagrilar : Form
    {
        public FrmPasifCagrilar()
        {
            InitializeComponent();
        }

        private void FrmPasifCagrilar_Load(object sender, EventArgs e)
        {
            DbisTakipEntities db = new DbisTakipEntities();

            var degerler = (from x in db.TblCagrilar
                            select new
                            {
                                x.ID,
                                x.TblFirmalar.Ad,
                                x.TblFirmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                Personel = x.TblPersonel.Ad,
                                x.Durum
                            }
                            ).Where(y => y.Durum == false).ToList();
            gridControl1.DataSource = degerler;
        }
    }
}

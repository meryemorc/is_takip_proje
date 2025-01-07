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

namespace is_takip_proje.PersonelGorevFormlar
{
    public partial class FrmCagriListesi : Form
    {
        public FrmCagriListesi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
       
        private void FrmCagriListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.ID,
                                           x.TblFirmalar.Ad,
                                           x.TblFirmalar.Telefon,
                                           x.TblFirmalar.Mail,
                                           x.Aciklama,
                                           x.Durum

                                       }).Where(y => y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriDetayGirisi fr = new FrmCagriDetayGirisi();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}

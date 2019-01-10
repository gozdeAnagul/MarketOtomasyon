using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class MalKabul : Form
    {
        public MalKabul()
        {
            InitializeComponent();
        }

        private void MalKabul_Load(object sender, EventArgs e)
        {
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();
        }
       


        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliKategori = cmbKategoriler.SelectedItem as Kategori;

            if (seciliKategori == null) return;

            lstUrunler.DataSource = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);

        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun seciliUrun = lstUrunler.SelectedItem as Urun;

            if (seciliUrun == null) return;

            txtBarkod.Text = seciliUrun.KoliBarkod;
        }
    }
}

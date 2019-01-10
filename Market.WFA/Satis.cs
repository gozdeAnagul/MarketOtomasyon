using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
            Models = new UrunKontrolViewModels();
        }
        public UrunKontrolViewModels Models;
        
        private void Satis_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            cmbKategoriler.DataSource = new KategoriRepo().GetAll().OrderBy(x => x.KategoriAdi).ToList();
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void UrunleriGetir()
        {
            var seciliKategori = cmbKategoriler.SelectedItem as Kategori;
            if (seciliKategori == null) return;

            cmbUrunler.DataSource = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);
        }

        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            BarkoduGetir();
        }

        private void BarkoduGetir()
        {
            var seciliUrun = cmbUrunler.SelectedItem as Urun;
            if (seciliUrun == null) return;

            txtBarkod.Text = seciliUrun.UrunBarkod;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FiseUrunEkle();
        }

        private void FiseUrunEkle()
        {
            var seciliBarkod = txtBarkod.Text;
            if (seciliBarkod == null) return;
            


            
        }
    }
}

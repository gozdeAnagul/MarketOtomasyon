using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }
        public Urun seciliUrun;
        public Fis Fis;
        public SatisViewModel seciliSatis;
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
            seciliUrun = cmbUrunler.SelectedItem as Urun;
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

            var urun = new UrunRepo().GetAll().FirstOrDefault(x => x.UrunBarkod == seciliBarkod);
            var adet = (int)nuUrunAdet.Value;
            if (urun.Stok-adet>=0 && adet!=0)
            {
                bool VarMi = false;
                foreach (SatisViewModel satis in lstSepet.Items)
                {
                    VarMi = (satis.UrunBarkod == urun.UrunBarkod);
                    
                    if (VarMi)
                    {
                        seciliSatis = satis;
                        break;
                    }
                }

                if (VarMi)
                {
                    seciliSatis.Adet = seciliSatis.Adet + 1;
                    seciliSatis.Fiyat = urun.SatisFiyat*seciliSatis.Adet;
                    lstSepet.Items.Remove(seciliSatis);
                    lstSepet.Items.Add(seciliSatis);
                    UrunleriGetir();
                }
                else
                {
                    var yeniSatisViewModel = new SatisViewModel
                    {
                        UrunId = urun.Id,
                        UrunBarkod = seciliBarkod,
                        UrunAdi = urun.UrunAdi,
                        Adet = adet,
                        Fiyat = adet * urun.SatisFiyat,
                        Stok = urun.Stok
                    };
                    lstSepet.Items.Add(yeniSatisViewModel);
                    UrunleriGetir();
                }
            }
            else
            {
                if (adet==0)
                {
                    MessageBox.Show("Sepete en az 1 ürün eklemelisiniz.");
                }
                else
                {
                    MessageBox.Show($"Stokta yeterli sayıda {urun.UrunAdi} yok.");
                }
            }
        }

        
    }
}

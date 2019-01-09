using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }
        Kategori seciliKategori;
        Urun seciliUrun;
        private void CRUD_Load(object sender, EventArgs e)
        {
            VerileriDoldur();
        }

        private void VerileriDoldur()
        {
            lstKategori.DataSource = new KategoriRepo().GetAll();
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();
            cmbUrunKategoriler.DataSource = new UrunRepo().GetAll();
        }

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var kategori = new Kategori
                {
                    KategoriAdi = txtKategori.Text,
                    Aciklama = txtKategoriAciklama.Text
                };

                if (new KategoriRepo().Insert(kategori) > 0)
                {
                    MessageBox.Show("Kategori eklendi.");
                }
                else
                {
                    MessageBox.Show("Kategori Ekleme hatasi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriDoldur();
        }
        
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem == null) return;

            seciliKategori = cmbKategoriler.SelectedItem as Kategori;

            var urunler = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);
            lstUrunler.DataSource = urunler;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliKategori == null) return;
                Random rnd = new Random();
                var urun = new Urun
                {
                    UrunAdi = txtUrunAdi.Text,
                    KategoriId = seciliKategori.Id,
                    Barkod = Convert.ToString(rnd.Next(1000000, 99999999))
                };

                if (new UrunRepo().Insert(urun) > 0)
                {
                    MessageBox.Show($@"{urun.Kategori} kategorisine {urun.UrunAdi} eklendi.");
                }
                else
                {
                    MessageBox.Show("Urun Ekleme hatasi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            VerileriDoldur();
        }
        private void btnUrunDetayEkle_Click(object sender, EventArgs e)
        {
            try
            {
                seciliUrun = cmbUrunKategoriler.SelectedItem as Urun;
                if (seciliUrun == null) return;
                Random rnd = new Random();
                var urunDetay = new UrunDetay
                {
                    UrunId = seciliUrun.Id,
                    Aciklama = txtUrunDetayAciklama.Text,
                    KoliAdet = Convert.ToInt32(nuKoliAdet.Value),
                    AlisFiyat = Convert.ToDecimal(txtAlisFiyati.Text),
                    SatisFiyat = Convert.ToDecimal(txtSatisFiyati.Text),
                    Kdv = Convert.ToDouble(txtKdv.Text),
                    KoliIciAdet = Convert.ToInt32(txtKoliIciAdet.Text),
                    UrunAdet = Convert.ToInt32(txtUrunAdet.Text),
                    Barkod = Convert.ToString(rnd.Next(1000000, 99999999))
                };
                   
                if (new UrunDetayRepo().Insert(urunDetay) > 0)
                {
                    MessageBox.Show($@"{urunDetay.Aciklama} ürünü eklendi.");
                }
                else
                {
                    MessageBox.Show("Urun Ekleme hatasi.");
                }
                VerileriDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

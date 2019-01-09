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
        Kategori seciliKategori = new Kategori();
        Urun seciliUrun = new Urun();
        List<Kategori> kategoriler = new KategoriRepo().GetAll();
        List<Urun> urunler = new UrunRepo().GetAll();
        private void CRUD_Load(object sender, EventArgs e)
        {
            VerileriDoldur();
        }

        private void VerileriDoldur()
        {
            lstKategori.DataSource = kategoriler;
            cmbKategoriler.DataSource = kategoriler;
            cmbUrunKategoriler.DataSource = urunler;
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

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliKategori == null) return;
                
                var urun = new Urun
                {
                    UrunAdi = txtUrunAdi.Text,
                    KategoriId = seciliKategori.Id
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

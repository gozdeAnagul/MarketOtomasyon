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
        private void CRUD_Load(object sender, EventArgs e)
        {
            VerileriDoldur();
        }

        private void VerileriDoldur()
        {
            lstKategori.DataSource = new KategoriRepo().GetAll();
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();
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

        private void cmbKategoriler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (seciliKategori == null) return;
            seciliKategori = cmbKategoriler.SelectedItem as Kategori;

            var urunler = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);
            lstUrunler.DataSource = urunler.ToList();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem == null) return;
            try
            {            
                Random rnd = new Random();
                var urunDetay = new Urun
                {
                    UrunAdi = txtUrunAdi.Text,
                    Aciklama = txtUrunDetayAciklama.Text,
                    KoliAdet = Convert.ToInt32(nuKoliAdet.Value),
                    AlisFiyat = Convert.ToDecimal(txtAlisFiyati.Text),
                    SatisFiyat = Convert.ToDecimal(txtSatisFiyati.Text),
                    Kdv = Convert.ToDouble(txtKdv.Text),
                    KoliIciAdet = Convert.ToInt32(txtKoliIciAdet.Text),
                    UrunAdet = Convert.ToInt32(txtUrunAdet.Text),
                    KoliBarkod = Convert.ToString(rnd.Next(1000000, 99999999)),
                    UrunBarkod = Convert.ToString(rnd.Next(1000000, 99999999))
                };

                if (new UrunRepo().Insert(urunDetay) > 0)
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

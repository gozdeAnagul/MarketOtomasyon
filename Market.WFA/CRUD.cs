using Market.BLL.Repository;
using Market.Models.Entities;
using System;
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
            lstUrunler.DataSource = null;
            lstKategori.DataSource = new KategoriRepo().GetAll();
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();
            lstUrunler.DataSource = new UrunRepo().GetAll();
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
            seciliKategori = cmbKategoriler.SelectedItem as Kategori;

            if (seciliKategori == null) return;

            var urunler = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);
            lstUrunler.DataSource = urunler.ToList();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (seciliKategori == null) return;

            try
            {            
                Random rnd = new Random();

                var urun = new Urun
                {
                    KategoriId = seciliKategori.Id,
                    UrunAdi = txtUrunAdi.Text,
                    Aciklama = txtUrunAciklama.Text,
                    KoliAdet = Convert.ToInt32(nuKoliAdet.Value),
                    KoliIciAdet = Convert.ToInt32(txtKoliIciAdet.Text),
                    Kdv = Convert.ToDecimal(txtKdv.Text),
                    KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                    UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                    AlisFiyat = Convert.ToDecimal(txtAlisFiyati.Text),
                };

                if (new UrunRepo().Insert(urun) > 0)
                {
                    MessageBox.Show($@"{urun.Aciklama} ürünü eklendi.");
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

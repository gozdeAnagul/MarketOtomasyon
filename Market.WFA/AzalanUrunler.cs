using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class AzalanUrunler : Form
    {
        public AzalanUrunler()
        {
            InitializeComponent();
        }


        private void AzalanUrunler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            lstAzalanUrunler.DataSource = new UrunRepo().GetAll(x => x.Stok <= 20);
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();
        }

        private void lstAzalanUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SeciliUrun = lstAzalanUrunler.SelectedItem as Urun;

            lblAdetIc.Text = SeciliUrun.KoliIciAdet.ToString();
        }

        private void btnStogaEkle_Click(object sender, EventArgs e)
        {
            var seciliUrun = lstAzalanUrunler.SelectedItem as Urun;

            try
            {
                var adet = (int)nuKutu.Value;
                seciliUrun.KoliAdet += adet;
                seciliUrun.Stok += (seciliUrun.KoliIciAdet * adet);
                new UrunRepo().Update();
                MessageBox.Show($"{seciliUrun.UrunAdi} ürününe {(int)nuKutu.Value} koli eklendi. Stok {seciliUrun.Stok} olarak güncellendi.");
                ListeyiYenile();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ListeyiYenile()
        {
            lstAzalanUrunler.DataSource = new UrunRepo().GetAll(x => x.Stok <= 20);

        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliKategori = cmbKategoriler.SelectedItem as Kategori;

            Urun urun = new Urun();

            lstKategoriUrunleri.DataSource = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);


            var KategoriFarkliUrun = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id).Count.ToString();
            lblKatUrunAdeti.Text = $"{seciliKategori.ToString()} içerisinde toplam {KategoriFarkliUrun} adet farklı ürün vardır";

            var ToplamStok = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id).Sum(x => x.Stok);
            lblKatToplamUrun.Text = $"{seciliKategori.ToString()} içerisinde toplam {ToplamStok} adet ürün vardır.";

            var SeciliUrun = lstAzalanUrunler.SelectedItem as Urun;
            // lblAdetIc.Text = SeciliUrun.KoliIciAdet.ToString();


        }
    }
}

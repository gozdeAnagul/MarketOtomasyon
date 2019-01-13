using Market.BLL.Repository;
using Market.DAL;
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
    public partial class AzalanUrunler : Form
    {
        public AzalanUrunler()
        {
            InitializeComponent();
        }
        

        private void AzalanUrunler_Load(object sender, EventArgs e)
        {
            lstAzalanUrunler.DataSource = new UrunRepo().GetAll(x=>x.Stok <= 20);
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();

        }

        private void lstAzalanUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var  SeciliUrun = lstAzalanUrunler.SelectedItem as Urun;

            lblAdetIc.Text = SeciliUrun.KoliIciAdet.ToString();
           

        }

        private void btnStogaEkle_Click(object sender, EventArgs e)
        {
            // if (seciliBarkod == null) return;

            var seciliUrun = lstAzalanUrunler.SelectedItem as Urun;

            try
            {
                seciliUrun.KoliAdet += (int)nuKutu.Value;
                new UrunRepo().Update();
                MessageBox.Show($"{seciliUrun.UrunAdi} ürününe {(int)nuKutu.Value} koli eklendi. Stok {seciliUrun.Stok} olarak güncellendi.");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void ListeyiYenile()
        {
          //  lstAzalanUrunler.DataSource = null;
            lstAzalanUrunler.DataSource = new UrunRepo().GetAll(x => x.Stok<=20);
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

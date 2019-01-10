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
            var SeciliUrun = lstAzalanUrunler.SelectedItem as Urun;


        }

        private void btnStogaEkle_Click(object sender, EventArgs e)
        {
            // if (seciliBarkod == null) return;

            var seciliUrun = lstAzalanUrunler.SelectedItem as Urun;

            try
            {
                seciliUrun.KoliAdet += (int)nuKutu.Value;
                new UrunRepo().Update();
                MessageBox.Show($"{seciliUrun.UrunAdi} ürününün stoğu {seciliUrun.Stok} oldu.");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ListeyiYenile()
        {
            lstAzalanUrunler.DataSource = null;
            lstAzalanUrunler.DataSource = new UrunRepo().GetAll(x => x.Stok<=20);
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            var seciliKategori = cmbKategoriler.SelectedItem as Kategori;
            Urun urun = new Urun();
            lstKategoriUrunleri.DataSource = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);
           // lblKatUrunAdeti.Text = new UrunRepo().GetAll(x=>x.KategoriId==seciliKategori.Id).Count.ToString();
            lblKatUrunAdeti.Text = $"{seciliKategori.ToString()} içerisinde toplam {new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id).Count.ToString()} adet ürün vardır";
         //RaporViewModel
        }
    }
}

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
    }
}

using Market.BLL.Repository;
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
    public partial class SatisDialog : Form
    {
        public SatisDialog()
        {
            InitializeComponent();
            VerileriDoldur();
        }
        Kategori seciliKategori;
        private void VerileriDoldur()
        {
            lstUrunler.DataSource = null;
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();
            lstUrunler.DataSource = new UrunRepo().GetAll();

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            seciliKategori = cmbKategoriler.SelectedItem as Kategori;
            if (seciliKategori == null) return;
            if (txtYeniBarkod.Text == null) return;
            try
            {
                Random rnd = new Random();

                var urun = new Urun
                {
                    KategoriId = seciliKategori.Id,
                    UrunAdi = txtUrunAdi.Text,
                    Aciklama = txtUrunAciklama.Text,
                    KoliIciAdet = Convert.ToInt32(txtKoliIciAdet.Text),
                    Kdv = Convert.ToDecimal(txtKdv.Text),
                    KoliBarkod = txtYeniBarkod.Text,
                    UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                    AlisFiyat = Convert.ToDecimal(txtAlisFiyati.Text),
                };

                if (new UrunRepo().Insert(urun) > 0)
                {
                    MessageBox.Show($@"{urun.UrunAdi} ürünü eklendi.");
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

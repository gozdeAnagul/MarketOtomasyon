using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class MalKabul : Form
    {
        public MalKabul()
        {
            InitializeComponent();           
        }
        private string seciliBarkod;
        private Urun seciliUrun;
        private Kategori seciliKategori;
        private SatisDialog satisDialogForm;
        private void MalKabul_Load(object sender, EventArgs e)
        {
            cmbKategoriler.DataSource = new KategoriRepo().GetAll();
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliKategori = cmbKategoriler.SelectedItem as Kategori;

            if (seciliKategori == null) return;

            lstUrunler.DataSource = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);

        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliUrun = lstUrunler.SelectedItem as Urun;

            if (seciliUrun == null) return;

            seciliBarkod = seciliUrun.KoliBarkod;
            txtBarkod.Text = seciliBarkod;
            lbIicAdetKoli.Text = seciliUrun.KoliIciAdet.ToString();

        }

        private void btnStogaEkle_Click(object sender, EventArgs e)
        {
            if (seciliBarkod == null) return;

            try
            {
                var koli = (int)nuKoli.Value;
                seciliUrun.KoliAdet += koli;
                new UrunRepo().Update();
                MessageBox.Show($"{seciliUrun.UrunAdi} ürününe {koli} koli eklendi. Stok {seciliUrun.Stok} olarak güncellendi.");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListeyiYenile()
        {

            lstUrunler.DataSource = null;
            lstUrunler.DataSource = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);
        }
        private void btnBarkodGetir_Click(object sender, EventArgs e)
        {

            if (new UrunRepo().GetAll(x => x.KoliBarkod == txtBarkod.Text) == null)
            {
            }

            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pbBarkod.Image = barcode.Draw(seciliBarkod, 100, 2);

            YeniBarkodMu();
        }
        
        
        private void YeniBarkodMu()
        {          
            if (txtBarkod == null) return;

            var urun = new UrunRepo().GetAll(x => x.KoliBarkod == txtBarkod.Text);
            if(urun.Count<1)
            {
                if (satisDialogForm == null || satisDialogForm.IsDisposed)
                {
                    satisDialogForm = new SatisDialog();
                }
                satisDialogForm.Show();
                
            }
        }
    }
}

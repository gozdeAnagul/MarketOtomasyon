using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
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
        public SatisDialog satisDialogForm;
        public List<Urun> urunlist;
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
                seciliUrun.Stok += (seciliUrun.KoliAdet * seciliUrun.KoliIciAdet);
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
            if (cmbKategoriler.Items.Count < 1)
            {
                MessageBox.Show("Önce Kategori Ekleyiniz!!", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtBarkod.Text == null) return;
            
            if (seciliBarkod == null) return;
            
            YeniBarkodMu();
        }
           
        private void YeniBarkodMu()
        {
            if (txtBarkod != null)
            {
                var urun = new UrunRepo().GetAll(x => x.KoliBarkod == txtBarkod.Text);
                if (urun.Count < 1)
                {
                    DialogResult dialogResult = MessageBox.Show($"{txtBarkod.Text} barkodlu ürün kayıtlı değil. Eklemek ister misiniz ?",
                        "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (satisDialogForm == null || satisDialogForm.IsDisposed)
                        {
                            satisDialogForm = new SatisDialog
                            {
                                malkabulForm = this
                            };
                        }
                        satisDialogForm.Show();
                    }
                }
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pbBarkod.Image = barcode.Draw(seciliBarkod, 100, 2);
            }
            
        }

        private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            urunlist = new UrunRepo().GetAll();
            if (urunlist == null) return;

            foreach (var urun in urunlist)
            {
                if (txtBarkod.Text == urun.KoliBarkod)
                {
                    btnBarkodGetir.PerformClick();
                    btnStogaEkle.PerformClick();
                }
            }
        }
    }
}

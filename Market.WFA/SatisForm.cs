using iTextSharp.text;
using iTextSharp.text.pdf;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.Enums;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }
        public Urun seciliUrun;
        public SatisViewModel seciliSatis;
        public decimal genelTutar = 0;
        public List<Urun> urunlist;
        private void Satis_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            VerileriGetir();
            btnOdemeYap.Enabled = false;
        }

        private void VerileriGetir()
        {
            cmbKategoriler.DataSource = new KategoriRepo().GetAll().OrderBy(x => x.KategoriAdi).ToList();
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void UrunleriGetir()
        {
            var seciliKategori = cmbKategoriler.SelectedItem as Kategori;
            if (seciliKategori == null) return;

            cmbUrunler.DataSource = new UrunRepo().GetAll(x => x.KategoriId == seciliKategori.Id);
        }

        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            BarkoduGetir();
        }

        private void BarkoduGetir()
        {
            seciliUrun = cmbUrunler.SelectedItem as Urun;
            if (seciliUrun == null) return;

            txtBarkod.Text = seciliUrun.UrunBarkod;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FiseUrunEkle();
        }

        private void FiseUrunEkle()
        {
            var seciliBarkod = txtBarkod.Text;
            if (seciliBarkod == null) return;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pbBarkod.Image = barcode.Draw(seciliBarkod, 100, 2);

            var urun = new UrunRepo().GetAll().FirstOrDefault(x => x.UrunBarkod == seciliBarkod);
            var adet = (int)nuUrunAdet.Value;
            if (urun.Stok - adet >= 0 && adet != 0)
            {
                bool VarMi = false;
                foreach (SatisViewModel satis in lstSepet.Items)
                {
                    VarMi = (satis.UrunBarkod == urun.UrunBarkod);

                    if (VarMi)
                    {
                        seciliSatis = satis;
                        break;
                    }
                }

                if (VarMi)
                {

                    if (seciliSatis.Adet + adet > urun.Stok)
                    {
                        MessageBox.Show($"Stokta yeterli sayıda {urun.UrunAdi} yok.");
                    }
                    else
                    {
                        seciliSatis.Adet = seciliSatis.Adet + adet;
                        seciliSatis.Fiyat = urun.SatisFiyat * seciliSatis.Adet;
                        lstSepet.Items.Remove(seciliSatis);
                        lstSepet.Items.Add(seciliSatis);
                    }
                }
                else
                {
                    var yeniSatisViewModel = new SatisViewModel
                    {
                        UrunId = urun.Id,
                        UrunBarkod = seciliBarkod,
                        UrunAdi = urun.UrunAdi,
                        Adet = adet,
                        Fiyat = adet * urun.SatisFiyat,
                        Stok = urun.Stok
                    };
                    lstSepet.Items.Add(yeniSatisViewModel);
                }

                TutarHesapla();
            }
            else
            {
                if (adet == 0)
                {
                    MessageBox.Show("Sepete en az 1 ürün eklemelisiniz.");
                }
                else
                {
                    MessageBox.Show($"Stokta yeterli sayıda {urun.UrunAdi} yok.");
                }
            }
        }

        private void TutarHesapla()
        {
            foreach (SatisViewModel item in lstSepet.Items)
            {
                genelTutar += item.Fiyat;
            }
            lblTutar.Text = genelTutar.ToString();
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked == true)
            {
                panel1.Visible = true;

                txtTutar.Text = genelTutar.ToString();
            }
            else if (rbNakit.Checked == false)
            {
                panel1.Visible = false;
            }
        }

        private void txtNakit_TextChanged(object sender, EventArgs e)
        {
            if (txtAlinan.Text == string.Empty) return;

            var alinanPara = decimal.Parse(txtAlinan.Text);
            var tutar = decimal.Parse(txtTutar.Text);

            if (alinanPara - tutar > 0)
            {
                txtParaUstu.Text = (alinanPara - tutar).ToString();
                btnOdemeYap.Enabled = true;
            }
            else if (alinanPara == tutar)
            {
                txtParaUstu.Text = "Para tam.";
                btnOdemeYap.Enabled = true;
            }
            else
            {
                txtParaUstu.Text = "Para yetmiyor.";
                btnOdemeYap.Enabled = false;
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            var odemeYontemi = (rbNakit.Checked) ? OdemeYontemi.Peşin : OdemeYontemi.KrediKartı;

            Fis fis = new Fis();
            List<SatisViewModel> satisViewModels = new List<SatisViewModel>();
            List<Satis> satislar = new List<Satis>();

            foreach (SatisViewModel item in lstSepet.Items)
            {
                satislar.Add(new Satis
                {
                    UrunId = item.UrunId,
                    AltToplam = item.Fiyat,
                    SatisAdeti = item.Adet,
                    FisId = fis.Id
                });
                satisViewModels.Add(item);
            }

            fis.Satislar = satislar;
            fis.OdemeYontemi = odemeYontemi;
            fis.GenelToplam = genelTutar;

            if (new FisRepo().Insert(fis) > 0)
            {
                MessageBox.Show("Odeme Alindi.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Satis item in satislar)
                {
                    var urun = new UrunRepo().GetById(item.UrunId);
                    // urun.Stok = urun.Stok - item.SatisAdeti;
                    new UrunRepo().Update();
                }

                FisViewModel fisViewModel = new FisViewModel()
                {
                    FisId = fis.Id,
                    SatisListesi = satisViewModels,
                    GenelTutar = fis.GenelToplam
                };

                string fisS = "";

                fisS += "Fiş No: "+ fisViewModel.FisId + "\n--------------------------------\n";
                foreach (var item in fisViewModel.SatisListesi)
                {
                    fisS += item.UrunAdi + "X" + item.Adet +"=" + item.Fiyat + "\n";
                }

                fisS += "--------------------------------\nGenel Tutar: "+ fisViewModel.GenelTutar.ToString();

                MessageBox.Show($"{fisS}");

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document(PageSize.A5.Rotate());
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();
                            var urunsatis = satisViewModels;


                            doc.Add(new Paragraph("Wissen Market A.S \nBesiktas/ISTANBUL \nKuloglu Mh., Barbaros Blv. Yildiz IS Hani No:9"));
                            doc.Add(new Paragraph($"\nFis No:{fis.Id}\nTarih:{fis.FisTarihi}\n"));
                            doc.Add(new Paragraph("\nÜrün Listesi\n------------------------------------------------------\n"));
                            foreach (var item in urunsatis)
                            {
                                doc.Add(new Paragraph(item.ToString()));
                            }
                            if (rbNakit.Checked == true)
                            {

                                doc.Add(new Paragraph($"------------------------------------------------------\nAlınan Para: {txtAlinan.Text}\nPara Üstü:{txtParaUstu.Text:c2}"));
                            }
                            doc.Add(new Paragraph($"\nTutar : {fis.GenelToplam:c2}"));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        finally
                        {
                            doc.Close();
                        }
                    }
                        SepetiTemizle();
            }
            else
            {
                MessageBox.Show("Odeme Basarisiz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SepetiTemizle()
        {
            lstSepet.Items.Clear();
            rbKrediKarti.Checked = false;
            rbNakit.Checked = false;
            lblTutar.Text = string.Empty;
            genelTutar = 0;
            nuUrunAdet.Value = 0;
            btnOdemeYap.Enabled = false;
        }

        private void rbKrediKarti_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKrediKarti.Checked == true)
            {
                btnOdemeYap.Enabled = true;
                txtAlinan.Text = string.Empty;
                txtParaUstu.Text = string.Empty;
            }
            else
            {
                btnOdemeYap.Enabled = false;
            }
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            var seciliUrun = lstSepet.SelectedItem as SatisViewModel;
            if (seciliUrun == null) return;

            try
            {
                lstSepet.Items.Remove(seciliUrun);
                genelTutar -= (seciliUrun.Adet * seciliUrun.Fiyat);

                TutarHesapla();
                
                lstSepet.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            urunlist = new UrunRepo().GetAll();
            if (urunlist == null) return;

            foreach (var urun in urunlist)
            {
                if (txtBarkod.Text == urun.UrunBarkod)
                {
                    BarkoduGetir();
                    btnUrunEkle.PerformClick();
                }
            }
        }

        private void nuPosetSayisi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

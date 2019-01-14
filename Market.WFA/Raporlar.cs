using Market.BLL.Repository;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, System.EventArgs e)
        {
            lblToplamCiroAy.Visible = false;
            lblOdemeKartAy.Visible = false;
            lblOdemeNakitAy.Visible = false;
            lblNakitGun.Visible = false;
            lblKartGun.Visible = false;
            lblToplamCiroGun.Visible = false;
        }

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarih.Value;
            GunlukSatisGetir(tarih);
        }


        public void KategorilereGoreUrunStoklariGetir()
        {
            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();

            var KategorilereGoreUrunler = from u in urunler
                                          join k in kategoriler on u.KategoriId equals k.Id
                                          orderby k.KategoriAdi
                                          select new
                                          {
                                              k.KategoriAdi,
                                              u.UrunBarkod,
                                              u.UrunAdi,
                                              u.AlisFiyat,
                                              u.SatisFiyat,
                                              u.Stok

                                          };

            dgvmRapor.DataSource = KategorilereGoreUrunler.ToList();






        }

        public void AylikSatisGetir(DateTime GirilenTarih)
        {
           
            DateTime BirAyOncesi = dtpTarih.Value.AddMonths(-1);

            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var fisler = new FisRepo().GetAll();

            var RaporAylik =  from u in urunler
                              join k in kategoriler on u.KategoriId equals k.Id
                              join s in satislar on u.Id equals s.UrunId
                              join f in fisler on s.FisId equals f.Id
                              where (f.FisTarihi >= BirAyOncesi && f.FisTarihi <= GirilenTarih ) 
                             group new
                             {
                                 u,
                                 k,
                                 s,
                                 f
                             } by new
                             {
                                 f.Id,
                                 u.UrunBarkod,
                                 k.KategoriAdi,
                                 u.UrunAdi,
                                 f.FisTarihi,
                                 f.GenelToplam,
                                 f.OdemeYontemi,
                                 u.Stok,
                                 s.SatisAdeti,
                                 u.SatisFiyat
                             }
                                 into gp
                              orderby gp.Key.Id
                              select new
                              {
                                  FisId = gp.Key.Id,
                                  gp.Key.FisTarihi,
                                  gp.Key.UrunBarkod,
                                  gp.Key.KategoriAdi,
                                  gp.Key.UrunAdi,
                                  gp.Key.OdemeYontemi,
                                  BirimFiyat = gp.Key.SatisFiyat,
                                  SatılanUrunAdeti = gp.Sum(x => x.s.SatisAdeti),
                                  gp.Key.GenelToplam

                              };

            var KrediKartıAdeti = new FisRepo().GetAll(x => x.OdemeYontemi == Models.Enums.OdemeYontemi.KrediKartı && x.FisTarihi.Day <= GirilenTarih.Day && x.FisTarihi>=GirilenTarih.AddMonths(-1) && x.FisTarihi.Year==GirilenTarih.Year).Count.ToString();

            var NakitAdeti = new FisRepo().GetAll(x => x.OdemeYontemi == Models.Enums.OdemeYontemi.Nakit && x.FisTarihi.Day <= GirilenTarih.Day && x.FisTarihi >= GirilenTarih.AddMonths(-1) && x.FisTarihi.Year == GirilenTarih.Year).Count.ToString();

            var ToplamCiro = new FisRepo().GetAll(x => x.FisTarihi.Day <= GirilenTarih.Day && x.FisTarihi >= GirilenTarih.AddMonths(-1) && x.FisTarihi.Year == GirilenTarih.Year).Sum(x => x.GenelToplam);

            lblNakitGun.Visible = false;
            lblKartGun.Visible = false;
            lblToplamCiroGun.Visible = false;

            lblOdemeKartAy.Visible = true;
            lblOdemeNakitAy.Visible = true;
            lblToplamCiroAy.Visible = true;
          
            lblOdemeKartAy.Text  = $"Ay Boyunca {KrediKartıAdeti} adet Kredi Kartı ile ödeme işlemi gerçekleşmiştir";
            lblOdemeNakitAy.Text = $"Ay Boyunca {NakitAdeti} adet Nakit ile ödeme işlemi gerçekleşmiştir";
            lblToplamCiroAy.Text = $"Ay Boyunca Toplam Ciro tutarı {ToplamCiro} TL'idir";

            dgvmRapor.DataSource = RaporAylik.ToList();

        }
        public void GunlukSatisGetir(DateTime GirilenTarih)
        {
            DateTime tarih = dtpTarih.Value;

            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var fisler = new FisRepo().GetAll();


            var RaporGunluk = from u in urunler
                              join k in kategoriler on u.KategoriId equals k.Id
                              join s in satislar on u.Id equals s.UrunId
                              join f in fisler on s.FisId equals f.Id
                              where f.FisTarihi.ToShortDateString() == GirilenTarih.ToShortDateString()
                              group new
                              {
                                  u,
                                  k,
                                  s,
                                  f
                              } by new
                              {
                                  f.Id,
                                  u.UrunBarkod,
                                  k.KategoriAdi,
                                  u.UrunAdi,
                                  f.FisTarihi,
                                  f.GenelToplam,
                                  f.OdemeYontemi,
                                  u.Stok,
                                  s.SatisAdeti,
                                  u.SatisFiyat
                              }
                                 into gp
                              orderby gp.Key.Id
                              select new
                              {
                                  FisId = gp.Key.Id,
                                  gp.Key.FisTarihi,
                                  gp.Key.UrunBarkod,
                                  gp.Key.KategoriAdi,
                                  gp.Key.UrunAdi,
                                  gp.Key.OdemeYontemi,
                                  BirimFiyat = gp.Key.SatisFiyat,
                                  SatılanUrunAdeti = gp.Sum(x => x.s.SatisAdeti),
                                  gp.Key.GenelToplam
                              };

            dgvmRapor.DataSource = RaporGunluk.ToList();

     var KrediKartıAdeti = new FisRepo().GetAll(x => x.OdemeYontemi == Models.Enums.OdemeYontemi.KrediKartı && x.FisTarihi.Day==GirilenTarih.Day && x.FisTarihi.Year == GirilenTarih.Year && x.FisTarihi.Month == GirilenTarih.Month).Count.ToString();

     var NakitAdeti = new FisRepo().GetAll(x => x.OdemeYontemi == Models.Enums.OdemeYontemi.Nakit && x.FisTarihi.Day == GirilenTarih.Day          && x.FisTarihi.Year == GirilenTarih.Year && x.FisTarihi.Month == GirilenTarih.Month).Count.ToString();

     var ToplamCiro = new FisRepo().GetAll(x => x.FisTarihi.Day == GirilenTarih.Day && x.FisTarihi.Year == GirilenTarih.Year && x.FisTarihi.Month == GirilenTarih.Month).Sum(x => x.GenelToplam);

            lblOdemeKartAy.Visible = false; ;
            lblOdemeNakitAy.Visible = false;
            lblToplamCiroAy.Visible = false;

            lblToplamCiroGun.Visible = true;
            lblNakitGun.Visible = true;
            lblKartGun.Visible = true;


            lblKartGun.Text = $"Gün Boyunca {KrediKartıAdeti} adet Kredi Kartı ile ödeme işlemi gerçekleşmiştir";
            lblNakitGun.Text = $"Gün Boyunca {NakitAdeti} adet Nakit ile ödeme işlemi gerçekleşmiştir";
            lblToplamCiroGun.Text = $"Gün Boyunca Toplam Ciro tutarı {ToplamCiro} TL'idir";


        }

        private void btnAylıkRapor_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarih.Value;
            AylikSatisGetir(tarih);
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            KategorilereGoreUrunStoklariGetir();

        }
    }
}
/* select UrunAdi, KategoriAdi, SatisAdeti, GenelToplam

           from Kategoriler K join Urunler U ON K.Id = U.KategoriId
           join Satislar S ON S.UrunId = U.Id
           join Fisler F ON F.Id = S.FisId */

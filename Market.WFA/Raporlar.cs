using Market.BLL.Repository;
using System;
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
            lblOdeme.Visible = false;
           // var suan = DateTime.Now;
           // //new KategoriRepo().GetAll(x=>x.);
           // //new UrunRepo().GetAll(x => x.);
           // //new SatisRepo().GetAll(x => x.);
           //label1.Text = new FisRepo().GetAll(x => x.EklenmeZamani>suan.AddMonths(-1)).ToString();
        }

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarih.Value;
            GunlukSatisGetir(tarih);
            
        }
        
        public void AylikSatisGetir(DateTime GirilenTarih)
        {
           // DateTime tarih = dtpTarih.Value;
            DateTime BirAyOncesi = dtpTarih.Value.AddMonths(-1);

            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var fisler = new FisRepo().GetAll();

            var RaporAylik =  from u in urunler
                              join k in kategoriler on u.KategoriId equals k.Id
                              join s in satislar on u.Id equals s.UrunId
                              join f in fisler on s.FisId equals f.Id
                              where f.FisTarihi <= GirilenTarih && f.FisTarihi >= BirAyOncesi

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
                              orderby gp.Key.KategoriAdi
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
            lblOdeme.Visible = true;

            lblOdeme.Text = $"Ay Boyunca {KrediKartıAdeti} adet Kredi Kartı ile ödeme işlemi gerçekleşmiştir";

            dgvmRapor.DataSource = RaporAylik.ToList();

        }
        public void GunlukSatisGetir(DateTime GirilenTarih)
        {
            DateTime tarih = dtpTarih.Value;
            
            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var fisler = new FisRepo().GetAll();

           /* select UrunAdi, KategoriAdi, SatisAdeti, GenelToplam
           
            from Kategoriler K join Urunler U ON K.Id = U.KategoriId
            join Satislar S ON S.UrunId = U.Id
            join Fisler F ON F.Id = S.FisId */



                var RaporGunluk  =  from u in urunler
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
                                        f.Id ,
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
                                        FisId= gp.Key.Id,
                                        gp.Key.FisTarihi,
                                        gp.Key.UrunBarkod,
                                        gp.Key.KategoriAdi,
                                        gp.Key.UrunAdi,
                                        gp.Key.OdemeYontemi,
                                        BirimFiyat = gp.Key.SatisFiyat,
                                        SatılanUrunAdeti = gp.Sum(x=>x.s.SatisAdeti),
                                        gp.Key.GenelToplam
                                      };

            dgvmRapor.DataSource = RaporGunluk.ToList();
       var KrediKartıAdeti = new FisRepo().GetAll(x => x.OdemeYontemi == Models.Enums.OdemeYontemi.KrediKartı && x.FisTarihi.Day ==GirilenTarih.Day && x.FisTarihi.Year == GirilenTarih.Year && x.FisTarihi.Month == GirilenTarih.Month).Count.ToString();
            lblOdeme.Visible = true;
            lblOdeme.Text = $"Gün Boyunca {KrediKartıAdeti} adet Kredi Kartı ile ödeme işlemi gerçekleşmiştir";



        }

        private void btnAylıkRapor_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarih.Value;
            AylikSatisGetir(tarih);
        }
    }
}

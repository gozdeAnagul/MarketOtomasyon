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
            DateTime tarih = dtpTarih.Value;

            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var fisler = new FisRepo().GetAll();

            var RaporAylik = from u in urunler
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
                                  u.UrunBarkod,
                                  k.KategoriAdi,
                                  u.UrunAdi,
                                  f.FisTarihi,
                                  f.GenelToplam,
                                  f.OdemeYontemi,
                                  u.Stok,
                                  s.SatisAdeti
                              }
                                 into gp
                              orderby gp.Key.KategoriAdi
                              select new
                              {
                                  gp.Key.FisTarihi,
                                  gp.Key.UrunBarkod,
                                  gp.Key.KategoriAdi,
                                  gp.Key.UrunAdi,
                                  gp.Key.OdemeYontemi,
                                  gp.Key.GenelToplam,
                                  SatisAdeti = gp.Key.SatisAdeti

                              };
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
                                        u.UrunBarkod,
                                        k.KategoriAdi,
                                        u.UrunAdi,
                                        f.FisTarihi,
                                        f.GenelToplam,
                                        f.OdemeYontemi,
                                        u.Stok,
                                        s.SatisAdeti
                                    }
                                     into gp
                                    orderby gp.Key.KategoriAdi
                                    select new
                                    {
                                        gp.Key.FisTarihi,
                                        gp.Key.UrunBarkod,
                                        gp.Key.KategoriAdi,
                                        gp.Key.UrunAdi,
                                        gp.Key.OdemeYontemi,
                                        gp.Key.GenelToplam,
                                        SatisAdeti = gp.Key.SatisAdeti
                                       
                                    };
            dgvmRapor.DataSource = RaporGunluk.ToList();

           

        }

        private void btnAylıkRapor_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarih.Value;
            AylikSatisGetir(tarih);
        }
    }
}

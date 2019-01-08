using Market.Models.Entities;
using System.Data.Entity;

namespace Market.DAL
{
    class MyContext : DbContext
    {
        public MyContext() : base("name=MarketCon")
        {

        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
      //  public virtual DbSet<UrunDetay> UrunDetaylar { get; set; }

    }
}

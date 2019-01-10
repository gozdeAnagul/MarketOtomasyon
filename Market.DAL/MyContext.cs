using Market.Models.Entities;
using System.Data.Entity;

namespace Market.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MarketCon")
        {

        }
       
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }      
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<Fis> Fisler { get; set; }
    }
}

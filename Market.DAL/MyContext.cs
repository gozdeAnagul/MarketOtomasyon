using System.Data.Entity;

namespace Market.DAL
{
    class MyContext : DbContext
    {
        public MyContext() : base("name=MarketCon")
        {

        }
    }
}

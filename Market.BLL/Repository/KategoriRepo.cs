using Market.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Market.BLL.Repository
{
    public class KategoriRepo : RepositoryBase<Kategori, int >
    {
        public override List<Kategori> GetAll()
        {
            return base.GetAll().OrderBy(x => x.KategoriAdi).ToList();
        }
    }
}

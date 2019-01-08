using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Repository
{
    class UrunRepo : RepositoryBase<Urun, int>
    {
        public override List<Urun> GetAll()
        {
            return base.GetAll().OrderBy(x => x.UrunAdi).ToList();
        }

        public override int Insert(Urun entity)
        {
            try
            {
                var category = db.Kategoriler.Find(entity.KategoriId);
                if (category == null)
                    throw new Exception("Kategori bulunamadi");
                if (category.Kategoriler.Any())
                    throw new Exception("Ust kategorilere urun ekleyemezsiniz");
                return base.Insert(entity);
            }
            catch
            {
                throw;
            }
        }
    }
}

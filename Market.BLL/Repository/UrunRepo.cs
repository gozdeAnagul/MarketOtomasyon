using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Market.BLL.Repository
{
   public class UrunRepo : RepositoryBase<Urun, int>
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
                    throw new Exception("Urun ekleme hatasi.");
                if (category.Kategoriler.Any())
                    throw new Exception("Ust kategorilere urun ekleyemezsiniz");
                return base.Insert(entity);
            }
            catch
            {
                throw;
            }
        }
        private int BarkodBas(Urun entity)
        {
            if (entity != null && entity.KoliBarkod == null)
            {
                try
                {
                    entity.KoliBarkod = entity.KategoriId + "" + entity.Id + entity.Id;
                    return Update();
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new Exception("Urun bulunamadi veya Barkodu zaten var.");
            }
        }
    }
}

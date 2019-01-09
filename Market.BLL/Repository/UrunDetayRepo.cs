using System;
using System.Collections.Generic;
using System.Linq;
using Market.Models.Entities;

namespace Market.BLL.Repository
{
    public class UrunDetayRepo : RepositoryBase<UrunDetay,int>
    {
        public override List<UrunDetay> GetAll()
        {
            return base.GetAll().OrderBy(x=>x.Aciklama).ToList();
        }

        public override int Insert(UrunDetay entity)
        {
            try
            {
                if (base.Insert(entity) > 0)
                {
                    BarkodBas(entity);
                }
                else
                {
                    throw new Exception("Ekleme Hatası.");
                }
               return base.Insert(entity);
            }
            catch
            {
                throw;
            }
        }

        private void BarkodBas(UrunDetay entity)
        {
            if (entity != null && entity.Barkod==null)
            {
                try
                {
                    entity.Barkod = entity.Urun.KategoriId + "" + entity.UrunId + entity.Id;
                    Update();
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

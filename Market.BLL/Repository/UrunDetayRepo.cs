using System;
using Market.Models.Entities;

namespace Market.BLL.Repository
{
    public class UrunDetayRepo : RepositoryBase<UrunDetay,int>
    {
        public override int Insert(UrunDetay entity)
        {
            try
            {
                if (base.Insert(entity)>0)
                {
                    BarkodBas(entity);
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
        }
    }
}

using Market.Models.Entities;
using System.Collections.Generic;

namespace Market.Models.ViewModels
{
    public class FisViewModel
    {
        public int FisId { get; set; }
        public List<Satis> SatisListesi { get; set; }
        public override string ToString() => $"{FisId} {SatisListesi}";
    }
}

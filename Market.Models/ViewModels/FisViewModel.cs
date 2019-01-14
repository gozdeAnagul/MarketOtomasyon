using System.Collections.Generic;

namespace Market.Models.ViewModels
{
    public class FisViewModel
    {
        public int FisId { get; set; }
        public List<SatisViewModel> SatisListesi { get; set; }
        public decimal GenelTutar { get; set; }
        public override string ToString() => $"{SatisListesi}";
    }
}

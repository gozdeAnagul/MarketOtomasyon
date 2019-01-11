namespace Market.Models.ViewModels
{
    public class SatisViewModel
    {
        public int UrunId { get; set; }
        public string UrunBarkod { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString() => $"{UrunAdi} X {Adet} = {Fiyat}";
    }
}

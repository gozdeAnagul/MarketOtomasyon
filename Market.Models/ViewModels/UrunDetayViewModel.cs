namespace Market.Models.ViewModels
{
    public class UrunDetayViewModel
    {
        public int UrunDetayId { get; set; }
        public int UrunDetayAdi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString() => $"{UrunDetayAdi} {Fiyat} {Stok}";
        
    }
}

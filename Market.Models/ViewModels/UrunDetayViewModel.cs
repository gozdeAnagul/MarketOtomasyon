using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    class UrunDetayViewModel : Urun
    {
        public int UrunId { get; set; }

        public int KoliIciAdet { get; set; }

        public string Barkod { get; set; }

    
        public string Aciklama { get; set; }

     
        public double Kdv { get; set; }

        public int KoliAdet { get; set; }

        public int UrunAdet { get; set; }

        public decimal AlisFiyat { get; set; }

        public decimal SatisFiyat { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public override string ToString() => $"{UrunAdi} - Adet: {UrunAdet}  KDV ORANI: {Kdv}";
    }
}

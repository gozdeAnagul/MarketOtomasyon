using Market.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("UrunDetaylar")]
    public class UrunDetay : BaseEntity<int>
    {
        public int UrunId { get; set; }

        public int KoliIciAdet { get; set; }
        
        [StringLength(50)]
        [Index("IX_Barkod", IsUnique = true)]
        public string Barkod { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        [Required]
        public double Kdv { get; set; }

        public int KoliAdet { get; set; }

        public int UrunAdet { get; set; }

        public decimal AlisFiyat { get; set; }

        public decimal SatisFiyat { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }

    }
}

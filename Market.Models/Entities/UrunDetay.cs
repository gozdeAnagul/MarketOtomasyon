using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("UrunDetaylar")]
    public class UrunDetay
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid UrunId { get; set; }

        [Required]
        public int KoliIciAdet { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        public int KoliAdet { get; set; }
        public int UrunAdet { get; set; }

        public decimal AlisFiyat { get; set; }

        public decimal SatisFiyat { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        [ForeignKey("UrunId")]
        public Urun Urun { get; set; }
        
    }
}

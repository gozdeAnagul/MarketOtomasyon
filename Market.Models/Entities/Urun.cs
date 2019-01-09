using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Urunler")]
   public class Urun : BaseEntity<int>
    {
        [StringLength(50)]
        [Required]
        [Index("IX_UrunAdi",IsUnique = true)]
        public string UrunAdi { get; set; }
        
        public int KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public Kategori Kategori { get; set; }

        public virtual ICollection<UrunDetay> UrunDetaylar { get; set; } = new HashSet<UrunDetay>();

    }
}

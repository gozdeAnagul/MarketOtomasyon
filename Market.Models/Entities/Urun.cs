using Market.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("UrunDetaylar")]
    public class Urun : BaseEntity<int>
    {

        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string UrunAdi { get; set; }

        public int KoliAdet { get; set; }

        public int KoliIciAdet { get; set; }

        public int UrunAdet { get; set; }

        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Aciklama { get; set; }

        [Required]
        public double Kdv { get; set; }

        [StringLength(50)]
        [Index(IsUnique = true)]
        public string KoliBarkod { get; set; }

        [StringLength(50)]
        [Index(IsUnique = true)]
        public string UrunBarkod { get; set; }

        public decimal AlisFiyat { get; set; }


        public decimal SatisFiyat { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public int KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        public override string ToString() => $@"{Aciklama} {SatisFiyat} {Kdv} {UrunAdet}";
    }
}

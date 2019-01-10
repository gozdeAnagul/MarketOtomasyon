using Market.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Urunler")]
    public class Urun : BaseEntity<int>
    {
        
        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string UrunAdi { get; set; }
        public int KategoriId { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        public int KoliAdet { get; set; } = 0;

        public int KoliIciAdet { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Stok {
            get => KoliAdet*KoliIciAdet; }
        
        [Required]
        public decimal Kdv { get; set; }

        [StringLength(7)]
        [Index(IsUnique = true)]
        public string KoliBarkod { get; set; }

        [StringLength(8)]
        [Index(IsUnique = true)]
        public string UrunBarkod { get; set; }

        public decimal AlisFiyat { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal SatisFiyat {
            get => AlisFiyat + (AlisFiyat*Kdv) + (AlisFiyat/10); }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        public override string ToString() => $@"{UrunAdi} {Aciklama} {Stok}";
    }
}

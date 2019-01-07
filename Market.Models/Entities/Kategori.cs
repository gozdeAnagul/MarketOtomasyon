using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Kategoriler")]
    public class Kategori : BaseEntity2<Guid, Guid>
    {
        public Kategori()
        {
            Id = Guid.NewGuid();
            Id2 = Guid.NewGuid();
        }

        [StringLength(50)]
        [Required]
        public string KategoriAdi { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        public Guid? UstKategoriId { get; set; }

        [Required]
        public double Kdv { get; set; }
        


        [ForeignKey("UstKategoriId")]
        public virtual Kategori UstKategori { get; set; }

        public virtual ICollection<Kategori> Kategoriler { get; set; } = new HashSet<Kategori>();


    }
}

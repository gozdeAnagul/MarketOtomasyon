using Market.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Satislar")]
    public class Satis : BaseEntity<int>
    {
        public int SatisAdeti { get; set; }

        // public decimal AltToplam { get; set; }  Computed olması gerek.

        public int UrunId { get; set; }

        [Required]
        public int FisId { get; set; }

        [ForeignKey("FisId")]
        public Fis Fis { get; set; }

        [ForeignKey("UrunId")]
        public Urun Urun { get; set; }

    }
}

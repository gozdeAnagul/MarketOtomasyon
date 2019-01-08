using Market.Models.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Satislar")]
    public class Satis : BaseEntity<int>
    {
        //public Satis()
        //{
        //    this.Id = Guid.NewGuid();
        //}

        public int UrunDetayId { get; set; }

        public int SatisAdeti { get; set; }

        // public decimal AltToplam { get; set; }  Computed olması gerek.

        [Required]
        public int FisId { get; set; }

        [ForeignKey("FisId")]
        public Fis Fis { get; set; }

        [ForeignKey("UrunDetayId")]
        public UrunDetay UrunDetay { get; set; }


    }
}

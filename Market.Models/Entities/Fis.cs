using Market.Models.Abstracts;
using Market.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Fisler")]
   public class Fis : BaseEntity<int>
    {
       /* [Key]
        public int Id { get; set; }*/
        
        public decimal GenelToplam { get; set; }

        public OdemeYontemi OdemeYontemi { get; set; }

        public DateTime FisTarihi { get; set; } = DateTime.Now;

        public virtual ICollection<Satis> Satislar { get; set; } = new HashSet<Satis>();

    }
}

using Market.Models.Abstracts;
using Market.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Fisler")]
   public class Fis : BaseEntity<int>
    {
        public decimal GenelToplam { get; set; }

        public OdemeYontemi OdemeYontemi { get; set; }

        public DateTime FisTarihi { get; set; } = DateTime.Now;

        public virtual ICollection<Satis> Satislar { get; set; } = new HashSet<Satis>();

        public override string ToString() => $"{Id} {GenelToplam} {FisTarihi}";

    }
}

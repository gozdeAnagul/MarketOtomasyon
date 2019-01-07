using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    [Table("Urunler")]
   public class Urun : BaseEntity<Guid>
    {
        public Urun()
        {
            Id = Guid.NewGuid();
        }
        [StringLength(50)]
        [Required]
        public string UrunAdi { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}

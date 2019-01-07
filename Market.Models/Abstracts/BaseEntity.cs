using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Abstracts
{

   public class BaseEntity<T>
    {
        [Key]
        [Column(Order = 1)]
        public T Id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Abstracts
{

   public abstract class BaseEntity<T>
    {
        [Key]
        [Column(Order = 1)]
        public T Id { get; set; }
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;
    }
}

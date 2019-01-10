using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class UrunKontrolViewModels
    {
        [Required]
        [StringLength(7)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Barkod sadece sayılardan oluşmalıdır")]
        public int KoliBarkod { get; set; }
    }
}

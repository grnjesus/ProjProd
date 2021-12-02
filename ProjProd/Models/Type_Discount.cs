using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjProd.Models
{
    public class Type_Discount
    {
        [Required]
        [Key]
        public int id_type { get; set; }

        [Required]
        [Display(Name = "Тип скидки")]
        public string Name_type { get; set; }

        public IEnumerable<Discounts> Discounts { get; set; }
    }
}

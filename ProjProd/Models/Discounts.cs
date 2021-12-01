using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjProd.Models
{
    public class Discounts
    {
        [Required]
        [Key]
        public int id_discount { get; set; }

        [Required]
        [Display(Name = "Наименование скидки")]
        public string Name_discount { get; set; }

        [Required]
        [Display(Name = "Значение")]
        public string Value_discount { get; set; }

        [Association("fktype_id", "Discounts.type_id", "Type_Discount.id_type")]
        public int type_id { get; set; }

        [Required]
        [Display(Name = "Количество купонов")]
        public float Quantity { get; set; }

        [Required]
        [Display(Name = "Дата окончания")]
        public string End_date { get; set; }

        [Required]
        [Display(Name = "Примечание")]
        public string Note { get; set; }
    }
}

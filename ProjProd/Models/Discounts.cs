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
        public int ID { get; set; }

        [Required]
        [Display(Name = "Купон")]
        public string Name_discount { get; set; }

        [Required]
        [Display(Name = "Значение")]
        public Double Value_discount { get; set; }


        [Required]
        [Range(1, 999)]
        [Display(Name = "Количество купонов")]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 999)]
        [Display(Name = "Дата окончания")]
        public string End_date { get; set; }

        [Required]
        [Display(Name = "Примечание")]
        public string Note { get; set; }


        [Association("fktype_id", "Discounts.Type_Discountid", "Type_Discount.ID")]
        public int? Type_DiscountID { get; set; }
        public Type_Discount Type_Discount { get; set; }
    }
}

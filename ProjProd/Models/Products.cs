using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjProd.Models
{
    public class Products
    {
        [Required]
        [Key]
        public int id_product { get; set; }

        [Required]
        [Display(Name = "Наименование продукта")]
        public string Name_prod { get; set; }

        [Required]
        [Display(Name = "Цена")]
        public float Price { get; set; }

        [Association("fkphoto_id", "Products.photo_id", "Photos_Prod.id_photo")]
        public int photo_id { get; set; }
    }
}

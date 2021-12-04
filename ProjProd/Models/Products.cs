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
        public int ID { get; set; }

        [Required]
        [Display(Name = "Наименование продукта")]
        public string Name_prod { get; set; }

        [Required]
        [Display(Name = "Цена")]
        public Double Price { get; set; }

        [Association("fkphoto_id", "Products.Photos_ProdID", "Photos_Prod.ID")]
        public int? Photos_ProdID { get; set; }

        public Photos_Prod Photos_Prod { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ProjProd.Models
{
    public class Photos_Prod
    {
        [Required]
        [Key]
        public int id_photo { get; set; }

        //[Required]
        //[Display(Name = "Фото")]
        //public IFormFile ImageBite { get; set; }

        [Required]
        [Display(Name = "Подсказка")]
        public string AltText { get; set; }
    }
}

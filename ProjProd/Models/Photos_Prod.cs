using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjProd.Models
{
    public class Photos_Prod
    {
        [Required]
        [Key]
        public int id_photo { get; set; }

        [Required]
        [Display(Name = "Фото")]
        public System.Net.Mime.MediaTypeNames.Image ImageBite { get; set; }

        [Required]
        [Display(Name = "Подсказка")]
        public string AltText { get; set; }
    }
}

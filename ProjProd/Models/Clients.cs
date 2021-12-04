using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjProd.Models
{
    public class Clients
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Имя клиента")]
        public string Name_cl { get; set; }
        [Required]
        [Display(Name = "Фамилия клиента")]
        public string Surname_cl { get; set; }
        [Required]
        [Display(Name = "Отчество клиента")]
        public string Patronymic_cl { get; set; }
        [Required]
        [Display(Name = "Почта клиента")]
        public string Mail_cl { get; set; }
    }
}

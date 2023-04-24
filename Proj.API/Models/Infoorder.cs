using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class Infoorder
    {
        [Key]
        [Column(Order = 1)]
        [Required(ErrorMessage = "Oder ID is required")]
        [Display(Name = "Oder ID")]
        public Order IDoder { get; set; }

        [Key]
        [Column(Order = 2)]
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        public Product Idproduct { get; set; }

        [Column("AllMoney")]
        [Required(ErrorMessage = "Money is required")]
        [Display(Name = "Money")]
        public double Moneyall { get; set; }

        [Column("AllSL")]
        [Required(ErrorMessage = "Number is required")]
        [Display(Name = "Number ID")]
        public int Numberall { get; set; }
    }
}

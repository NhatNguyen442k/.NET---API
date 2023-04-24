using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class Product
    {
        [Column("IDproduct")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        public int IDproduct { get; set; }

        [Column("Nameproduct")]
        [Display(Name = "Name Product")]
        [StringLength(20, ErrorMessage = ("Name must be less than 20 characters"))]
        [Required(ErrorMessage = "Product Name is required")]
        public String Nameproduct { get; set; }

        [Column("Infomation")]
        [Display(Name = "Infomation product")]
        [StringLength(50, ErrorMessage = ("Name must be less than 50 characters"))]
        [Required(ErrorMessage = "Infomation  is required")]
        public String Infomation { get; set; }

        [Column("Money")]
        [Display(Name = "Money product")]
        [Required(ErrorMessage = "Money  is required")]
        public int Money { get; set; }

        [Column("Number")]
        [Display(Name = "Number product")]
        [Required(ErrorMessage = "Number  is required")]
        public int Number { get; set; }

        [Column("Dateupdate")]
        [Display(Name = "Dateupdate product")]
        [Required(ErrorMessage = "Date Update  is required")]
        public DateTime Dateupdate { get; set; }

        [Column("IDcategory")]
        [Required(ErrorMessage = "Category ID is required")]
        [Display(Name = "Category ID")]
        public int IDcategory { get; set; }
        
    }
}

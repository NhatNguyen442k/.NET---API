using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class Categories
    {
        [Column("IDcategory")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Category ID is required")]
        [Display(Name = "Category ID")]
        public int IDcategory { get; set; }

        [Column("Namecategory")]
        [Display(Name = "Name Category")]
        [StringLength(20,ErrorMessage =("Name must be less than 20 characters"))]
        [Required(ErrorMessage = "Category Name is required")]
        public String Namecategory { get; set; }


    }
}

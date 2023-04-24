using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class Users
    {
        [Column("IDuser")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "User ID is required")]
        [Display(Name = "User ID")]
        public int IDuser { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        [StringLength(30, ErrorMessage = ("Name must be less than 30 characters"))]
        [Required(ErrorMessage = "Name is required")]
        public String Nameuser { get; set; }

        [Column("GT")]
        [Display(Name = "GT")]
        [StringLength(5, ErrorMessage = ("Name must be less than 5 characters"))]
        [Required(ErrorMessage = "GT  is required")]
        public String Sex { get; set; }

        [Column("Phonenumber")]
        [Display(Name = "Phonenumber")]
        [Required(ErrorMessage = "Phonenumber  is required")]
        public int Phone { get; set; }

        [Column("Address")]
        [Display(Name = "Address")]
        [StringLength(50, ErrorMessage = ("Address must be less than 50 characters"))]
        [Required(ErrorMessage = "Address  is required")]
        public String Address { get; set; }
    }
}

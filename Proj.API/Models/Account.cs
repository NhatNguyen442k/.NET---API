
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class Account
    {
        [Key]
        [Column(Order = 1)]
        [Required(ErrorMessage = "User ID is required")]
        [Display(Name = "User ID")]
        public Users IDuser { get; set; }

        [Key]
        [Column(Order = 2)]
        [Required(ErrorMessage = "Role ID is required")]
        [Display(Name = "Category ID")]
        public Role IDrole { get; set; }

        [Column("Username")]
        [Display(Name = "Username")]
        [StringLength(30, ErrorMessage = ("Name must be less than 30 characters"))]
        [Required(ErrorMessage = "Username is required")]
        public String Username { get; set; }

        [Column("Password")]
        [Display(Name = "Password")]
        [StringLength(30, ErrorMessage = ("Password must be less than 30 characters"))]
        [Required(ErrorMessage = "Password  is required")]
        public String Password { get; set; }

        
    }
}

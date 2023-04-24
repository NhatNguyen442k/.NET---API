using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class Role
    {
        [Column("IDrole")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Role ID is required")]
        [Display(Name = "Role ID")]
        public int IDrole { get; set; }

        [Column("Namerole")]
        [Display(Name = "Name Role")]
        [StringLength(20, ErrorMessage = ("Name must be less than 20 characters"))]
        [Required(ErrorMessage = "Role Name is required")]
        public String Namerole { get; set; }
    }
}

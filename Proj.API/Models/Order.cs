using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class Order
    {
        [Column("IDorder")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Order ID is required")]
        [Display(Name = "Order ID")]
        public int IDorder { get; set; }

        [Column("Datebuy")]
        [Display(Name = "Datebuy product")]
        [Required(ErrorMessage = "Date Buy  is required")]
        public DateTime Datebuy { get; set; }

        [Column("Dateupdate")]
        [Display(Name = "Dateupdate")]
        [Required(ErrorMessage = "Date Update  is required")]
        public DateTime Dateupdate { get; set; }

        [Column("IDuser")]
        [Required(ErrorMessage = "User ID is required")]
        [Display(Name = "User ID")]
        public Users IDuser { get; set; }
    }
}

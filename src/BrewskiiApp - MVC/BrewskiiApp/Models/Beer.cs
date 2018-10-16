using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrewskiiApp.Models
{
    public class Beer
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Beer Name")]
        public string BeerName { get; set; }

        [Display(Name = "Date Tried")]
        [DataType(DataType.Date)]
        public DateTime DateTried { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Beer Type")]
        public string BeerType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumTime.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Diameter { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [Display(Name = "ListPrice" )]
        [Range(1,1000000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-5000₪")]
        [Range(1, 5000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 5000₪+")]
        [Range(5000, 10000)]
        public double price5 { get; set; }

        [Required]
        [Display(Name = "Price 10000₪+")]
        [Range(10000, 1000000)]
        public double Price10 { get; set; }





    }
}

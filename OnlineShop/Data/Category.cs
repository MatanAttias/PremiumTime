﻿using System.ComponentModel.DataAnnotations;

namespace PremiumTime.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }   
        public int DisplayOrder { get; set; }





    }
}
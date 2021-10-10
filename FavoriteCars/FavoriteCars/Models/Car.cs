using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FavoriteCars.Models
{
    public class Car
    {
        public int ID { get; set; }
        
        public int Year { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Make { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Model { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Trim { get; set; }
    }
}


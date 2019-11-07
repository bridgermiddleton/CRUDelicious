using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dishes
    {
        [Key]
        public int DishId{get;set;}
        [Required]
        public string Name{get;set;}
        [Required]
        public string Chef{get;set;}
        [Required]
        public int Tastiness{get;set;}
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Value must be greater than 0.")]
        public int Calories{get;set;}
        [Required]
        public string Description{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;

        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}
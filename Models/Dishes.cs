using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dishes
    {
        [Key]
        public int DishId{get;set;}
        public string Name{get;set;}
        public string Chef{get;set;}
        public int Tastiness{get;set;}
        public int Calories{get;set;}
        public string Description{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;

        public DateTime UpdatedAt{get;set;} = DateTime.Now;
    }
}
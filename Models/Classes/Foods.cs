using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class Foods
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public int FoodCategoryId { get; set; }
        public string PhotoPath { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
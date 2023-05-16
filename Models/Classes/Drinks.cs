using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class Drinks
    {
        [Key]
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public int DrinkCategoryId { get; set; }
        public string PhotoPath { get; set; }
        public decimal Price { get; set; }
        public virtual DrinkCategory DrinkCategory{ get; set; }
        public ICollection<Sales> Sales { get; set; }

    }
}
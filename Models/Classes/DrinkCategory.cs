using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class DrinkCategory
    {
        [Key]
        public int DrinkCategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Drinks> Drinks { get; set; }
    }
}
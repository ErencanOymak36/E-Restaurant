using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class FoodCategory
    {
        [Key]
        public int FoodCategoryId { get; set; }
        public string FoodName { get; set; }

        public ICollection<Foods> Foods { get; set; }
    }
}
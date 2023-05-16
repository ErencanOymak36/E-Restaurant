using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class Breakfasts
    {
        [Key]
        public int BreakfastId { get; set; }
        public string BreakfastName { get; set; }
        public int BreakfastCategoryId { get; set; }
        public string PhotoPath { get; set; }
        public decimal Price { get; set; }
        public virtual BreakfastCategory BreakfastCategory { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
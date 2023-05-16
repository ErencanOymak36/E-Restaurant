using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class BreakfastCategory
    {
        [Key]
        public int BreakfastCategoryId { get; set; }
        public int CategoryName { get; set; }
        public ICollection<Breakfasts> Breakfasts { get; set; }
    }
}
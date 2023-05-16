using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class DessertCategory
    {
        [Key]
        public int DessertCategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Desserts> Desserts { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class Desserts
    {
        [Key]
        public int DessertId { get; set; }
        public string DessertName { get; set; }
        public int DessertCategoryId { get; set; }
        public string PhotoPath { get; set; }
        public decimal Price { get; set; }
        public virtual DessertCategory DessertCategory { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
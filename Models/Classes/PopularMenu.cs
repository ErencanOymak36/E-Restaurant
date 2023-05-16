using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class PopularMenu
    {
        [Key]
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
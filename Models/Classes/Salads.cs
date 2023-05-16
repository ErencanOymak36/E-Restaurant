using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class Salads
    {
        [Key]
        public int SaladId { get; set; }
        public string SaladName { get; set; }
        public string PhotoPath { get; set; }
        public decimal Price { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
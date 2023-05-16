using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Restaurant.Models.Classes
{
    public class Sales
    {
        public int SalesId { get; set; }
        public decimal SalesAmount { get; set; }
        public virtual Breakfasts breakfasts { get; set; }
        public virtual Desserts Desserts { get; set; }
        public virtual Drinks Drinks { get; set; }
        public virtual Foods Foods { get; set; }
        public virtual PopularMenu PopularMenu { get; set; }
        public virtual Salads Salads { get; set; }
        public virtual StudentMenu StudentMenu { get; set; }
    }
}
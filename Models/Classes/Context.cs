using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace E_Restaurant.Models.Classes
{
    public class Context: DbContext
    {
       
        public DbSet<Admin> MyProperty { get; set; }
        public DbSet<BreakfastCategory> BreakfastCategories { get; set; }
        public DbSet<Breakfasts> Breakfasts { get; set; }
        public DbSet<DessertCategory> DessertCategories { get; set; }
        public DbSet<Desserts> Desserts { get; set; }
        public DbSet<DrinkCategory> DrinkCategories { get; set; }
        public DbSet<Drinks> Drinks { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Foods> Foods { get; set; }
        public DbSet<PopularMenu> PopularMenus { get; set; }
        public DbSet<Salads> Salads { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<StudentMenu> StudentMenus { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
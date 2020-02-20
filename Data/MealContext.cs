using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FamousPortal.Models;



namespace FamousPortal.Data
{
    public class MealContext : DbContext
    {
        public MealContext(DbContextOptions<MealContext> options) : base(options)
        {
        }

        public DbSet<Meal> Meal { get; set; }
    }

   
}

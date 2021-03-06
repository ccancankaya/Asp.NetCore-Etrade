﻿using Etrade.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etrade.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}

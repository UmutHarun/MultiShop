﻿using Microsoft.EntityFrameworkCore;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=...;initial Catalog=MultiShopOrderDb;integrated Security=true;");
        }

        public DbSet<Address> Addresses { get; set;}
        public DbSet<OrderDetail> OrderDetails { get; set;}
        public DbSet<Ordering> Orderings { get; set;}
    }
}

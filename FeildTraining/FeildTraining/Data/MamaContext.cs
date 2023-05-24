﻿using FeildTraining.Models;
using Microsoft.EntityFrameworkCore;

namespace FeildTraining.Data
{
    public class MamaContext:DbContext
    {
        public MamaContext(DbContextOptions<MamaContext> options): base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

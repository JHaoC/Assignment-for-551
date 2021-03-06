﻿
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }
}


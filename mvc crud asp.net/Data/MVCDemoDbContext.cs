using System;
using Microsoft.EntityFrameworkCore;
using mvc_crud_asp.net.Models.Domain;

namespace mvc_crud_asp.net.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options ) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set;}
    }
}


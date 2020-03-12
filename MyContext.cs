using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework
{
    public class MyContext : DbContext
    {
        public DbSet<SavingAccount> Savings { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = AG\SQLEXPRESS;Database=Entity; Integrated Security=True");
        }
    }
}

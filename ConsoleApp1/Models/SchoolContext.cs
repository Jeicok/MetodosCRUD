﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   
    
        public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Cliente> Clientes { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=CRISHANBR\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
            }
        }
    
}

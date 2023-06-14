﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.DAL.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
         : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Тренер" }
              , new Role { Id = 2, Name = "Участник" });

            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        FirstName = "Test",
                        LastName = "Test",
                        UserName = "TestInstructor",
                        Password = "Qwerty12345",
                        RoleId = 1
                    },
                  new User
                  {
                      Id = 2,
                      FirstName = "Test",
                      LastName = "Test",
                      UserName = "TestUser",
                      Password = "Qwerty12345",
                      RoleId = 2
                  }
            );
        }
    }
}
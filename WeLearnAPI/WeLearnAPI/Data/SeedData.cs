using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WeLearnAPI.Models.Domain;

namespace DMS_API.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser<Guid>>();

            // Seeding Roles
            modelBuilder.Entity<IdentityRole<Guid>>(entity =>
            {
                entity.ToTable(name: "AspNetRoles");
                entity.HasData(
                    new IdentityRole<Guid>
                    {
                        Id = Guid.Parse("2c5e174e-3b0e-446f-86af-483d56fd7210"),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                        ConcurrencyStamp = "49f4ba6c-9123-444b-8e44-063342f55684"
                    },
                    new IdentityRole<Guid>
                    {
                        Id = Guid.Parse("0da24f70-3cc9-44b1-a48e-aa9d93635514"),
                        Name = "Teacher",
                        NormalizedName = "TEACHER",
                        ConcurrencyStamp = "0c6b4d64-2431-420d-8568-67b7a4d2d833"
                    }
                );
            });

            // Seeding Admins with 2 roles (Admin and Teacher)
            var admin1Id = Guid.NewGuid();
            var admin2Id = Guid.NewGuid();
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = admin1Id,
                    UserName = "admin1",
                    NormalizedUserName = "ADMIN1",
                    FirstName = "FirstAdmin",
                    LastName = "Admin",
                    Email = "admin1@example.com",
                    NormalizedEmail = "ADMIN1@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin1Password"),
                    Birthday = DateTime.Parse("1980-01-01"),
                    Gender = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Admin
                {
                    Id = admin2Id,
                    UserName = "admin2",
                    NormalizedUserName = "ADMIN2",
                    FirstName = "SecondAdmin",
                    LastName = "Admin",
                    Email = "admin2@example.com",
                    NormalizedEmail = "ADMIN2@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin1Password"),
                    Birthday = DateTime.Parse("1982-01-01"),
                    Gender = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );

            // Assigning Admins to Roles
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid> { UserId = admin1Id, RoleId = Guid.Parse("2c5e174e-3b0e-446f-86af-483d56fd7210") }, // Admin
                new IdentityUserRole<Guid> { UserId = admin1Id, RoleId = Guid.Parse("0da24f70-3cc9-44b1-a48e-aa9d93635514") }, // Teacher
                new IdentityUserRole<Guid> { UserId = admin2Id, RoleId = Guid.Parse("2c5e174e-3b0e-446f-86af-483d56fd7210") }  // Admin
            );

            // Seeding Teachers
            for (int i = 1; i <= 10; i++)
            {
                var teacherId = Guid.NewGuid();
                modelBuilder.Entity<Admin>().HasData(
                    new Admin
                    {
                        Id = teacherId,
                        UserName = $"teacher{i}",
                        NormalizedUserName = $"TEACHER{i}",
                        FirstName = $"Teacher{i}",
                        LastName = "User",
                        Email = $"teacher{i}@example.com",
                        NormalizedEmail = $"TEACHER{i}@EXAMPLE.COM",
                        EmailConfirmed = true,
                        Birthday = DateTime.Parse("1985-01-01"),
                        Gender = 1,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                );
                modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                    new IdentityUserRole<Guid> { UserId = teacherId, RoleId = Guid.Parse("0da24f70-3cc9-44b1-a48e-aa9d93635514") }  // Teacher
                );
            }

            // Seeding Users
            for (int i = 1; i <= 30; i++)
            {
                var userId = Guid.NewGuid();
                modelBuilder.Entity<Users>().HasData(
                    new Users
                    {
                        Id = userId,
                        UserName = $"user{i}",
                        NormalizedUserName = $"USER{i}",
                        FirstName = $"UserFirstName{i}",
                        LastName = $"UserLastName{i}",
                        Email = $"user{i}@example.com",
                        NormalizedEmail = $"USER{i}@EXAMPLE.COM",
                        EmailConfirmed = true,
                        Birthday = DateTime.Parse("1990-01-01"),
                        Gender = 1,
                        RefreshToken = $"refresh_token_{i}",
                        RefreshTokenExpiryTime = DateTime.Now.AddDays(30),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                );
            }

            // Seeding News
            for (int i = 1; i <= 30; i++)
            {
                modelBuilder.Entity<News>().HasData(
                    new News
                    {
                        Id = i,
                        Title = $"News Title {i}",
                        Content = $"This is the content of news {i}",
                        CreatedAt = DateTime.Now,
                        AdminId = admin1Id // or any Admin/Teacher ID
                    }
                );
            }
        }
    }
}

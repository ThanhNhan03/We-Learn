using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace DMS_API.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

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
        }
    }
}

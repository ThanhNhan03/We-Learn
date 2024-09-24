using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearnAPI.Models.Domain;
using DMS_API.Data;

public class ApplicationDbContext : IdentityDbContext<Admin, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Users> AppUsers { get; set; }
    public DbSet<Admin> Admins { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SeedData.Seed(builder);

        builder.Entity<Users>().ToTable("AppUsers");
        builder.Entity<Admin>().ToTable("Admins");

        builder.Entity<News>()
        .HasOne(n => n.Admin)
        .WithMany(a => a.News) 
        .HasForeignKey(n => n.AdminId) 
        .OnDelete(DeleteBehavior.Cascade); 
    }
}


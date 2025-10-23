using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ApartmentsListingDemo.Models;

namespace ApartmentsListingDemo.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<ApartmentsListingDemo.Models.Listing> Listing { get; set; } = default!;

public DbSet<ApartmentsListingDemo.Models.Category> Category { get; set; } = default!;

}

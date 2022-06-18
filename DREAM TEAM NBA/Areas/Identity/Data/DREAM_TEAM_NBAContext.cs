using DREAM_TEAM_NBA.Areas.Identity.Data;
using DREAM_TEAM_NBA.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DREAM_TEAM_NBA.Data;

public class DREAM_TEAM_NBAContext : IdentityDbContext<ApplicationUser>
{
    public DREAM_TEAM_NBAContext(DbContextOptions<DREAM_TEAM_NBAContext> options)
        : base(options)
    {
    }
    public DbSet<Admin> Admin { get; set; }
    public DbSet<Team> Team { get; set; }
    public DbSet<Player> Player { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.Name).HasMaxLength(128);
    }
}
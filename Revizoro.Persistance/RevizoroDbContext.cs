using Microsoft.EntityFrameworkCore;
using Revizoro.Application.Interfaces;
using Revizoro.Persistence.EntityTypeConfigurations;
using Revizorro.Domain;


namespace Revizoro.Persistence
{
    public class RevizoroDbContext : DbContext, IRevizoroDbContext
    {
        public DbSet<Place> Places { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public RevizoroDbContext(DbContextOptions<RevizoroDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PlaceConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            base.OnModelCreating(builder);
        }
    }
}

using Beaver.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beaver.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Form> Forms { get; set; }
        public DbSet<Input> Inputs { get; set; }
        public DbSet<Option> Options { get; set; }
    }
}

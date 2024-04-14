using Microsoft.EntityFrameworkCore;

class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Product> Product { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Color> Color { get; set; }
}

using Microsoft.EntityFrameworkCore;

namespace Product.Model
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        { }
    }
}

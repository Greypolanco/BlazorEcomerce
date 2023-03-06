namespace BlazorEcomerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>option): base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}

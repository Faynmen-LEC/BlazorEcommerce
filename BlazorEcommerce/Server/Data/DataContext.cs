namespace BlazorEcommerce.Server.Data
{
	public class DataContext:DbContext
	{
        public DataContext(DbContextOptions<DbContext>options):base(options)
        {
            
        }

        public DbSet<Driver> Drivers { get; set; }
    }
}

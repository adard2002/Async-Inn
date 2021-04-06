namespace AsyncWeb.Data
{
    public class DbContext
    {
        private DbContextOptions options;

        public DbContext(DbContextOptions options)
        {
            this.options = options;
        }
    }
}
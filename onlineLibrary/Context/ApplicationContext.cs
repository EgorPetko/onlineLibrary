namespace onlineLibrary.Context
{
    using Microsoft.EntityFrameworkCore;

    using onlineLibrary.UserEntities;
    using onlineLibrary.BookEntities;

    public class ApplicationContext : DbContext
    {
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<BookEntity> Books => Set<BookEntity>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;"); //изменить и добавить в конфигурацию
        }
    }
}

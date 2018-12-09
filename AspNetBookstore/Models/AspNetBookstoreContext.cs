using System.Data.Entity;

namespace AspNetBookstore.Models
{
    public class AspNetBookstoreContext : DbContext
    {
        public AspNetBookstoreContext() : base("AspNetBookstoreDB")
        {
            Database.SetInitializer(new Models.SampleData());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
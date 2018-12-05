using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AspNetBookstore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BookstoreEntities>
    {
        protected override void Seed(BookstoreEntities context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Fiction" },
                new Category { Name = "Biography" },
                new Category { Name = "History" },
                new Category { Name = "Romance" }
            };

            var authors = new List<Author>
            {
                new Author { Name = "Andrew Roberts" },
                new Author { Name = "Jon Meacham" }
            };
            
            new List<Book>
            {
                //new Book { Title = "", Author = authors.Single(a => a.Name == ""), Category = categories.Single(c => c.Name == ""), Price = XX.XXM }
                new Book { Title = "Churchill: Walking with Destiny", Author = authors.Single(a => a.Name == "Andrew Roberts"), Category = categories.Single(c => c.Name == "Biography"), Price = 25.00M },
                new Book { Title = "The Soul of America: The Battle for Our Better Angels", Author = authors.Single(a => a.Name == "Jon Meacham"), Category = categories.Single(c => c.Name == "History"), Price = 22.50M }
            }.ForEach(a => context.Books.Add(a));
        }
    }
}
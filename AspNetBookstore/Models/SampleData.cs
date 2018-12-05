using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AspNetBookstore.Models
{
    public class SampleData : DropCreateDatabaseAlways<BookstoreEntities>
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
                new Author { Name = "Jon Meacham" },
                new Author { Name = "George Orwell" },
                new Author { Name = "Jane Austen" }
            };
            
            new List<Book>
            {
                //new Book { Title = "", Author = authors.Single(a => a.Name == ""), Category = categories.Single(c => c.Name == ""), Price = XX.XXM }
                new Book { Title = "Churchill: Walking with Destiny", Author = authors.Single(a => a.Name == "Andrew Roberts"), Category = categories.Single(c => c.Name == "Biography"), Price = 25.00M },
                new Book { Title = "The Soul of America: The Battle for Our Better Angels", Author = authors.Single(a => a.Name == "Jon Meacham"), Category = categories.Single(c => c.Name == "History"), Price = 22.50M },
                new Book { Title = "1984", Author = authors.Single(a => a.Name == "George Orwell"), Category = categories.Single(c => c.Name == "Fiction"), Price = 7.99M },
                new Book { Title = "Pride and Prejudice", Author = authors.Single(a => a.Name == "Jane Austen"), Category = categories.Single(c => c.Name == "Romance"), Price = 12.99M }
            }.ForEach(a => context.Books.Add(a));
        }
    }
}
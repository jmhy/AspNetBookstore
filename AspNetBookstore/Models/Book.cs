using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace AspNetBookstore.Models
{
    [Bind(Exclude = "BookId")]
    public class Book
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }

        [DisplayName("Author")]
        public int AuthorId { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "A Book Title is required")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 9999.99,
            ErrorMessage = "Price must be between 0.01 and 9999.99")]
        public decimal Price { get; set; }

        [DisplayName("Book Cover URL")]
        [StringLength(1024)]
        public string BookCoverUrl { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
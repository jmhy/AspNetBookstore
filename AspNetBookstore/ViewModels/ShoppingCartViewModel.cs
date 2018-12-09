using System.Collections.Generic;
using AspNetBookstore.Models;

namespace AspNetBookstore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
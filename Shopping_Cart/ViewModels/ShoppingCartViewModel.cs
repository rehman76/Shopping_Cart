using System.Collections.Generic;
using Shopping_Cart.Models;

namespace Shopping_Cart.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
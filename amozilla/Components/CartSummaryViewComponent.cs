using Microsoft.AspNetCore.Mvc;
using amozilla.Models;
namespace amozilla.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket cart;
        public CartSummaryViewComponent(Basket basketService)
        {
            cart = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
    
}

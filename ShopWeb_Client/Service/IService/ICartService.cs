using ShopWeb_Client.ViewModels;

namespace ShopWeb_Client.Service.IService
{
    public interface ICartService
    {
        Task DecrementCart(ShoppingCart shoppingCart);
        Task IncrementCart(ShoppingCart shoppingCart);

    }
}

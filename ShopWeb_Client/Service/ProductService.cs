using Shop_Models;
using ShopWeb_Client.Service.IService;

namespace ShopWeb_Client.Service
{
    public class ProductService : IProductService
    {
        public Task<ProductDTO> Get(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

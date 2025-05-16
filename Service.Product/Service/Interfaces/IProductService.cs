using Model.DTO;
using Model.Entities;

namespace Service.Interfaces
{
    public interface IProductService
    {
        Task CreateProduct(ProductPayload payload);
        Task UpdateProduct(int id, ProductPayload payload);
        Task<ProductEntity> GetProductById(int id);
        Task<IEnumerable<ProductEntity>> SearchProducts(string name);
    }
}

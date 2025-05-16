using Model.DTO;
using Model.Entities;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateProduct(ProductPayload payload)
        {
            try
            {
                await _productRepository.CreateProduct(payload);
            }
            catch
            {
                throw;
            }
        }

        public async Task UpdateProduct(int id, ProductPayload payload)
        {
            try
            {
                await _productRepository.UpdateProduct(id, payload);
            }
            catch
            {
                throw;
            }
        }

        public async Task<ProductEntity> GetProductById(int id)
        {
            try
            {
                return await _productRepository.GetProductById(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductEntity>> SearchProducts(string name)
        {
            try
            {
                return await _productRepository.SearchProducts(name);
            }
            catch
            {
                throw;
            }
        }
    }
}

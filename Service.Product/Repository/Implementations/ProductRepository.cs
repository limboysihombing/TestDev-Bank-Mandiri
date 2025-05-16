using Dapper;
using LARS.Models;
using Microsoft.Extensions.Options;
using Model.DTO;
using Model.Entities;
using Repository.Interfaces;
using System.Data;

namespace Repository.Implementations
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(IOptions<AppSetting> setting) : base(setting) { }

        public async Task CreateProduct(ProductPayload payload)
        {
            using var conn = GetConnection();
            await conn.ExecuteAsync("CreateProduct", new
            {
                payload.Name,
                payload.Stock,
                payload.CategoryId
            }, commandType: CommandType.StoredProcedure);
        }

        public async Task UpdateProduct(int id, ProductPayload payload)
        {
            using var conn = GetConnection();
            await conn.ExecuteAsync("UpdateProduct", new
            {
                Id = id,
                payload.Name,
                payload.Stock,
                payload.CategoryId
            }, commandType: CommandType.StoredProcedure);
        }

        public async Task<ProductEntity> GetProductById(int id)
        {
            using var conn = GetConnection();
            var reader = await conn.QueryMultipleAsync("GetProductById", new { Id = id }, commandType: CommandType.StoredProcedure);
            return reader.Read<ProductEntity>().FirstOrDefault();
        }

        public async Task<IEnumerable<ProductEntity>> SearchProducts(string name)
        {
            using var conn = GetConnection();
            var reader = await conn.QueryMultipleAsync("SearchProducts", new { Name = name }, commandType: CommandType.StoredProcedure);
            return reader.Read<ProductEntity>().ToList();
        }
    }
}

using Dapper;
using LARS.Models;
using Microsoft.Extensions.Options;
using Model.DTO;
using Model.Entities;
using Repository.Interfaces;
using System.Data;

namespace Repository.Implementations
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(IOptions<AppSetting> setting) : base(setting) { }

        public async Task CreateCategory(CategoryPayload payload)
        {
            using var conn = GetConnection();
            await conn.ExecuteAsync("CreateCategory", new { payload.Name }, commandType: CommandType.StoredProcedure);
        }

        public async Task UpdateCategory(int id, CategoryPayload payload)
        {
            using var conn = GetConnection();
            await conn.ExecuteAsync("UpdateCategory", new { Id = id, payload.Name }, commandType: CommandType.StoredProcedure);
        }

        public async Task<CategoryEntity> GetCategoryById(int id)
        {
            using var conn = GetConnection();
            var reader = await conn.QueryMultipleAsync("GetCategoryById", new { Id = id }, commandType: CommandType.StoredProcedure);
            return reader.Read<CategoryEntity>().FirstOrDefault();
        }

        public async Task<IEnumerable<CategoryEntity>> SearchCategories(string name)
        {
            using var conn = GetConnection();
            var reader = await conn.QueryMultipleAsync("SearchCategories", new { Name = name }, commandType: CommandType.StoredProcedure);
            return reader.Read<CategoryEntity>().ToList();
        }
    }
}

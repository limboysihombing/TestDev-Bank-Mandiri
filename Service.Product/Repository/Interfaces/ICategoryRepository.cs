using Model.DTO;
using Model.Entities;

namespace Repository.Interfaces
{
    public interface ICategoryRepository
    {
        Task CreateCategory(CategoryPayload payload);
        Task UpdateCategory(int id, CategoryPayload payload);
        Task<CategoryEntity> GetCategoryById(int id);
        Task<IEnumerable<CategoryEntity>> SearchCategories(string name);
    }
}

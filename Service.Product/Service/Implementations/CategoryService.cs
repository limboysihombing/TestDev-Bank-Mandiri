using AutoMapper;
using Model.DTO;
using Model.Entities;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task CreateCategory(CategoryPayload payload)
        {
            try
            {
                await _categoryRepository.CreateCategory(payload);
            }
            catch
            {
                throw;
            }
        }

        public async Task UpdateCategory(int id, CategoryPayload payload)
        {
            try
            {
                await _categoryRepository.UpdateCategory(id, payload);
            }
            catch
            {
                throw;
            }
        }

        public async Task<CategoryEntity> GetCategoryById(int id)
        {
            try
            {
                return await _categoryRepository.GetCategoryById(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<CategoryEntity>> SearchCategories(string name)
        {
            try
            {
                return await _categoryRepository.SearchCategories(name);
            }
            catch
            {
                throw;
            }
        }
    }
}

using API.W.movies.DATA.Models;
using API.W.movies.DATA.Models.Dtos;
using API.W.movies.Repository.IRRepository;
using API.W.movies.Services.IServices;
using AutoMapper;

namespace API.W.movies.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepositori _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepositori categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }   
        public Task<bool> CategoryExistsByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<ICollection<CategoryDto>>(categories);
        }

        public Task<Category> GetCategoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetCategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

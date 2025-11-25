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

        public Task CreateCategoriAsync(CategoryCreateDto categoryCreateDto)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto categoryCreateDto)
        {
          var CayegoryExists = await _categoryRepository.GetCategoryExistsByNameAsync(categoryCreateDto.Name);
            if (CayegoryExists)
            {
                throw new InvalidOperationException($"ya existe una categoria con el nombrede.{categoryCreateDto.Name}");
            }
            var category = _mapper.Map<Category>(categoryCreateDto);
             var categoryCreated  = await _categoryRepository.CreateCategoryAsync(category);
            if (!categoryCreated)
            {
                throw new Exception("Error al crear la categoria");
            }
            return _mapper.Map<CategoryDto>(category);
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
            return  _mapper.Map<ICollection<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetCategoryAsync(int Id)
        {
            var category = await _categoryRepository.GetCategoryAsync(Id);
            return _mapper.Map<CategoryDto>(category);
        }

        public Task<bool> GetCategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> UpdateCategoryAsync(int id, Category categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}

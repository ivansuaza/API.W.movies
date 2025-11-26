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
      

        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto categoryCreateDto)
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

        public async Task<bool> DeleteCategoryAsync(int Id)
        {
          var categoryExists = await _categoryRepository.GetCategoryAsync(Id);
            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontro la categoria con ID: '{Id}'");
            }
            var categoryDeleted = await _categoryRepository.DeleteCategoryAsync(Id);
            if (!categoryDeleted)
            {
                throw new Exception("Error al eliminar la categoria");
            }
            return categoryDeleted;
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            return  _mapper.Map<ICollection<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetCategoryAsync(int Id)
        {
            var category = await _categoryRepository.GetCategoryAsync(Id);
            if (category == null)
            {
                throw new InvalidOperationException($"No se encontro la categoria con ID: '{Id}'");
            }   
            return _mapper.Map<CategoryDto>(category);
        }

        public Task<bool> GetCategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryDto> UpdateCategoryAsync(CategoryCreateUpdateDto dto, int id)
        {
            var CategoryExists = await _categoryRepository.GetCategoryAsync(id);
            if (CategoryExists == null)
            {
                throw new InvalidOperationException($"No se encontro la categoria con ID: '{id}'");
            }
            var nameExists = await _categoryRepository.GetCategoryExistsByNameAsync(dto.Name);

            if (nameExists) 
            {
                throw new InvalidOperationException($"ya existe una categoria con el nombre de.'{dto.Name}'");
            } 
            _mapper.Map(dto, CategoryExists);
            var categoryUpdated = await _categoryRepository.UpdateCategoryAsync(CategoryExists);

            if (!categoryUpdated)
            {
                throw new Exception("Error al actualizar la categoria");
            }
            return _mapper.Map<CategoryDto>(CategoryExists);







        }

        public Task<CategoryDto> UpdateCategoryAsync(int id, Category categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}

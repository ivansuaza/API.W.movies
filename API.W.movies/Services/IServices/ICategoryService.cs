using API.W.movies.DATA.Models;
using API.W.movies.DATA.Models.Dtos;

namespace API.W.movies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); //me retorna una lista de categorias
        Task<CategoryDto> GetCategoryAsync(int Id); //me retorna una categoria por id
        Task<bool> CategoryExistsByIdAsync(int Id); //me crea una categoria
        Task<bool> GetCategoryExistsByNameAsync(string name);
        Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto categoryDto); //me crea una categoria  
        Task<CategoryDto> UpdateCategoryAsync( int id, Category categoryDto); //me actualiza una categoria 
        Task<bool> DeleteCategoryAsync(int Id);
        
    }
}

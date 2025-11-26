using API.W.movies.DATA.Models;
using API.W.movies.DATA.Models.Dtos;


namespace API.W.movies.Repository.IRRepository
{
    public interface ICategoryRepositori
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); //me retorna una lista de categorias
        Task<CategoryDto> GetCategoryAsync(int Id); //me retorna una categoria por id
        Task<bool> CategoryExistsByIdAsync(int Id); //me crea una categoria
        Task<bool> GetCategoryExistsByNameAsync(string name);
        Task<bool> CreateCategoryAsync(Category category); //me crea una categoria  
        Task<bool> UpdateCategoryAsync(Category category); //me actualiza una categoria 
        Task<bool> DeleteCategoryAsync(int Id);
        Task<bool> UpdateCategoryAsync(CategoryDto categoryExists);
    }
}

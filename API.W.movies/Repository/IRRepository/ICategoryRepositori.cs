using API.W.movies.DATA.Models;


namespace API.W.movies.Repository.IRRepository
{
    public interface ICategoryRepositori
    {
        Task<ICollection<Category>> GetCategoriesAsync(); //me retorna una lista de categorias
        Task<Category> GetCategoryAsync(int Id); //me retorna una categoria por id
        Task<bool> CategoryExistsByIdAsync(int Id); //me crea una categoria
        Task<bool> GetCategoryExistsByNameAsync(string name);
        Task<bool> CreateCategoryAsync(Category category); //me crea una categoria  
        Task<bool> UpdateCategoryAsync(Category category); //me actualiza una categoria 
        Task<bool> DeleteCategoryAsync(int Id);
    }
}

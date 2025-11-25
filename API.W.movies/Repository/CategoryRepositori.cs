using API.W.movies.DATA;
using API.W.movies.DATA.Models;
using API.W.movies.DATA.Models.Dtos;
using API.W.movies.Repository.IRRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API.W.movies.Repository
{
    public class CategoryRepositori : ICategoryRepositori
    {
        private readonly ApicationBdContext _context;

        public CategoryRepositori(ApicationBdContext context)
        {
            _context = context;
        }

        public async Task<bool> CategoryExistsByIdAsync(int Id)
        {
            return await _context.Categories
                .AsNoTracking()
          .AnyAsync(c => c.Id == Id);

        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            category.CreatedDate = DateTime.UtcNow;
            var createdCategory = await _context.Categories.AddAsync(category);
            return await _context.SaveChangesAsync() >= 0 ? true : false;

        }

        public async Task<bool> DeleteCategoryAsync(int Id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == Id);
            if (category == null)
            {
                return false;
            }
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync() >= 0 ? true : false;

        }

        public async Task<ICollection<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.AsNoTracking()
           .OrderBy(c => c.Name)
           .ToListAsync();

        }

        public async Task<Category> GetCategoryAsync(int Id)
        {
            return await _context.Categories
           .AsNoTracking()
           .FirstOrDefaultAsync(c => c.Id == Id);

        }

        public async Task<bool> GetCategoryExistsByNameAsync(string name)
        {
            return await _context.Categories
                .AsNoTracking()
          .AnyAsync(c => c.Name == name);
        }

        

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            category.ModifiedDate = DateTime.UtcNow;
            _context.Categories.Update(category);
            return await _context.SaveChangesAsync() >= 0 ? true : false;

        }
    }
}
   
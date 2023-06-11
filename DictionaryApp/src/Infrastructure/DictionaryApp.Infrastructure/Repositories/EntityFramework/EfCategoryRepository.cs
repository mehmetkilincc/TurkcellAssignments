using DictionaryApp.Entities;
using DictionaryApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Infrastructure.Repositories.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly DictionaryAppDbContext _dbContext;
        public EfCategoryRepository(DictionaryAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Category>> GetAllAsync()
        {
            return await _dbContext.Categories.AsNoTracking().ToListAsync();
        }

        public IList<Category> GetAll()
        {
            return _dbContext.Categories.AsNoTracking().ToList();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _dbContext.Categories.FindAsync(id);
        }

        public async Task AddAsync(Category entity)
        {
            await _dbContext.Categories.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category entity)
        {
            _dbContext.Categories.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsExistAsync(int id)
        {
            return await _dbContext.Categories.AnyAsync(category=>category.Id == id);
        }
    }
}

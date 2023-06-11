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
    public class EfAuthorRepository : IAuthorRepository
    {
        private readonly DictionaryAppDbContext _dbContext;
        public EfAuthorRepository(DictionaryAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Author>> GetAllAsync()
        {
            return await _dbContext.Authors.AsNoTracking().ToListAsync();
        }

        public IList<Author> GetAll()
        {
            return _dbContext.Authors.AsNoTracking().ToList();
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            return await _dbContext.Authors.FindAsync(id);
        }

        public async Task AddAsync(Author entity)
        {
            await _dbContext.Authors.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var author = await _dbContext.Authors.FindAsync(id);
            _dbContext.Authors.Remove(author);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Author entity)
        {
            _dbContext.Authors.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsExistAsync(int id)
        {
            return await _dbContext.Authors.AnyAsync(author=>author.Id == id);
        }
    }
}

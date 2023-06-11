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
    public class EfContentRepository : IContentRepository
    {
        private readonly DictionaryAppDbContext _dbContext;
        public EfContentRepository(DictionaryAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<Content>> GetAllAsync()
        {
            var contents = await _dbContext.Contents.Include(c => c.Author).Include(c => c.Category).AsNoTracking().ToListAsync();
            return contents;
        }
        public IList<Content> GetAll()
        {
            return _dbContext.Contents.AsNoTracking().ToList();
        }

        public async Task<Content> GetByIdAsync(int id)
        {
            return await _dbContext.Contents.FindAsync(id);
        }

        public async Task AddAsync(Content entity)
        {
            await _dbContext.Contents.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var content = await _dbContext.Contents.FindAsync(id);
            _dbContext.Contents.Remove(content);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Content entity)
        {
            _dbContext.Contents.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsExistAsync(int id)
        {
           return await _dbContext.Contents.AnyAsync(content=>content.Id == id);
        }
    }
}

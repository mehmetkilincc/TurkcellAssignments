using DictionaryApp.Entities;
using DictionaryApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Infrastructure.Repositories.EntityFramework
{
    public class EfUserRepository : IUserRepository
    {
        private readonly DictionaryAppDbContext _dbContext;

        public EfUserRepository(DictionaryAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<User>> GetAllAsync()
        {
            return await _dbContext.Users.AsNoTracking().ToListAsync();
        }

        public IList<User> GetAll()
        {
            return _dbContext.Users.AsNoTracking().ToList();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task AddAsync(User entity)
        {
            await _dbContext.Users.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(User entity)
        {
            _dbContext.Users.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsExistAsync(int id)
        {
            return await _dbContext.Users.AnyAsync(user=>user.Id == id);
        }
    }
}

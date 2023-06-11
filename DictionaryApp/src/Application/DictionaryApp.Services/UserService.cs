using DictionaryApp.Entities;
using DictionaryApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> ValidateUser(string username, string password)
        {
            var users =await _userRepository.GetAllAsync();
            return users.SingleOrDefault(user => user.Username == username && user.Password == password);
        }
    }
}

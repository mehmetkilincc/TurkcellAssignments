using DictionaryApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Services
{
    public interface IUserService
    {
        Task<User?> ValidateUser(string username, string password);
    }
}

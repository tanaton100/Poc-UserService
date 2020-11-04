using POC_UserService.Models;
using POC_UserService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace POC_UserService.Service
{
    public interface IUserService
    {
        Task AddAsync(User model);
        Task DeleteAsync(Expression<Func<User, bool>> predicate);
        Task UpdateAsync(User model);
        Task<User> GetAsync(Expression<Func<User, bool>> predicate);
        Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate);
    }
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddAsync(User model)
            => await _userRepository.AddAsync(model);

        public async Task DeleteAsync(Expression<Func<User, bool>> predicate)
           => await _userRepository.DeleteAsync(predicate);

        public async Task UpdateAsync(User model)
          => await _userRepository.UpdateAsync(model);

        public async Task<User> GetAsync(Expression<Func<User, bool>> predicate)
            => await _userRepository.GetAsync(predicate);

        public async Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate)
            => await _userRepository.FindAsync(predicate);
    }
}

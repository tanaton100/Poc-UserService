<<<<<<< HEAD
﻿using AdvancedInfoService.Mimo.gitlabservice.Commons.Mongo;
using POC_UserService.Commons.Mongo;
=======
﻿using POC_UserService.Commons.Mongo;
>>>>>>> 66c8e29 (Rename NameSpace)
using POC_UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace POC_UserService.Repository
{
    public interface IUserRepository
    {
        Task AddAsync(User model);
        Task DeleteAsync(Expression<Func<User, bool>> predicate);
        Task UpdateAsync(User model);
        Task<User> GetAsync(Expression<Func<User, bool>> predicate);
        Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate);
    }
    public class UserRepository : IUserRepository
    {
        private readonly IMongoRepository<User> _mongoRepository;

        public UserRepository(IMongoRepository<User> mongoRepository)
        {
            _mongoRepository = mongoRepository;
        }

        public Task AddAsync(User model)
             => _mongoRepository.AddAsync(model);

        public Task DeleteAsync(Expression<Func<User, bool>> predicate)
            => _mongoRepository.DeleteAsync(predicate);

        public Task UpdateAsync(User model)
            => _mongoRepository.UpdateAsync(_ => _.Id == model.Id, model);

        public async Task<User> GetAsync(Expression<Func<User, bool>> predicate)
            => await _mongoRepository.GetAsync(predicate);

        public async Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate)
            => await _mongoRepository.FindAsync(predicate);
    }
}

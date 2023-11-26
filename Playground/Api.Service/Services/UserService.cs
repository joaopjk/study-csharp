using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _userRepository;

        public UserService(IRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<UserEntity> Get(Guid id)
        {
            return await _userRepository.SelectAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _userRepository.SelectAsync();
        }

        public async Task<UserEntity> Post(UserEntity entity)
        {
            return await _userRepository.InsertAsync(entity);
        }

        public async Task<UserEntity> Put(UserEntity entity)
        {
            return await _userRepository.UpdateAsync(entity);
        }
    }
}

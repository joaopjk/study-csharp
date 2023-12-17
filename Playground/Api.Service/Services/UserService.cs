using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using AutoMapper;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<UserEntity> _userRepository;

        public UserService(IMapper mapper, IRepository<UserEntity> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<UserDto> Get(Guid id)
        {
            return _mapper.Map<UserDto>(await _userRepository.SelectAsync(id));
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<UserDto>>(await _userRepository.SelectAsync());
        }

        public async Task<UserDtoCreateResult> Post(UserDto userDto)
        {
            return _mapper.Map<UserDtoCreateResult>(
                await _userRepository.InsertAsync(_mapper.Map<UserEntity>(userDto)));
        }

        public async Task<UserDtoUpdateResult> Put(UserDto userDto)
        {
            return _mapper.Map<UserDtoUpdateResult>(
                await _userRepository.UpdateAsync(_mapper.Map<UserEntity>(userDto)));
        }
    }
}

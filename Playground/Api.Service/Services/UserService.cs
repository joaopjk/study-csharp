using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<UserDtoCreateResult> Post(UserDtoCreate userDtoCreate)
        {
            return _mapper.Map<UserDtoCreateResult>(
                await _userRepository.InsertAsync(_mapper.Map<UserEntity>(userDtoCreate)));
        }

        public async Task<UserDtoUpdateResult> Put(UserDtoUpdate userDtoUpdate)
        {
            return _mapper.Map<UserDtoUpdateResult>(
                await _userRepository.UpdateAsync(_mapper.Map<UserEntity>(userDtoUpdate)));
        }
    }
}

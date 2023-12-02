﻿using Api.Domain.Interfaces.Services.User;
using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Repositories;

namespace Api.Service.Services
{
    internal class LoginService : ILoginService
    {
        private readonly IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindByLogin(UserEntity user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
                return await _repository.FindByLogin(user.Email);
            return null;
        }
    }
}

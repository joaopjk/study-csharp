using System;
using System.Collections.Generic;
using Api.Domain.Dtos.User;
using Bogus;

namespace Api.Service.Tests.User
{
    public class UserTests
    {
        public static Guid IdUsuario { get; set; }
        public static string NomeUsuario { get; set; }
        public static string EmailUsuario { get; set; }
        public static string NomeUsuarioAlterado { get; set; }
        public static string EmailUsuarioAlterado { get; set; }
        public List<UserDto> ListaUserDto = new List<UserDto>();
        public UserDto User;
        public UserDtoCreate UserCreate;
        public UserDtoCreateResult UserCreateResult;
        public UserDtoUpdate UserUpdate;
        public UserDtoUpdateResult UserUpdateResult;

        public UserTests()
        {
            var faker = new Faker("pt_BR");

            IdUsuario = Guid.NewGuid();
            NomeUsuario = faker.Name.FirstName();
            EmailUsuario = faker.Internet.Email();
            NomeUsuarioAlterado = faker.Name.FirstName();
            EmailUsuarioAlterado = faker.Internet.Email();

            for (var i = 0; i < 10; i++)
            {
                ListaUserDto.Add(new UserDto
                {
                    Id = new Guid(),
                    Name = faker.Name.FirstName(),
                    Email = faker.Internet.Email()
                });
            }

            User = new UserDto
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario,
            };

            UserCreate = new UserDtoCreate
            {
                Name = NomeUsuario,
                Email = EmailUsuario
            };

            UserCreateResult = new UserDtoCreateResult
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario,
                CreateAt = DateTime.Now
            };

            UserUpdate = new UserDtoUpdate()
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario
            };

            UserUpdateResult = new UserDtoUpdateResult
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario,
                UpdateAt = DateTime.Now
            };
        }

    }
}

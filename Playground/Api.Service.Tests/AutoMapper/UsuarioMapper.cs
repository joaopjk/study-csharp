using System;
using System.Collections.Generic;
using System.Linq;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using Bogus;
using Xunit;

namespace Api.Service.Tests.AutoMapper
{
    public class UsuarioMapper : BaseTestService
    {
        [Fact]
        public void E_possivel_mapear_os_modelos()
        {
            var faker = new Faker("pt_BR");

            var model = new UserModel
            {
                Id = Guid.NewGuid(),
                Name = faker.Name.FirstName(),
                Email = faker.Internet.Email(),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var dtoToEntity = Mapper.Map<UserEntity>(model);
            Assert.Equal(dtoToEntity.Id, model.Id);
            Assert.Equal(dtoToEntity.Name, model.Name);
            Assert.Equal(dtoToEntity.Email, model.Email);
            Assert.Equal(dtoToEntity.CreateAt, model.CreateAt);
            Assert.Equal(dtoToEntity.UpdateAt, model.UpdateAt);

            var userDto = Mapper.Map<UserDto>(dtoToEntity);
            Assert.Equal(dtoToEntity.Id, userDto.Id);
            Assert.Equal(dtoToEntity.Name, userDto.Name);
            Assert.Equal(dtoToEntity.Email, userDto.Email);
            Assert.Equal(dtoToEntity.UpdateAt, userDto.UpdateAt);

            var listEntity = new List<UserEntity>();
            for (var i = 0; i < 10; i++)
            {
                listEntity.Add(new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = faker.Name.FirstName(),
                    Email = faker.Internet.Email(),
                    UpdateAt = DateTime.UtcNow,
                    CreateAt = DateTime.UtcNow
                });
            }
            var listDto = Mapper.Map<List<UserDto>>(listEntity);
            Assert.True(listEntity.Count() == listDto.Count());
            for (var i = 0; i < listEntity.Count ; i++)
            {
                Assert.Equal(listDto[i].Id,listEntity[i].Id);
                Assert.Equal(listDto[i].Name, listEntity[i].Name);
                Assert.Equal(listDto[i].Email, listEntity[i].Email);
                Assert.Equal(listDto[i].CreateAt, listEntity[i].CreateAt);
                Assert.Equal(listDto[i].UpdateAt, listEntity[i].UpdateAt);
            }

            var userDtoCreateResult = Mapper.Map<UserDtoCreateResult>(dtoToEntity);
            Assert.Equal(dtoToEntity.Id, userDtoCreateResult.Id);
            Assert.Equal(dtoToEntity.Name, userDtoCreateResult.Name);
            Assert.Equal(dtoToEntity.Email, userDtoCreateResult.Email);
            Assert.Equal(dtoToEntity.CreateAt, userDtoCreateResult.CreateAt);

            var userDtoUpdateResult = Mapper.Map<UserDtoUpdateResult>(dtoToEntity);
            Assert.Equal(dtoToEntity.Id, userDtoUpdateResult.Id);
            Assert.Equal(dtoToEntity.Name, userDtoUpdateResult.Name);
            Assert.Equal(dtoToEntity.Email, userDtoUpdateResult.Email);
            Assert.Equal(dtoToEntity.UpdateAt, userDtoUpdateResult.UpdateAt);

            var userModel = Mapper.Map<UserModel>(userDto);
            Assert.Equal(userModel.Id, userDto.Id);
            Assert.Equal(userModel.Name, userDto.Name);
            Assert.Equal(userModel.Email, userDto.Email);
            Assert.Equal(userModel.CreateAt, userDto.CreateAt);
            Assert.Equal(userModel.UpdateAt, userDto.UpdateAt);

            var userDtoCreate = Mapper.Map<UserDtoCreate>(userModel);
            Assert.Equal(userDtoCreate.Name, userDto.Name);
            Assert.Equal(userDtoCreate.Email, userDto.Email);

            var userDtoUpdate = Mapper.Map<UserDtoUpdate>(userModel);
            Assert.Equal(userDtoUpdate.Id, userDto.Id);
            Assert.Equal(userDtoUpdate.Name, userDto.Name);
            Assert.Equal(userDtoUpdate.Email, userDto.Email);
        }
    }
}

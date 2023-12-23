using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services.User;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Api.Application.Tests
{
    public class UsersControllerTest
    {
        private UsersController _controller;
        private readonly Faker _faker = new Faker();

        [Fact]
        public async Task E_possivel_invocar_a_user_controller_create()
        {
            var serviveMock = new Mock<IUserService>();
            var url = new Mock<IUrlHelper>();

            var nome = _faker.Name.FirstName();
            var email = _faker.Internet.Email();
            var userDto = new UserDtoCreate()
            {
                Name = nome,
                Email = email
            };
            var userDtoCreateResult = new UserDtoCreateResult
            {
                Id = Guid.NewGuid(),
                Name = nome,
                Email = email,
                CreateAt = DateTime.UtcNow
            };

            serviveMock.Setup(m => m.Post(It.IsAny<UserDtoCreate>())).ReturnsAsync(
                userDtoCreateResult);
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>()))
                .Returns("http://localhost:5100");

            _controller = new UsersController(serviveMock.Object)
            {
                Url = url.Object
            };

            var result = await _controller.Post(userDto);
            Assert.True(result is CreatedResult);

            var resultValue = ((CreatedResult)result).Value as UserDtoCreateResult;
            Assert.NotNull(resultValue);
            Assert.Equal(userDtoCreateResult.Name, resultValue.Name);
            Assert.Equal(userDtoCreateResult.Email, resultValue.Email);
        }

        [Fact]
        public async Task Bad_request_user_controller_create()
        {
            var serviveMock = new Mock<IUserService>();
            var url = new Mock<IUrlHelper>();

            serviveMock.Setup(m => m.Post(It.IsAny<UserDtoCreate>())).ReturnsAsync(
                It.IsAny<UserDtoCreateResult>());
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>()))
                .Returns("http://localhost:5100");

            _controller = new UsersController(serviveMock.Object)
            {
                Url = url.Object
            };
            _controller.ModelState.AddModelError("Name", "Name é um campo obrigatório!");

            var result = await _controller.Post(new UserDtoCreate());
            Assert.True(result is BadRequestObjectResult);
        }

        [Fact]
        public async Task E_possivel_invocar_a_user_controller_delete()
        {
            var serviveMock = new Mock<IUserService>();
            var url = new Mock<IUrlHelper>();

            serviveMock.Setup(m => m.Delete(It.IsAny<Guid>())).ReturnsAsync(
                true);
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>()))
                .Returns("http://localhost:5100");

            _controller = new UsersController(serviveMock.Object)
            {
                Url = url.Object
            };

            var result = await _controller.Delete(Guid.NewGuid());
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value;
            Assert.True((bool)resultValue);
        }

        [Fact]
        public async Task Bad_request_ao_invocar_a_user_controller_delete()
        {
            var serviveMock = new Mock<IUserService>();
            var url = new Mock<IUrlHelper>();

            serviveMock.Setup(m => m.Delete(It.IsAny<Guid>())).ReturnsAsync(
                true);
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>()))
                .Returns("http://localhost:5100");

            _controller = new UsersController(serviveMock.Object)
            {
                Url = url.Object
            };
            _controller.ModelState.AddModelError("id","Formato inválido!");

            var result = await _controller.Delete(Guid.NewGuid());
            Assert.True(result is BadRequestObjectResult);
            Assert.False(_controller.ModelState.IsValid);
        }

        [Fact]
        public async Task E_possivel_invocar_a_user_controller_get()
        {
            var serviveMock = new Mock<IUserService>();
            var url = new Mock<IUrlHelper>();

            var nome = _faker.Name.FirstName();
            var email = _faker.Internet.Email();
            var userDto = new UserDto()
            {
                Id = Guid.NewGuid(),
                Name = nome,
                Email = email,
                CreateAt = DateTime.UtcNow
            };

            serviveMock.Setup(m => m.Get(It.IsAny<Guid>())).ReturnsAsync(
                userDto);
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>()))
                .Returns("http://localhost:5100");

            _controller = new UsersController(serviveMock.Object)
            {
                Url = url.Object
            };

            var result = await _controller.Get(It.IsAny<Guid>());
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value as UserDto;
            Assert.NotNull(resultValue);
            Assert.Equal(nome, resultValue.Name);
            Assert.Equal(email, resultValue.Email);
        }

        [Fact]
        public async Task Bad_request_ao_invocar_a_user_controller_get()
        {
            var serviveMock = new Mock<IUserService>();
            var url = new Mock<IUrlHelper>();

            var nome = _faker.Name.FirstName();
            var email = _faker.Internet.Email();
            var userDto = new UserDto()
            {
                Id = Guid.NewGuid(),
                Name = nome,
                Email = email,
                CreateAt = DateTime.UtcNow
            };

            serviveMock.Setup(m => m.Get(It.IsAny<Guid>())).ReturnsAsync(
                userDto);
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>()))
                .Returns("http://localhost:5100");

            _controller = new UsersController(serviveMock.Object)
            {
                Url = url.Object
            };
            _controller.ModelState.AddModelError("Error","");
            var result = await _controller.Get(It.IsAny<Guid>());
            Assert.True(result is BadRequestObjectResult);
        }

        [Fact]
        public async Task E_possivel_invocar_a_user_controller_getall()
        {
            var serviveMock = new Mock<IUserService>();
            var url = new Mock<IUrlHelper>();

            serviveMock.Setup(m => m.GetAll()).ReturnsAsync(
                new List<UserDto>());
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>()))
                .Returns("http://localhost:5100");

            _controller = new UsersController(serviveMock.Object)
            {
                Url = url.Object
            };

            var result = await _controller.Get(It.IsAny<Guid>());
            Assert.True(result is OkObjectResult);
        }
    }
}

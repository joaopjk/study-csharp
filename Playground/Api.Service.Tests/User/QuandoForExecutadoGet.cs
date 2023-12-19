using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services.User;
using Moq;
using Xunit;

namespace Api.Service.Tests.User
{
    public class QuandoForExecutadoGet : UserTests
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact]
        public async Task E_possivel_executar_get()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Get(IdUsuario)).ReturnsAsync(User);
            _service = _serviceMock.Object;

            var result = await _service.Get(IdUsuario);
            Assert.NotNull(result);
            Assert.True(result.Id == User.Id);
            Assert.True(result.Name == User.Name);
            Assert.True(result.Email == User.Email);

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).Returns(Task.FromResult((UserDto)null));
            _service = _serviceMock.Object;

            result = await _service.Get(It.IsAny<Guid>());
            Assert.Null(result);

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(ListaUserDto);
            _service = _serviceMock.Object;

            var results = await _service.GetAll();
            Assert.NotNull(results);
            Assert.True(results.Count() == 10);

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.GetAll()).ReturnsAsync(new List<UserDto>());
            _service = _serviceMock.Object;

            results = await _service.GetAll();
            Assert.Empty(results);
        }
    }
}

using System;
using System.Threading.Tasks;
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
        }
    }
}

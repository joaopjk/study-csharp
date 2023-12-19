using System;
using Api.Domain.Interfaces.Services.User;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Tests.User
{
    public class QuandoForExecutadoDelete : UserTests
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact]
        public async Task E_possivel_executar_delete()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Delete(IdUsuario)).ReturnsAsync(true);
            _service = _serviceMock.Object;

            var result = await _service.Delete(IdUsuario);
            Assert.True(result);

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Delete(It.IsAny<Guid>())).ReturnsAsync(false);
            _service = _serviceMock.Object;

            result = await _service.Delete(It.IsAny<Guid>());
            Assert.False(result);
        }
    }
}

using Api.Domain.Interfaces.Services.User;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Tests.User
{
    public class QuandoForExecutadoUpdate : UserTests
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact]
        public async Task E_possivel_executar_put()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Put(UserUpdate)).ReturnsAsync(UserUpdateResult);
            _service = _serviceMock.Object;

            var result = await _service.Put(UserUpdate);
            Assert.NotNull(result);
            Assert.Equal(UserUpdateResult.Name, result.Name);
            Assert.Equal(UserUpdateResult.Email, result.Email);
        }
    }
}

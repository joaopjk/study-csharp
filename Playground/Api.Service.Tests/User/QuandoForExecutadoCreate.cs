using Api.Domain.Interfaces.Services.User;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Tests.User
{
    public class QuandoForExecutadoCreate : UserTests
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact]
        public async Task E_possivel_executar_post()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Post(UserCreate)).ReturnsAsync(UserCreateResult);
            _service = _serviceMock.Object;

            var result = await _service.Post(UserCreate);
            Assert.NotNull(result);
            Assert.Equal(UserCreateResult.Name, result.Name);
            Assert.Equal(UserCreateResult.Email, result.Email);
        }
    }
}

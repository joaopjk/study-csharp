using System;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Interfaces.Services.User;
using Bogus;
using Moq;
using Xunit;

namespace Api.Service.Tests.Login
{
    public class QuandoForExecutadoFindByLogin
    {
        private ILoginService _service;
        private Mock<ILoginService> _serviceMock;

        [Fact]
        public async Task E_possivel_executar_metodo_find_by_login()
        {
            var faker = new Faker();
            
            var email = faker.Internet.Email();
            var objetoRetorno = new
            {
                authenticated = true,
                createDate = DateTime.UtcNow.ToString("yyy-MM-dd HH:mm:ss"),
                expirationDate = DateTime.UtcNow.ToString("yyy-MM-dd HH:mm:ss"),
                accessToken = Guid.NewGuid(),
                userName = email,
                message = "Usuário logado com sucesso"
            };
            var loginDto = new LoginDto
            {
                Email = email
            };

            _serviceMock = new Mock<ILoginService>();
            _serviceMock.Setup(m => m.FindByLogin(loginDto)).ReturnsAsync(objetoRetorno);
            _service = _serviceMock.Object;

            var result = await _service.FindByLogin(loginDto);
            Assert.NotNull(result);
        }
    }
}

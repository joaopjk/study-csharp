using System;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Bogus;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class UsuarioCrudCompleto : BaseTest, IClassFixture<DbTest>
    {
        private readonly IServiceProvider _serviceProvider;

        public UsuarioCrudCompleto(DbTest dbTest)
        {
            _serviceProvider = dbTest.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD Usuario")]
        public async Task E_possivel_realizar_crud_usuario()
        {
            var faker = new Faker("pt_BR");

            await using var context = _serviceProvider.GetService<MyContext>();
            var repository = new UserImplementation(context);

            var entity = new UserEntity
            {
                Email = faker.Internet.Email(),
                Name = faker.Name.FirstName(),
            };

            var registroCriado = await repository.InsertAsync(entity);
            Assert.NotNull(registroCriado);
            Assert.Equal(entity.Email, registroCriado.Email);
            Assert.Equal(entity.Name, registroCriado.Name);
            Assert.False(registroCriado.Id == Guid.Empty);

            entity.Name = faker.Name.FirstName();
            var registroAtualizado = await repository.UpdateAsync(entity);
            Assert.NotNull(registroAtualizado);
            Assert.Equal(entity.Email, registroAtualizado.Email);
            Assert.Equal(entity.Name, registroAtualizado.Name);

            var registroExiste = await repository.ExistAsync(registroAtualizado.Id);
            Assert.True(registroExiste);

            var registroSelecionado = await repository.SelectAsync(registroAtualizado.Id);
            Assert.NotNull(registroSelecionado);
            Assert.Equal(registroSelecionado.Email, registroAtualizado.Email);
            Assert.Equal(registroSelecionado.Name, registroAtualizado.Name);

            var todosRegistros = await repository.SelectAsync();
            Assert.NotNull(todosRegistros);
            Assert.True(todosRegistros.Any());

            var usuario = await repository.FindByLogin(registroSelecionado.Email);
            Assert.NotNull(usuario);
            Assert.Equal(registroSelecionado.Email, usuario.Email);
            Assert.Equal(registroSelecionado.Name, usuario.Name);

            var removeu = await repository.DeleteAsync(registroSelecionado.Id);
            Assert.True(removeu);
        }
    }
}

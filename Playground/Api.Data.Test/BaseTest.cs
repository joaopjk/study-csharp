using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Data.Test
{
    public abstract class BaseTest
    {
        public BaseTest()
        {

        }
    }

    public class DbTest : IDisposable
    {
        private readonly string _dataBaseName = $"dbApiTest_{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        private readonly ServiceProvider _serviceProvider;

        public DbTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<MyContext>(o =>
            {
                o.UseMySql($@"Server=localhost,3306;Database={_dataBaseName};Uid=root;Pwd=root@1234");
                
            }, ServiceLifetime.Transient);

            _serviceProvider = serviceCollection.BuildServiceProvider();

            using var context = _serviceProvider.GetService<MyContext>(); 
            context.Database.EnsureCreated();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

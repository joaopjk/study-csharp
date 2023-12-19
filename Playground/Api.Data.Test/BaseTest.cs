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
        public ServiceProvider ServiceProvider { get; private set; }

        public DbTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<MyContext>(o =>
            {
                o.UseMySql($@"Server=localhost,3306;Database={_dataBaseName};Uid=root;Pwd=root@1234");

            }, ServiceLifetime.Transient);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            using var context = ServiceProvider.GetService<MyContext>();
            context.Database.EnsureCreated();
        }
        public void Dispose()
        {
            using var context = ServiceProvider.GetService<MyContext>();
            context.Database.EnsureDeleted();
        }
    }
}

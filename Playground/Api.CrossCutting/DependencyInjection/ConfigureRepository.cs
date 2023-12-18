using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repositories;
using Api.Domain.Interfaces;
using Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MyContext>(optionsBuilder =>
                optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("DB_SERVER")!)
            );
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddTransient<IUserRepository, UserImplementation>();
            serviceCollection.AddTransient<IUfRepository, UfImplementation>();
            serviceCollection.AddTransient<IMunicipioRepository, MunicipioImplementation>();
            serviceCollection.AddTransient<ICepRepository, CepImplementation>();
        }
    }
}

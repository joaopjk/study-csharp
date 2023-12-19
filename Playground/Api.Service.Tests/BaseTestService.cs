using System;
using Api.CrossCutting.Mappings;
using AutoMapper;

namespace Api.Service.Tests
{
    public abstract class BaseTestService
    {
        public IMapper Mapper { get; private set; } = new AutoMapperFixture().GetMapper();

        public class AutoMapperFixture : IDisposable
        {
            public IMapper GetMapper()
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new DtoToModelProfile());
                    cfg.AddProfile(new EntityToDtoProfile());
                    cfg.AddProfile(new ModelToEntityProfile());
                });
                return config.CreateMapper();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}

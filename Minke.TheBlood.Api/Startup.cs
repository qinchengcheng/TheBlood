using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Minke.TheBlood.Dal;
using Minke.TheBlood.EFData.Models;
using Minke.TheBlood.IDal;
using Minke.TheBlood.Models;
using PL_Core.Data;
using PL_CoreFrame.Data.EF;

namespace Minke.TheBlood.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }     

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string con = Configuration.GetConnectionString("DbConnection");
            services.AddDbContext<StatisticalSystemContext>(options => { options.UseSqlServer(con, b => b.UseRowNumberForPaging()); });
            AutoMapper.IConfigurationProvider config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            services.AddSingleton(config);
            services.AddScoped<IMapper, Mapper>();
            services.AddScoped(typeof(IEfRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IBloodStock), typeof(BloodStockDal));
            services.AddScoped<IRegions, RegionsDal>();
            services.AddMvc();           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
        public class Mappers
        {
            public static IMapper GetMapper()
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<TBloodStock, BloodStock>();

                });
                var mapper = config.CreateMapper();
                return mapper;
            }
        }
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<TBloodStock, BloodStock>();
            }
        }

    }
}

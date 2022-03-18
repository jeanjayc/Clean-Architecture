using CleanArcMvc.Application.Interfaces;
using CleanArcMvc.Application.Mappings;
using CleanArcMvc.Application.Services;
using CleanArcMvc.Domain.Interfaces;
using CleanArcMvc.Infra.Data.Context;
using CleanArcMvc.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra (this IServiceCollection services,
            IConfiguration configuration)
        {
            //services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            //b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))); //Metodo que irá definir onde as migracoes serao mantidas

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseInMemoryDatabase("DatabaseInMemory"));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }

    }
}

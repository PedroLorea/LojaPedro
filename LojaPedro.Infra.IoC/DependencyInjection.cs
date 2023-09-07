using LojaPedro.Application.Interfaces;
using LojaPedro.Application.Mappings;
using LojaPedro.Application.Services;
using LojaPedro.Domain.Interfaces;
using LojaPedro.Infra.Data.Context;
using LojaPedro.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace LojaPedro.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("LojaPedro.Application");
            //services.AddMediatR(myhandlers);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(myhandlers));


            return services;
        }
    }
}

using DesafioApp.Application.Service;
using DesafioApp.Domain.Repository;
using DesafioApp.Domain.Service;
using DesafioApp.Infra.Data;
using DesafioApp.Infra.Data.Interface;
using DesafioApp.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesafioApp.Infra.CrossCutting
{
    public class BootStrapper
    {
        private static readonly string DATABASE_HOST = Environment.GetEnvironmentVariable("HOST");
        private static readonly string DATABASE_PORT = Environment.GetEnvironmentVariable("PORT");
        private static readonly string DATABASE_USER = Environment.GetEnvironmentVariable("USER");
        private static readonly string DATABASE_PASS = Environment.GetEnvironmentVariable("PASS");
        private static readonly string DATABASE_NAME = Environment.GetEnvironmentVariable("DATABASE_NAME");

        public static void RegisterServices(IServiceCollection services)
        {
            // Service
            services.AddScoped<IUsuarioService, UsuarioService>();

            // Repository
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            //connectionString
            var connectionString = $"Server={DATABASE_HOST}{(string.IsNullOrEmpty(DATABASE_PORT) ? "" : "," + DATABASE_PORT)};Database={DATABASE_NAME};User Id={DATABASE_USER};Password={DATABASE_PASS}";

            services.AddHealthChecks()
                    .AddSqlServer(connectionString);

            //Context
            services.AddScoped<IContext, Context>();
            services.AddDbContext<Context>(options => options
                    .UseSqlServer(connectionString, sqlServerOptions => sqlServerOptions.CommandTimeout(30)));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}

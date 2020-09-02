﻿using Livraria.Data.Repository;
using Livraria.Domain.Interfaces.Alteradores;
using Livraria.Domain.Interfaces.Armazenadores;
using Livraria.Domain.Interfaces.Repository;
using Livraria.Domain.Interfaces.Validadores;
using Livraria.Domain.Serviços.Alteradores;
using Livraria.Domain.Serviços.Armazenadores;
using Livraria.Domain.Serviços.Validadores;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Livraria.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IArmazenadorDeLivro), typeof(ArmazenadorDeLivro));
            services.AddScoped(typeof(ILivroRepositorio), typeof(LivroRepositorio));
            services.AddScoped(typeof(IAutorRepositorio), typeof(AutorRepositorio));
            services.AddScoped(typeof(IValidadorDelivro), typeof(ValidadorDeLivro));
            services.AddScoped(typeof(IAlteradorDeLivro), typeof(AlteradorDeLivro));
        }
    }
}

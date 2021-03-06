﻿using CommonServices.DatabaseOperator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CommonServices.AccountServices;

namespace CommonServices
{
    public static class CommonServicesDependencyInjector
    {
        public static IServiceCollection AddDatabaseConnector(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseConnector, DatabaseConnector>();
            return services;
        }
        public static IServiceCollection AddFileManager(this IServiceCollection services)
        {
            services.AddScoped<IFileManagerService, FileManagerService>();
            return services;
        }
        public static IServiceCollection AddAccountService(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            return services;
        }
        
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddScoped<IMapper>();
            return services;
        }
    }
}

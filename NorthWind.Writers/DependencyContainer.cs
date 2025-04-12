﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.Writers;
using NorthWindEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependecyInjection;
    public static class DependencyContainer
    {
        public static IServiceCollection AddConsoleWriter(this IServiceCollection services)
            {
                services.AddSingleton<IUserActionWriter, ConsoleWriter>();
                return services;
            }
        public static IServiceCollection AddDebugWriter(this IServiceCollection services)
            {
                services.AddSingleton<IUserActionWriter, DebugWriter>();
                return services;
            }
        public static IServiceCollection AddFileWriter(this IServiceCollection services)
            {
                services.AddSingleton<IUserActionWriter, FileWriter>();
                return services;
            }
}

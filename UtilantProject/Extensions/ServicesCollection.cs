using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtilantProject.Repository;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Extensions
{
    public static class ServicesCollection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAlbum, Album>();
            services.AddScoped<IUtilities, Utilities>();
            services.AddScoped<IDemographic, Demographic>();
            services.AddScoped<IPost, Post>();
            services.AddScoped<IPhoto, Photo>();
            return services;
        }
    }
}

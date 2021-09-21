using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.Catalogo.API.Configurations
{
    public static  class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "NSE.Catalogo.API", Version = "v1" ,
                    Description = "Esta API faz parte do Curso ASP.NET Core Enterprise Applications.",
                    Contact = new OpenApiContact() { Name= "Denis", Email ="denisapsilva07@gmail.com"}
                    
                
                });
            });
        }
    }
}

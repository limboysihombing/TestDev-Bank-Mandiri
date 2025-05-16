using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service.Implementations;
using Service.Interfaces;

namespace Service
{
    public static class DependencyInjection
    {
        public static void AddServices(this IHostApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}

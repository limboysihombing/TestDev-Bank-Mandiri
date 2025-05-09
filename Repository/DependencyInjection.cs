using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Implementations;
using Repository.Interfaces;


namespace Repository
{
    public static class DependencyInjection
    {
        public static void AddRepository(this IHostApplicationBuilder builder)
        {
            builder.Services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}

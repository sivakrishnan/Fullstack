using FullstackBackEnd.Repository;
using FullstackBackEnd.Repository.Interface;

namespace FullstackBackEnd.Extension
{
    public static class ExtDependencyInjection
    {
        public static IServiceCollection AddExtDependencyInjection(this IServiceCollection services)
        {
            // Repository
            services.AddScoped<IRepoGender, RepoGender>();
            return services;
        }
    }
}

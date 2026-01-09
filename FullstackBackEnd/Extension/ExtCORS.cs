namespace FullstackBackEnd.Extension
{
    public static class ExtCORS
    {
        public static IServiceCollection AddExtCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("FullstackBackEndCORSPolicy",
                    policy => policy.WithOrigins("http://localhost:4300", "http://localhost:4300")
                                    .AllowAnyMethod()
                                    .AllowAnyHeader());
            });
            return services;
        }
    }
}

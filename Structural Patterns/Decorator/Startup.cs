using Decorator.Decorator;
using Decorator.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Caching.Memory;

namespace Decorator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped(serviceProvider =>
            {
                var logger = serviceProvider.GetService<ILogger<DataServiceLoggingDecorator>>();
                var memoryCache = serviceProvider.GetService<IMemoryCache>();

                IDataService concreteService = new DataService();
                IDataService loggingDecorator = new DataServiceLoggingDecorator(concreteService, logger);
                IDataService cacheingDecorator = new DataServiceCachingDecorator(loggingDecorator, memoryCache);

                return cacheingDecorator;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

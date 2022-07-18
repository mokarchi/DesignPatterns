using Proxy.Middleware;
using Proxy.Proxy;
using Proxy.Service;

namespace Proxy
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
            services.AddControllers();
            services.AddTransient<IUserContext, UserContext>();
            services.AddTransient<TransactionProccessor>();
            services.AddTransient<ITransactionProccessor, UserAwareTransactionProccessor>(serviceProvider =>
            {
                var userContext = serviceProvider.GetRequiredService<IUserContext>();
                var transactionProccessor = serviceProvider.GetRequiredService<TransactionProccessor>();
                return new UserAwareTransactionProccessor(transactionProccessor, userContext);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<ClientCodeMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

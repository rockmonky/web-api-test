using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

namespace web_api_test;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        IConfiguration = configuration;
    }

    public IConfiguration IConfiguration { get; }


    public void ConfigurationServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen( c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "web_api_test", Version = "v1" });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "web_api_test v1"));
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

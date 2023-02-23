using EmployeeApplication.Handlers;
using EmployeeCore.Interfaces;
using EmployeeInfrastructure.Repository;
using MediatR;


namespace EmployeeAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title="Employee.API",Version="v1"
                });
            });

         

            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(CreateEmployeeHandler));
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

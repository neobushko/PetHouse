using BissnessLayer.Handlers.PetHandler;
using BissnessLayer.Handlers.PetHandler.PetChangeName;
using BissnessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PetHouseAPI.Profilers;

namespace PetHouseAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //var connectionString = Configuration.GetConnectionString("Server=localhost;Database=PetHouse;Trusted_Connection=True;");
            services.AddDbContext<PetHouseContext>(options => options.UseSqlServer("Server=DESKTOP-BA1VFR2;Database=PetHouse;Trusted_Connection=True;TrustServerCertificate=true"));
            services.AddAutoMapper(typeof(AutoMapperProfiler));
            services.AddScoped<IRepository<Pet>, PetRepository>();
            services.AddScoped<IPetService, PetService>();
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<PetChangeNameRequestValidator>();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
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

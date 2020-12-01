using AutoMapper;
using DndMonsterApp.DataAccess.Sql.Contexts;
using DndMonsterApp.DataAccess.Sql.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Template.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiVersioning();
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<MonsterAppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("k8s-db"), b => b.MigrationsAssembly("DndMonsterApp.DataAccess.Sql")));

            services.AddTransient<IChallengeRatingRepository, ChallengeRatingRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

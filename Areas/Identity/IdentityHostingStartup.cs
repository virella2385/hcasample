using System;
using System.Data.SqlClient;
using HcaProj.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HcaProj.Models;

[assembly: HostingStartup(typeof(HcaProj.Areas.Identity.IdentityHostingStartup))]
namespace HcaProj.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();
                connBuilder.DataSource = "hcadb.database.windows.net"; 
                connBuilder.UserID = "ultrasa";            
                connBuilder.Password = "8934AAaa";     
                connBuilder.InitialCatalog = "hca";
                
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HcaProjIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HcaProjIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<HcaProjIdentityDbContext>();
            });
/* 
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HcaDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HcaProjIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<HcaProjIdentityDbContext>();
            });
            */
        }
    }
}
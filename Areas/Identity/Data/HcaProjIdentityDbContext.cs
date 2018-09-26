using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HcaProj.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HcaProj.Areas.Identity.Data
{
    public class HcaProjIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public HcaProjIdentityDbContext(DbContextOptions<HcaProjIdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dict_ItemGroupTypes> Dict_ItemGroupTypes { get; set; }
        public DbSet<Dict_ItemTypes> Dict_ItemTypes { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Addresses> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

              builder.Entity<Dict_ItemTypes>()
            .HasOne(i => i.Dict_ItemGroupTypes)
            .WithMany(g => g.ItemTypes)
            .HasForeignKey(i => i.ItemGroupTypesId)
            .HasPrincipalKey(g => g.Dict_ItemGroupTypesId);

            builder.Entity<Addresses>()
            .HasOne(a => a.Contact)
            .WithMany(c => c.Addresses)
            .HasForeignKey(a => a.ContactId)
            .HasPrincipalKey(c => c.ContactsId);
        }
    }
}

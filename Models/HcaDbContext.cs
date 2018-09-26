using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HcaProj.Models
{
    public class HcaDbContext : DbContext
    {
        public HcaDbContext(DbContextOptions<HcaDbContext> options)
            : base(options)
        { }

        public DbSet<Dict_ItemGroupTypes> Dict_ItemGroupTypes { get; set; }
        public DbSet<Dict_ItemTypes> Dict_ItemTypes { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Addresses> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* 
            modelBuilder.Entity<Contacts>()
                .HasKey(c => c.EmailAddress).HasName("PK_EmailAddress");

            modelBuilder.Entity<Addresses>()
            .HasKey(a => a.AddressId).HasName("PK_AddressId");
            */

            

            modelBuilder.Entity<Dict_ItemTypes>()
            .HasOne(i => i.Dict_ItemGroupTypes)
            .WithMany(g => g.ItemTypes)
            .HasForeignKey(i => i.ItemGroupTypesId)
            .HasPrincipalKey(g => g.Dict_ItemGroupTypesId);

            modelBuilder.Entity<Addresses>()
            .HasOne(a => a.Contact)
            .WithMany(c => c.Addresses)
            .HasForeignKey(a => a.ContactId)
            .HasPrincipalKey(c => c.ContactsId);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Z5_TSES
{
    public class ESContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Computer>()
                .Map(map =>
                {
                    map.Properties(p => new
                    {
                        p.CoolingType,
                        p.Description
                    });
                    map.ToTable("PoleTekstowe");
                })
                .Map(map =>
                {
                    map.Properties(p => new
                    {
                        p.Weight,
                        p.Price
                    });
                    map.ToTable("PoleLiczbowe");
                });
        }
    }
}

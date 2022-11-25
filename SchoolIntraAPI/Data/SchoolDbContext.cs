using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolIntraAPI.Data
{
    public class SchoolDbContext: DbContext {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
            { }

        public DbSet<Pupil> School_Intra_Pupils { get; set; } = default!;
        public DbSet<SchoolClass> School_Intra_SchoolClasses { get; set; } = default!;
        public DbSet<ContactPerson> School_Intra_ContactPersons { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pupil>()
                .HasMany<ContactPerson>(s => s.ContactPersons)
                .WithMany(c => c.Pupils)                
                .UsingEntity("School_Intra_PupilContacts");
        }
    }
}   

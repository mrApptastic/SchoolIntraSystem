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

        public DbSet<Pupil> Pupils { get; set; } = default!;
    }
}   

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SteinerAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SteinerAPI.Data
{
    public class SteinerDbContext: DbContext {
        public SteinerDbContext(DbContextOptions<SteinerDbContext> options)
            : base(options)
            { }

        public DbSet<Pupil> Pupils { get; set; } = default!;
    }
}   

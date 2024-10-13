using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMenuSystem.Models;

namespace MvcMenuSystem.Data
{
    public class MvcMenuSystemContext : DbContext
    {
        public MvcMenuSystemContext (DbContextOptions<MvcMenuSystemContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMenuSystem.Models.MenuItem> MenuItem { get; set; } = default!;
    }
}

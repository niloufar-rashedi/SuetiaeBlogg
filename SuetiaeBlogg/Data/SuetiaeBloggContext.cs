using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuetiaeBlogg.Models;

namespace SuetiaeBlogg.Data
{
    public class SuetiaeBloggContext : DbContext
    {
        public SuetiaeBloggContext (DbContextOptions<SuetiaeBloggContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

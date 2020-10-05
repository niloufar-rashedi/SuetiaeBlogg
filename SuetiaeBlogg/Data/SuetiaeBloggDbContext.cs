using Microsoft.EntityFrameworkCore;
using SuetiaeBlogg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuetiaeBlogg.Data
{
    public class SuetiaeBloggDbContext :DbContext
    {
        public SuetiaeBloggDbContext(DbContextOptions<SuetiaeBloggDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

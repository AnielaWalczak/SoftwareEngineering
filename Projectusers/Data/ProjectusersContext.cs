#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projectusers.Models;

namespace Projectusers.Data
{
    public class ProjectusersContext : DbContext
    {
        public ProjectusersContext (DbContextOptions<ProjectusersContext> options)
            : base(options)
        {
        }

        public DbSet<Projectusers.Models.User> User { get; set; }
    }
}

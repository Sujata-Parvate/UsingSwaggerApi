using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsingSwaggerApi.Model;

namespace UsingSwaggerApi.Data
{
    public class UsingSwaggerApiContext : DbContext
    {
        public UsingSwaggerApiContext (DbContextOptions<UsingSwaggerApiContext> options)
            : base(options)
        {
        }
        //public DbSet<User> User { get; set; }
        //public DbSet<Skill> Skill { get; set; }
        //public DbSet<AssessmentStatus> AssessmentStatus { get; set; }

    }
}

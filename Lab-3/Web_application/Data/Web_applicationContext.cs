using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_application.models;

namespace Web_application.Data
{
    public class Web_applicationContext : DbContext
    {
        public Web_applicationContext (DbContextOptions<Web_applicationContext> options)
            : base(options)
        {
        }

        public DbSet<Web_application.models.Beer> Beer { get; set; } = default!;
    }
}

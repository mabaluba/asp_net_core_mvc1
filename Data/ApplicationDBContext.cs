using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_core_mvc1.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net_core_mvc1.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base (options)
        {

        }

        public DbSet<Family> Persons { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCurdApp.Data
{
    public class AppDB:DbContext
    {
        public AppDB(DbContextOptions<AppDB> options ): base(options)
        {

        }

        public DbSet<Employinfo> Employees { get; set; }
    }
}

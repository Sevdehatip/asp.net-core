using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartmentApp.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; database=coreemployee; integrated security=true;");
        }

        public DbSet<department> departments { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}

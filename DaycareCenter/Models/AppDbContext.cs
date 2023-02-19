using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaycareCenter.Models;
using Microsoft.EntityFrameworkCore;
namespace DaycareCenter.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<DaycareCenter.Models.Registration> Registration { get; set; }

        public DbSet<DaycareCenter.Models.ChildProfile> ChildProfile { get; set; }
        public DbSet<DaycareCenter.Models.NanyProfile> NanyProfile { get; set; }
        
        
        public DbSet<DaycareCenter.Models.Shift> Shift { get; set; }
        
        
        public DbSet<DaycareCenter.Models.NanySchedule> NanySchedule { get; set; }
        
       
    }
}

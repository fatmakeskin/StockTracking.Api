using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MasterContext : DbContext
    {
      
        public MasterContext(DbContextOptions<MasterContext> options) : base(options) { }
        public MasterContext()
        {

        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=stock_tracking;Uid=root;Pwd=root");
            base.OnConfiguring(optionsBuilder);
        }
     

    }
}

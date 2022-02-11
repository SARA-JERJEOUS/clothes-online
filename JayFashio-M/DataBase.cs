using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayFashio_M
{
    public class DataBase : DbContext
    {
        public DataBase():base("DBj")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Image> Images { get; set; }
         public DbSet<category> categor { get; set; }

    }
}

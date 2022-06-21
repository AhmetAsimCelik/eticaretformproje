using eticaretformproje.Classlar;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eticaretformproje
{
    internal class Context: DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-N031PB4;Database=ETicaretForm;uid=sa;pwd=1";

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public object Connection { get; internal set; }

        
    }
}

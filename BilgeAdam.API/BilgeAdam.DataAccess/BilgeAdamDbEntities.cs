using BilgeAdam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.DataAccess
{
   

    public partial class BilgeadamDBEntities : DbContext
    {
        public BilgeadamDBEntities()
            : base("name=BilgeadamDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}

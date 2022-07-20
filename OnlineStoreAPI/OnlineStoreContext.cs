using Microsoft.EntityFrameworkCore;
using OnlineStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreAPI
{
    public class OnlineStoreContext : DbContext
    {
        DbSet<Product> Products { get; set; }
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) : base(options) { }

        //protected override void 
    }
}

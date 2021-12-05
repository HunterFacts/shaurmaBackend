using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BackendCoffee.Data
{
    public class ShaurmaContext: DbContext
    {
        public ShaurmaContext()
            : base("DbConnection")
        { }

        public DbSet<Shaurma> Shaurmas { get; set; }
    }
}
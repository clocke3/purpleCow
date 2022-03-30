using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectPurpleCow
{
    public class ItemDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ItemDBContext(DbContextOptions<ItemDBContext> options)
            : base(options)
        {

        }
    }
}

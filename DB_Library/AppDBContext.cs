using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base() { }

        public AppDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace webDrevo.Models
{
    public class TreeContext:DbContext
    {
        public TreeContext(string conSTr)
        {
            Database.Connection.ConnectionString = conSTr;
        }
        public DbSet<Folder>Folders { get; set; }
    }
}
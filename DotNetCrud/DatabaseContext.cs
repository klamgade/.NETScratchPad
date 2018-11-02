using DotNetCrud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetCrud
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {

        }

        //collection of entity classes
        public DbSet<Item> Items { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
    }
}
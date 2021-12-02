using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjProd.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProjProd
{
    public class DBContext : IdentityDbContext<IdentityUser>
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Discounts> discounts { get; set; }
        public DbSet<Clients> clients { get; set; }
        public DbSet<Photos_Prod> photos_Prod { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Type_Discount> type_Discount { get; set; }
    }
}


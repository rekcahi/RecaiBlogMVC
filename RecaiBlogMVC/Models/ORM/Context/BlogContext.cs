using RecaiBlogMVC.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecaiBlogMVC.Models.ORM.Context
{
    public class BlogContext:DbContext//codefirst için gerekli veritabanı işlemleri yapılacak
    {
        public BlogContext()//constracture metot
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-CTLCBOS;Database=BlogDB;Integrated Security=true";

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)//classı tabloya çevirirken "s" AdminUsers şeklinde olmasını engelleme
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<AdminUser> AdminUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<SiteMenu> SiteMenus { get; set; }

        public DbSet<BlogPostComment> BlogPostComments { get; set; }


    }
}
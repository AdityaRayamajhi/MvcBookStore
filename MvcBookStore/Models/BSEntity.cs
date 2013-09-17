using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace MvcBookStore.Models
{
    public class BSEntity : DbContext
    {
        public BSEntity() : base("name=ApplicationServices")
        { }

        public DbSet<genreModel> genres { get; set; }
        public DbSet<writer> writers { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<culture> cultures { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<roleModel> roles { get; set; }
    }
}
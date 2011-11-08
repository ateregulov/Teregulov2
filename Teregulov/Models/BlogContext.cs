using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Teregulov.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Tag> Tags { get; set; }

		//убираем проверку на совпадение схемы данных из-за глюков на сервере
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
			base.OnModelCreating(modelBuilder);
		}
    }

}




using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Data
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    #region Entity Classes
    //public class Blog
    //{
    //    public int BlogId { get; set; }
    //    public string Owner { get; set; }
    //    public string Title { get; set; }
    //    public Blog(int blogId, string owner, string title)
    //    {
    //       this.BlogId = blogId;
    //       this.Owner = owner;
    //       this.Title = title;
    //    }
    //    public Blog() // Parameterless constructor
    //    { } // Just let the properties have their default values
    //}
    public record Blog(int BlogId, string Owner, string Title)
    { public Blog() : this(0, null, null) { } } // declaring a parameterless constructor for my record/class

    public record Post(int PostId, string Title, string Body, int BlogId)
    { public Post() : this(0, null, null, 0) { } }
    #endregion
}

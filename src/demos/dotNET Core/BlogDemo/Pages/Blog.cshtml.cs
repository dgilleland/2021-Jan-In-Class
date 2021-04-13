using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogDemo.Pages
{
    [BindProperties] // Only for situations where all your other properties on your page are for form input
    public class BlogModel : PageModel
    {
        #region Constructor and Dependencies
        private readonly BloggingContext _DbContext;

        public BlogModel(BloggingContext dbContext)
        {
            _DbContext = dbContext;
        }
        #endregion

        public string BlogTitle { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }

        public void OnGet(string blogTitle)
        {
            BlogTitle = blogTitle;
        }

        public IActionResult OnPost()
        {
            // 0) Validation of user input
            if (!string.IsNullOrWhiteSpace(PostTitle) && !string.IsNullOrWhiteSpace(PostBody))
            {
                // 1) Constructing the Post object to save to the database
                var blog = _DbContext.Blogs.SingleOrDefault(x => x.Owner == User.Identity.Name);
                if (blog != null)
                {
                    Post newArticle = new Post() { BlogId = blog.BlogId, Title = PostTitle, Body = PostBody };
                    _DbContext.Posts.Add(newArticle);
                    _DbContext.SaveChanges();
                }
            }
            // Implementing a Post-Redirect-Get pattern
            return RedirectToPage("/Blog", new { BlogTitle = BlogTitle });
        }
    }
}

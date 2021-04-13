using BlogDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Pages
{
    public class IndexModel : PageModel
    {
        // Test Password: Demo.user1
        #region Constructor and Dependencies
        private readonly ILogger<IndexModel> _logger;
        private readonly BloggingContext _DbContext;

        public IndexModel(ILogger<IndexModel> logger, BloggingContext dbContext)
        {
            _logger = logger;
            _DbContext = dbContext;
        }
        #endregion

        #region Model Properties
        public string VisitorName { get; set; }
        public bool IsAuthenticated { get; set; }
        [BindProperty] // Allows this data to be supplied as part of a POST request
        public string BlogTitle { get; set; }
        #endregion

        #region GET/POST handlers
        public void OnGet()
        {
            IsAuthenticated = User.Identity.IsAuthenticated;
            if(IsAuthenticated) // if someone is logged in
            {
                VisitorName = User.Identity.Name; // Their username
                var userBlog = _DbContext.Blogs.SingleOrDefault(x => x.Owner == VisitorName);
                if (userBlog != null)
                    BlogTitle = userBlog.Title;
            }
            else
            {
                VisitorName = "Guest";
            }
        }

        public void OnPost()
        {
            IsAuthenticated = User.Identity.IsAuthenticated;
            if (IsAuthenticated) // if someone is logged in
            {
                VisitorName = User.Identity.Name; // Their username
                var existing = _DbContext.Blogs.SingleOrDefault(x => x.Owner == VisitorName);
                if (existing != null)
                {
                    Blog userBlog = new Blog() { Owner = VisitorName, Title = BlogTitle };
                    _DbContext.Blogs.Add(userBlog);
                    _DbContext.SaveChanges();
                }
            }
        }
        #endregion
    }
}

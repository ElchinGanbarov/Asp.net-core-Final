using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Models.Blogs
{
    public class BlogViewModel
    {
        public CommentViewModel Contact { get; set; }
        public IEnumerable<Comments> Comments { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public IEnumerable<BlogText> BlogTexts { get; set; }

    }
}

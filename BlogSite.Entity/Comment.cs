using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Entity
{
   public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? DateTime { get; set; }
        public string YazarId { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}

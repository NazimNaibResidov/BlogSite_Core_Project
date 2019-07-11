using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogSite.Entity
{
   public class Blog
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Titel { get; set; }
        public string Content { get; set; }
        public DateTime? Time { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public Comment Comment { get; set; }
        public int? CommentId { get; set; }
        public Image Image { get; set; }
        public int? ImageID { get; set; }

    }
}

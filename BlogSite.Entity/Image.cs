using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Entity
{
  public  class Image
    {
        public int Id { get; set; }
        public string SPath { get; set; }
        public string MPath { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}

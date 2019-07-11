using BlogSite.Data.Abstrac;
using BlogSite.Entity;

namespace BlogSite.Data.Concrete.EfCore
{
    public class BlogResptory:BaseResptory<Blog>, IBlogResptory
    {
        public BlogResptory(BlogContext context):base(context)
        {

        }
    }
    
}

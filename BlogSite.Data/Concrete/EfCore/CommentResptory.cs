using BlogSite.Data.Abstrac;
using BlogSite.Entity;

namespace BlogSite.Data.Concrete.EfCore
{
    public class CommentResptory : BaseResptory<Comment>, ICommentResptory
    {
        public CommentResptory(BlogContext context):base(context)
        {

        }
    }
    
}

using DemoApplication.Database.Common;

namespace DemoApplication.Database.Models
{
    public class BlogTag: BaseEntity,IAuditable
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<BlogandBlogTag> BlogandBlogTags { get; set; }
    }
}

using DemoApplication.Database.Common;

namespace DemoApplication.Database.Models
{
    public class Tag:BaseEntity,IAuditable
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<ProductTag> MyProperty { get; set; }
    }
}

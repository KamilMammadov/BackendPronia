namespace DemoApplication.Areas.Client.ViewModels
{
    public class ModalViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public List<ColorViewModeL> Colors { get; set; }
        public List<SizeViewModeL> Sizes { get; set; }
        public ModalViewModel(string title, string description, decimal price, string ımgUrl, List<ColorViewModeL> colors, List<SizeViewModeL> sizes)
        {
            Title = title;
            Description = description;
            Price = price;
            ImgUrl = ımgUrl;
            Colors = colors;
            Sizes = sizes;
        }


        public class SizeViewModeL
        {
            public SizeViewModeL(string title, int id)
            {
                Title = title;
                Id = id;
            }

            public int Id { get; set; }
            public string Title { get; set; }
        }
        public class ColorViewModeL
        {
            public ColorViewModeL(string name, int id)
            {
                Name = name;
                Id = id;
            }
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}

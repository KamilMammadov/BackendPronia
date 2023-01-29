using DemoApplication.Areas.Client.ViewModels;
using DemoApplication.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace DemoApplication.Areas.Client.ViewComponents
{
    [ViewComponent(Name = "ShopPageTag")]

    public class ShopPageTag: ViewComponent
    {
        private readonly DataContext _dataContext;

        public ShopPageTag(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _dataContext.Tags.Select(c => new TagListItemViewModel(c.Id, c.Name)).ToListAsync();

            return View(model);
        }
    }
}

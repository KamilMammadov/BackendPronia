using DemoApplication.Areas.Client.ViewModels;
using DemoApplication.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace DemoApplication.Areas.Client.ViewComponents
{
    [ViewComponent(Name = "ShopPageColor")]

    public class ShopPageColor: ViewComponent
    {
        private readonly DataContext _dataContext;

        public ShopPageColor(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _dataContext.Colors.Select(c => new ColorListItemViewModel(c.Id, c.Name)).ToListAsync();

            return View(model);
        }
    }
}

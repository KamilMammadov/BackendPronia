using DemoApplication.Database;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Areas.Client.ViewComponents
{
    [Area("client")]
    [ViewComponent(Name = "Benefit")]
    public class Benefit:ViewComponent
    {
        private readonly DataContext _dataContext;

        public Benefit(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model =
                _dataContext.PaymentBenefits.ToList();

            return View(model);
        }
    }
}

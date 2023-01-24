using DemoApplication.Areas.Client.ViewModels;
using DemoApplication.Contracts.File;
using DemoApplication.Database;
using DemoApplication.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Areas.Client.ViewComponents
{
    [Area("client")]
    [ViewComponent(Name = "Benefit")]
    public class Benefit:ViewComponent
    {
        private readonly DataContext _dataContext;
        private readonly IFileService _fileService;


        public Benefit(DataContext dataContext,IFileService fileService)
        {
            _dataContext = dataContext;
            _fileService = fileService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model =
                _dataContext.PaymentBenefits.Select(b=>new BenefitListItemViewModel(b.Title,b.Content, _fileService
                 .GetFileUrl(b.ImageInFileSystem, UploadDirectory.PaymentBenefits))).ToList();

            return View(model);
        }
    }
}

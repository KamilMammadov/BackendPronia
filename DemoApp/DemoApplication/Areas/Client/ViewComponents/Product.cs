using DemoApplication.Areas.Client.ViewModels;
using DemoApplication.Contracts.File;
using DemoApplication.Database;
using DemoApplication.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace DemoApplication.Areas.Client.ViewComponents
{

    [ViewComponent(Name = "Product")]
    public class Product : ViewComponent
    {
        private readonly DataContext _dataContext;
        private readonly IFileService _fileService;
        public Product(DataContext dataContext, IFileService fileService)
        {
            _dataContext = dataContext;
            _fileService = fileService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var model = await _dataContext.Products.Select(p => new ProductListViewModel(
                p.Id,
                p.Name,
                p.Price,
                p.ProductImages.Take(1).FirstOrDefault() != null
                    ? _fileService.GetFileUrl(p.ProductImages.Take(1).FirstOrDefault()!.ImageNameInFileSystem, UploadDirectory.Products)
                    : String.Empty
                )).ToListAsync();

            return View(model);
        }
    }
}

//using DemoApplication.Areas.Client.ViewModels;
//using DemoApplication.Contracts.File;
//using DemoApplication.Database;
//using DemoApplication.Services.Abstracts;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Xml.Linq;
//using static DemoApplication.Areas.Client.ViewModels.ProductViewModel;

//namespace DemoApplication.Areas.Client.ViewComponents
//{

//    [ViewComponent(Name = "ShopProduct")]
//    public class ShopProduct : ViewComponent
//    {
//        private readonly DataContext _dataContext;
//        private readonly IFileService _fileService;
//        public ShopProduct(DataContext dataContext, IFileService fileService)
//        {
//            _dataContext = dataContext;
//            _fileService = fileService;
//        }

//        public async Task<IViewComponentResult> InvokeAsync()
//        {

//            var model = await _dataContext.Products.Select(p => new ProductViewModel(
//                p.Id,
//                p.Name,
//                p.Price,
//                p.ProductImages.Take(1).FirstOrDefault() != null
//                    ? _fileService.GetFileUrl(p.ProductImages.Take(1).FirstOrDefault()!.ImageNameInFileSystem, UploadDirectory.Products)
//                    : String.Empty,
//                 p.ProductCatagories!.Select(pc => pc.Catagory).Select(c => new CategoryViewModeL(c.Title, c.Parent.Title)).ToList(),
//                      p.ProductColors!.Select(pc => pc.Color).Select(c => new ColorViewModeL(c.Name)).ToList(),
//                      p.ProductSizes!.Select(ps => ps.Size).Select(s => new SizeViewModeL(s.Title)).ToList(),
//                      p.ProductTags!.Select(ps => ps.Tag).Select(s => new TagViewModel(s.Title)).ToList())

//                )).ToListAsync();

//            return View(model);
//        }
//    }
//}

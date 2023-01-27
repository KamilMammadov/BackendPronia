using DemoApplication.Database.Models;
using DemoApplication.Areas.Client.ViewModels;

namespace DemoApplication.Services.Abstracts
{
    public interface IBasketService
    {
        Task<List<ProductCookieViewModel>> AddBasketProductAsync(Product product);

    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using BOL;
using SAL;
namespace TFLStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
   
    [HttpGet]
    public IActionResult Index()
    {
        ProductHubService svc=new ProductHubService();
        List<Product>allProducts=svc.GetAllProducts();
        this.ViewData["products"]=allProducts;
        return View();
    } 

   [HttpGet]
    public IActionResult Details(int id)
    {
        return View();
    }


}

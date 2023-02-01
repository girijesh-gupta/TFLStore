using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;

namespace EStore.Controllers;

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
        return View();
    }
    
      //http://localhost:7654/products/details/45
    [HttpGet]
    public IActionResult Details(int id)
    {
        return View();
    }
   
}

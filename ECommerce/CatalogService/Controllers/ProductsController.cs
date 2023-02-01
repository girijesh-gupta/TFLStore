using Microsoft.AspNetCore.Mvc;
using BOL;
namespace CatalogService.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
  

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

   public IActionResult GetProducts(){
    var products=new List<Product>();
    products.Add(new Product{Id=1 , Title="Gerbera", Description="Wedding flower", UnitPrice=5, Quantity=4000});
        products.Add(new Product{Id=2 , Title="rose", Description="valentine flower", UnitPrice=55, Quantity=40000});
        return Ok(products);
   }
   //secon part
   [Route("{id}")]
   [HttpGet]
   public IActionResult GetProductById(int id)
   {
      Console.WriteLine("Id= "+ id);
        Product theProduct=new Product{ Id=1, Title="Jasmine",  Description="Fregrance flower", UnitPrice=1, Quantity=4000 };
        return Ok(theProduct);
    }
  //third part
    [Route("{id}")]
    [HttpDelete]
    public IActionResult DeleteProductById(int id){
        Console.WriteLine(" Product to be DeleteId= "+ id);
        return Ok("Product is removed from catalog");
    }
    //delete post put checked by postman tool
    //fourth part 
    //by postman // http://localhost:5096/products/  //body raw json
    [HttpPost]
    public IActionResult Insert(Product p)
    {
      Console.WriteLine("Title="+p.Title+",Description="+p.Description);
       return Ok("Product is inserted");
    }
   
    // 5th part

    [Route ("{id")]
    [HttpPut]
    public IActionResult update(int id,Product p)
    {
        Console.WriteLine("Titie="+p.Title+",Description="+p.Description);
        return Ok("Existing Product is updated..")
    }


}

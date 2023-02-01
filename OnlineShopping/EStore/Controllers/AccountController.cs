using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;

namespace EStore.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

     [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email,string password)
    {
       if(email=="giri@.in" && password=="123")
    {
      Response.Redirect("/orders/index");
    }
       return View();
    }
   
      [HttpPost]
    public IActionResult register()
    {
        return View();
    }
   
       //Action Method
    [HttpPost]
    public IActionResult Register(string firstname, string lastname, string  location,string email, string password)
    {
        Console.WriteLine(firstname + " " + lastname + " "+ location);
        return this.RedirectToAction("Login","Account");
    }
}

﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;

namespace TFLStore.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }
      
         //Action Method
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

     [HttpPost]
    public IActionResult Login(string email, string password)
    {
        if(email =="giri@" && password=="123"){
            Response.Redirect("/orders/index");
        }
        //
        return View();
    }
      
      [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    
  [HttpPost]
    public IActionResult Register(string firstname, string lastname, string  location,string email, string password)
    {
        Console.WriteLine(firstname + " " + lastname + " "+ location);
        return this.RedirectToAction("Login","Account");
    }
}

using System;
//using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewPartyInvites.Models;

namespace NewPartyInvites.Controllers;

public class HomeController : Controller
{

    public ViewResult Index()
    {
        var hour = DateTime.Now.Hour;
        ViewBag.Greeting = hour < 12 ? "Good Morning:" : "Good Evening";
        return View("MyView");
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }
}

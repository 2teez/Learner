using System;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        var hour = DateTime.Now.Hour;
        ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Evening";
        return View("MyView");
    }
}

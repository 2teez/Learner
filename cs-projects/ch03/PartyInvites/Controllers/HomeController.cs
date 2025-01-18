using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public ViewResult Index() => View("MyView");
}

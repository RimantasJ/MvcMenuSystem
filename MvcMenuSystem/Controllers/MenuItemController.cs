using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMenuSystem.Controllers;

public class MenuItemController : Controller
{
    // 
    // GET: /MenuItem/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /MenuItem/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}
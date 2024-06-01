using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CapetropolisTourism.Models;

namespace CapetropolisTourism.Controllers;

public class HotelsController : Controller
{
    private readonly ILogger<HotelsController> _logger;

    public HotelsController(ILogger<HotelsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

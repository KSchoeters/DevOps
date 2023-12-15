using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vacation.Models;
using Contentful.Core;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Contentful.Core.Models;

namespace Vacation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IContentfulClient _client;

    public HomeController(ILogger<HomeController> logger, IContentfulClient client)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var locations = await _client.GetEntries<Destination>();
        return View(locations);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

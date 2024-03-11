using dctweb.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace dctweb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static HttpClient client = new HttpClient();


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        using HttpResponseMessage response = await client.GetAsync("http://localhost:5003/api/Contents");
        string result = await response.Content.ReadAsStringAsync(); 
        Content[]? results = JsonConvert.DeserializeObject<Content[]>(result);
        ViewData["results"] = results;
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

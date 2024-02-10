using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using dctweb.Models;

namespace dctweb.Controllers;

public class ContentController : Controller
{
    private readonly ILogger<HomeController> _logger;
    static HttpClient client = new HttpClient();

    public ContentController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public string check(){
        return "abc";
    }

    public async Task<string> GetContent(){
        HttpResponseMessage response = await client.GetAsync("http://localhost:5090/api/Contents");
        string? content = await response.Content.ReadAsStringAsync();
        return content;
    }

}

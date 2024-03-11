using dctweb.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace dctweb.Controllers;

public class AddController : Controller
{
    private readonly ILogger<AddController> _logger;


    public AddController(ILogger<AddController> logger)
    {
        _logger = logger;
    }
    public bool index(){
        return true;
    }
    [HttpPost]
    public string test(Files model){
        string x;
        x = "asd";
        if(model.File!=null){
            x = model.File.FileName;
            Console.WriteLine("asdsdsd");
            return x;
        }
        return x;
    }
    
}
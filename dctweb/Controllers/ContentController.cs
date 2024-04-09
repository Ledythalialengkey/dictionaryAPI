using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using dctweb.Models;
using System.Text;
using Newtonsoft.Json;
using dctstorefile;

namespace dctweb.Controllers;

public class ContentController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly HttpClient _httpClient;
    static HttpClient client = new HttpClient();

    public ContentController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5003");
    }

    public string check(){
        return "abc";
    }

    public async Task<string> GetContent(){ 
    
        using HttpResponseMessage response = await client.GetAsync("http://localhost:5003/api/Contents");
        string? content = await response.Content.ReadAsStringAsync();
        return content;
    }
    public async Task<ActionResult> PostContent(string cFrom, string cTo, string cDesc, IFormFile cAudio){
         
         DctStoreFile dct = new DctStoreFile();
         dct.SetDirPath("./AudioFile");
         dct.CreateDirectory();
         string uiidName = await dct.GenerateFileName(cAudio.FileName);
         var filePath = Path.Combine(dct.GetDirPath(),uiidName);
         
         try{
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await cAudio.CopyToAsync(stream);
            }
         }
         catch{
            throw;
         }


         var postMsg = new Content{
            contentFrom = cFrom,
            contentTo = cTo,
            contentDesc = cDesc,
            contentAudio = uiidName,
            createdAt = DateTime.Now
        };
        string? json = JsonConvert.SerializeObject(postMsg);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("/api/Contents", content);

         if (response.IsSuccessStatusCode)
            {
                // Read and display the response content
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response: " + responseContent);
            }
            else
            {
                Console.WriteLine("Failed to make POST request. Status Code: " + response.StatusCode);
            }

        return RedirectToAction("Index","Home");
    }

    public async Task<ActionResult> DeleteContent(int id){
        Console.WriteLine("The result : " + id);
        var response = await _httpClient.DeleteAsync($"/api/Contents/delete/{id}");
        if (response.IsSuccessStatusCode)
            {
                // Read and display the response content
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response: " + responseContent);
            }
            else
            {
                Console.WriteLine("Failed to make POST request. Status Code: " + response.StatusCode);
            }
        return RedirectToAction("Index", "Home");
    }

}

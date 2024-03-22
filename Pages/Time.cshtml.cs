using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_8_KimS_WT.Pages;

public class TimeModel : PageModel
{
    private readonly ILogger<TimeModel> _logger;

    public TimeModel(ILogger<TimeModel> logger)
    {
        _logger = logger;
    }

    public string Message {get; set;}
    
    public List<int> LuckyNumbers {get; set;} // Add the LuckyNumbers property
    public void OnGet()
    {
        Message = "Dana is a great Professor! He should do educational podcasts as he makes content easy to digest!!!";
        LuckyNumbers = new List<int> { 3, 4, 7, 13 };  // Initialize the LuckyNumbers list
    }
}
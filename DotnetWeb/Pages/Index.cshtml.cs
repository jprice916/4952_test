using dotnet_lib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetWeb.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? Year { get; set; }

    [BindProperty]
    public Student? Stu { get; set; }
    public void OnGet()
    {
        ViewData["bcit"] = "Burnaby campus";
        Year = "2026";
        Student Stu = new()
        {
            Fname = "john",
            Lname = "adams",
            ID = 12,
            school = "wherever"
        };
    }
}

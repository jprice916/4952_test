using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcsOtherModel : PageModel
{
    public Process[]? procs { get; set; }
    public void OnGet()
    {
        procs = Process.GetProcesses();
    }
}


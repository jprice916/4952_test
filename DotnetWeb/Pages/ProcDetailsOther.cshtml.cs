using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DotnetWeb.Pages;

public class ProcDetailsOtherModel : PageModel
{
    public Process? Proc { get; set; }
    public void OnGet(int ID)
    {
        Proc = Process.GetProcessById(ID);
    }
}


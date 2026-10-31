using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_glebko.Data;
using wt_lab5_5razor_glebko.Models;

namespace wt_lab5_5razor_glebko.Pages.Flights;

public class CreateModel : PageModel
{
    [BindProperty]
    public Flight Flight { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Генерация ID, если его нет
        Flight.nomer_reisa = FlightStore.Flights.Any()
            ? FlightStore.Flights.Max(x => x.nomer_reisa) + 1
            : 1;

        FlightStore.Flights.Add(Flight);
        return RedirectToPage("./Index");
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_glebko.Data;
using wt_lab5_5razor_glebko.Models;

namespace wt_lab5_5razor_glebko.Pages.Flights;

public class DetailsModel : PageModel
{
    public Flight? Flight { get; set; }

    public IActionResult OnGet(int id)
    {
        Flight = FlightStore.Flights.FirstOrDefault(f => f.nomer_reisa == id);
        if (Flight == null)
        {
            return NotFound();
        }
        return Page();
    }
}
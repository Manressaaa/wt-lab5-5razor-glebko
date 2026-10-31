using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_glebko.Data;
using wt_lab5_5razor_glebko.Models;

namespace wt_lab5_5razor_glebko.Pages.Flights;

public class EditModel : PageModel
{
    [BindProperty]
    public Flight Flight { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var existing = FlightStore.Flights.FirstOrDefault(f => f.nomer_reisa == id);
        if (existing == null)
        {
            return NotFound();
        }

        Flight = existing;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var existing = FlightStore.Flights.FirstOrDefault(f => f.nomer_reisa == Flight.nomer_reisa);
        if (existing == null)
        {
            return NotFound();
        }

        existing.gorod_vilet = Flight.gorod_vilet;
        existing.gorod_prilet = Flight.gorod_prilet;
        existing.vremya_vileta = Flight.vremya_vileta;
        existing.cena = Flight.cena;
        existing.mesta = Flight.mesta;
        existing.dostupno = Flight.dostupno;

        return RedirectToPage("./Index");
    }
}
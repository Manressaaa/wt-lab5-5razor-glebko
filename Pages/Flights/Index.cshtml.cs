using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_glebko.Data;
using wt_lab5_5razor_glebko.Models;

namespace wt_lab5_5razor_glebko.Pages.Flights;

public class IndexModel : PageModel
{
    public List<Flight> Flights { get; set; } = new();

    public void OnGet()
    {
        Flights = FlightStore.Flights;
    }
}
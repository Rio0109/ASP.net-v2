using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using mvc01.Models;

namespace mvc01.Controllers
{
    public class OsobaController : Controller
    {
        public IActionResult Index()
        {

            var osobe = new List<Osoba>
            {
                new Osoba {Id = 1, Ime="Ante", Prezime="Ristovski",Godine = 30},
                new Osoba {Id = 2, Ime="Dolores",Prezime="Zaboravio sam",Godine=28}
            };
            return View(osobe);
        }
    }
}
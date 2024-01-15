using Microsoft.AspNetCore.Mvc;
using Players.Models;

namespace Players.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player(){PId=1, PName="Virat Kohli", PCountry="India", PType= "Batsman"},
            new Player(){PId=2, PName="MS Dhoni", PCountry="India", PType= "WicketKeeper"},
            new Player(){PId=3, PName="Shane Warne", PCountry="Australia", PType= "Bowler"},
            new Player(){PId=4, PName="JP Duminy", PCountry="South Africa", PType= "All-Rounder"},
            new Player(){PId=5, PName="Shahid Afridi", PCountry="Pakistan", PType= "All-Rounder"},
        };

        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player p)
        {
            if (ModelState.IsValid)
            {
                players.Add(p);
            }
            return RedirectToAction("Index");
        }
    }
}

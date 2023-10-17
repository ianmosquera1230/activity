using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml;
namespace WebApplication2.Pages
{
    public class IndonesiaModel : PageModel
    {
        private readonly ILogger<IndonesiaModel> _logger;

        public IndonesiaModel(ILogger<IndonesiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["seminyak"] = "Along this impressive 5km stretch of golden sand, you’ll find beach bars aplenty,\r\n        five-star hotels and Seminyak’s very best restaurants just footsteps from the waves – not to mention world-famous beach clubs in every direction.";
            ViewData["borobudur"] = "This ancient temple is one of the most famous and culturally significant landmarks in Indonesia.\r\n        Borobudur was built in the 8th century and constructed in the shape of a traditional Buddhist mandala.\r\n        It is one of the top UNESCO World Heritage sites, and is considered one of the greatest Buddhist sites in the world.";
            ViewData["gili"] = "The Gili Islands are a major draw in Lombok, which has risen in popularity among backpackers and tourists over the years.\r\n        These picturesque islands offer beaches that rival those of Bali in their beauty, as well as opportunities for diving and even snorkeling at a turtle sanctuary.";
            ViewData["bromo"] = "Mount Bromo is among the best known, thanks largely to its incredible views, particularly when seen standing over the caldera at sunrise.\r\n        Bromo's peak was blown off in an eruption, and you can still see white smoke spewing from the mountain.";
            ViewData["tana"] = "A visit to Tana Toraja in South Sulawesi Province will not only feel like you've stepped far back in time,\r\n        but also offers a look at the richness and diversity of Indonesia's long-standing cultures.\r\n        The architectural style of Tongkonan, boat-shaped houses and other buildings, are immediate standouts,\r\n        but the people are what make this piece of natural paradise so special. They are, by many accounts,\r\n        the friendliest and most welcoming people you could hope to meet while traveling.";
        }
    }
}
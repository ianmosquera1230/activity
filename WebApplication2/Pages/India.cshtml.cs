using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml;
namespace WebApplication2.Pages
{
    public class IndiaModel : PageModel
    {
        private readonly ILogger<IndiaModel> _logger;

        public IndiaModel(ILogger<IndiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["tajmahal"] = "Majestically located on the banks of Yamuna River, this wonder of the world was built by the Mughal Emperor Shah Jahan as a memorial for his beloved wife Mumtaz Mahal.";
            ViewData["redfort"] = "Located in Chandni Chowk Old Delhi, this red sandstone structure was constructed under the reign of Mughal emperor Shah Jahan for protection against invaders.\r\n        It is known for its intricate Mughal architecture and floral designs..";
            ViewData["goldentemple"] = "Kawasan Falls is one of the most picturesque tourist attractions in Cebu. This natural wonder has an emerald-tinged cool, natural pool that is perfect for a relaxing dip.\r\n                Many travelers make the trip to witness its breathtaking beauty by joining a trip to Kawasan Falls.";
            ViewData["amerfort"] = "Perched atop a hill and overlooking the Maota Lake, the red sandstone fort is now a UNESCO World Heritage Site and \r\n                showcases a beautiful fusion of Mughal and Rajput architecture."; 
            ViewData["humayun"] = " The royal mausoleum of Mughal Emperor Humayun, this structure was sanctioned by his widow Hamida Baga Begum and designed by Persian architect Mirak Mirza Ghiyas.\r\n        It was completed between 1565 and 1572.";
        }
    }
}
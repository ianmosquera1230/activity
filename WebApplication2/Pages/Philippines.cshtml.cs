using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml;

namespace WebApplication2.Pages
{
    public class PhilippinesModel : PageModel
    {
        private readonly ILogger<PhilippinesModel> _logger;

        public PhilippinesModel(ILogger<PhilippinesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["banaue"] = "Banaue Rice Terraces in the mountains of Banaue, Ifugao is considered a National Cultural Treasure site. The creation of the terraces dates back to two millennia ago in the pre-colonial period and is one of the most unique tourist spots in Banaue and the Philippines";
            ViewData["kawasan"] = "Kawasan Falls is one of the most picturesque tourist attractions in Cebu. This natural wonder has an emerald-tinged cool, natural pool that is perfect for a relaxing dip.\r\n        Many travelers make the trip to witness its breathtaking beauty by joining a trip to Kawasan Falls.";
            ViewData["chocolatehills"] = "The Chocolate Hills in the province of Bohol are a stunning collection of geological formations that look like gigantic Kisses chocolates.\r\n        These karst hills that change colors, green during the wet season and brown during the dry season, are actually made of limestone with marine corals and algae.";
            ViewData["boracay"] = "Boracay, one of the top Islands in the Philippines, is popular for its beaches and blessed with a long stretch of powdery white sand, crystal clear and azure waters, and a stunning sunset. Boracay is the most iconic island in the Philipines and has won multiple awards in previous years.";
            ViewData["mayon"] = "This active volcano in Legazpi, Albay of Bicol region has one of the world’s most perfect cones because of its symmetric shape.\r\n        Even from afar, you can already catch a glimpse of its breathtaking beauty, making it one of the top tourist spots you can’t miss in Legazpi.";
        }
    }
}
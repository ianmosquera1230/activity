using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml;
namespace WebApplication2.Pages
{
    public class MalaysiaModel : PageModel
    {
        private readonly ILogger<MalaysiaModel> _logger;

        public MalaysiaModel(ILogger<MalaysiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["sipadan"] = "The petite island near Semporna in Sabah is among the world’s top diving sites and surely one of the best Malaysia tourist attractions. \r\n        After attaining the status of a protected reserve in 2002, only a handful of tourists at a time are given permission to visit this limestone \r\n        pinnacle which is one of the best islands near Kuala Lumpur.";
            ViewData["pangkor"] = "If you’re seeking peace and solitude with the perfect mix of beauty and serenity, you should be heading to Pangkor Island,\r\n        one of the most tranquil Malaysia tourist attractions. Lying near Perak’s coast, this is one of the best Malaysia tourist attractions that features empty beaches,\r\n        crystal clear and clean water, and dense jungles covering the center of the island. You’ll definitely love the chance to sunbathe under swaying palms here without another soul\r\n        in sight.";
            ViewData["kinabatangan"] = "Located to the east of Sabah, Kinabatangan is known for its rainforest remains. Its wildlife sanctuary attracts a large number of wildlife lovers \r\n        at this tourist attraction is Malaysia. Among the most romantic places to visit in Malaysia, this one tops the list.";
            ViewData["perhentian"] = "A group of stunning, coral fringed islands – the Perhentian Island is located almost 19 km away from the North-eastern Malaysia.\r\n        It is a part of marine park where activities like fishing are strictly prohibited. It is one of the most unique places to visit in the country.\r\n        It is also counted among the best places to visit in Malaysia with friends.";
            ViewData["langkawi"] = " A beautiful archipelago, Langkawi Island is a destination known for its vast expanse of sandy beaches and azure blue water which enthrall the tourists.\r\n        The Langkawi Geopark is a UNESCO heritage site that attracts a large number of visitors and is, undoubtedly, the top among the must visit places in Malaysia.\r\n        It is a perfect manifestation of the geological heritage in the area. It is one of the best places to visit in Malaysia with family.";
        }
    }
}
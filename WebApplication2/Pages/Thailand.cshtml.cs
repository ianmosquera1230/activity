using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml;
namespace WebApplication2.Pages
{
    public class ThailandModel : PageModel
    {
        private readonly ILogger<ThailandModel> _logger;

        public ThailandModel(ILogger<ThailandModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["railay"] = "Krabi province is home to some of Thailand's most famous beach destinations and Railay tops the list as one of the most stunning.\r\n                Definitely one of the best beaches in Krabi, Railay delivers on promises of white sand, turquoise-blue water, and the feeling that you've found a\r\n                slice of paradise even before your feet touch the sand.";
            ViewData["kohphiphi"] = "The main island is Phi Phi Don. This is the largest of the islands and the only one permanently inhabited,\r\n                and this is what people usually mean when they refer to Koh Phi Phi. Koh Phi Phi Leh is the other of the Phi Phi Islands\r\n                Perhaps one of the most fun spots on Koh Phi Phi is Monkey Beach, where you'll come face to face,\r\n                literally, with plenty of macaques ready to steal your lunch";
            ViewData["grandpalace"] = "The grounds are a maze of royal halls, temples, and ancient relics, the most important being Wat Phra Kaeo (the Temple of the Emerald Buddha),\r\n        said to hold a fragment of either hair or bone from the enlightened Buddha himself.\r\n        Allow several hours to do the Grand Palace justice, but if you're up for more walking afterward,\r\n        you can easily take in some of the city's other major landmarks nearby. The famous Wat Po and Wat Arun, the Temple of the Dawn (a great place to watch the sunset),\r\n        are just a few minutes away.";
            ViewData["chiangmai"] = "Chiang Mai is a flourishing tourist and resort centre. Phu Ping Palace, the summer home of the Thai royal family, is nearby.\r\n        The city is renowned as a centre of Thai handicrafts.";
            ViewData["khaoyai"] = "Khao Yai National Park is a paradise for nature lovers. You can enjoy hiking, watching the magnificent view and the waterfalls, and witnessing the wildlife in it,\r\n        like the gibbons, deers, and even elephants and bears";
        }
    }
}
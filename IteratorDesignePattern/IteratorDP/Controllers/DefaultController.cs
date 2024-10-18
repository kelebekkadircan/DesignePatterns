using IteratorDP.IteratorPattern;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IteratorDP.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            visitRouteMover.AddVisitorRoute (new VisitorRoute { Country = "Turkey", City = "Antalya", Place = "Alanya Kalesi" });
            visitRouteMover.AddVisitorRoute (new VisitorRoute { Country = "Turkey", City = "Muğla", Place = "Fethiye" });
            visitRouteMover.AddVisitorRoute (new VisitorRoute { Country = "Turkey", City = "İzmir", Place = "Saat Kulesi" });
            visitRouteMover.AddVisitorRoute (new VisitorRoute { Country = "Turkey", City = "İstanbul", Place = "Ayasofya" });
            visitRouteMover.AddVisitorRoute (new VisitorRoute { Country = "Turkey", City = "Ankara", Place = "Anıtkabir" });
            
            var iterator = visitRouteMover.CreateIterator();

            while (iterator.HasNext())
            {
                strings.Add(iterator.CurrentItem.Country + " " + iterator.CurrentItem.City + " " + iterator.CurrentItem.Place);
            }

            ViewBag.v = strings;

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TemplateMethodDesignePattern.TemplatePattern;

namespace TemplateMethodDesignePattern.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            NetflixPlans basicPlan = new BasicPlan();
            ViewBag.v1 = basicPlan.PlanType("Temel");
            ViewBag.v2 = basicPlan.CountPerson(1);
            ViewBag.v3 = basicPlan.Price(29.99);
            ViewBag.v4 = basicPlan.Resolution("HD");
            ViewBag.v5 = basicPlan.Content("Film");
            
            NetflixPlans standardPlan = new StandardPlan();
            ViewBag.v6 = standardPlan.PlanType("Standart");
            ViewBag.v7 = standardPlan.CountPerson(2);
            ViewBag.v8 = standardPlan.Price(39.99);
            ViewBag.v9 = standardPlan.Resolution("HD + Full HD");
            ViewBag.v10 = standardPlan.Content("Film + Dizi");


            return View();
        }



    }
}

using DesignePatternChainOfResponsibility.ChainOfResponsibility;
using DesignePatternChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignePatternChainOfResponsibility.Controllers
{
    public class Default : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel req)
        {
            Employee treasurer = new Treasurer();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();
            Employee managerAssistant = new ManagerAssistant();

            treasurer.setNextApprover(managerAssistant);
            managerAssistant.setNextApprover(manager);
            manager.setNextApprover(areaDirector);

            treasurer.ProcessRequest(req);
            

            return View();
        }

    }
}

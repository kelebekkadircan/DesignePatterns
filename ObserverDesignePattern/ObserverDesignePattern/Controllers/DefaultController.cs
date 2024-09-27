using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ObserverDesignePattern.DAL;
using ObserverDesignePattern.Models;
using ObserverDesignePattern.ObserverPattern;
using System.Threading.Tasks;

namespace ObserverDesignePattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            if (registerViewModel == null)
            {
                // Model null olduğu durumda bir hata mesajı verip kullanıcıyı bilgilendirin.
                ModelState.AddModelError("", "Kullanıcı bilgileri eksik.");
                return View();
            }
            var appUser = new AppUser
            {
            
                Name = registerViewModel.Name ,
                Surname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Username
            };
            var  result = await _userManager.CreateAsync(appUser, registerViewModel.Password);

            if (result.Succeeded)
            {
                _observerObject.NotifyObservers(appUser);

                return View();
            }
            

            return RedirectToAction("Index");
        }
    }
}

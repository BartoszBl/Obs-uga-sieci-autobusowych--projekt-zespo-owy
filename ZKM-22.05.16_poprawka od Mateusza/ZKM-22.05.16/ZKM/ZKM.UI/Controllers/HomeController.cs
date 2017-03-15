using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ZKM.Core.Enums;
using ZKM.UI.DAL;

namespace ZKM.UI.Controllers
{
    public class HomeController : Controller
    {    
        private ZkmDbContext db = new ZkmDbContext();
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Strona kontaktowa.";


            return View();
        }

        public ActionResult AutobusyWykaz()
        {
            ViewBag.message = "Wykaz autobusów";
            var AutobusyAktywne = db.Autobusy.Where(a => !a.Czy_Aktywny).ToList();

            //ViewBag.AutobusyWykaz = AutobusyAktywne;

            return View(AutobusyAktywne);
        }

        [Authorize(Roles = UserRoles.Manager)]
        public ActionResult Zarzadzanie()
        {
            ViewBag.Message = "Zarządzanie autobusami";
            var AutobusyList = db.Autobusy.ToList();
            return View();
        }

        public ActionResult Przystanki()
        {
            ViewBag.message = "Wykaz przystanków";
            var PrzystankiList = db.Przystanki.ToList();

            return View();
        }
        [Authorize(Roles = "Users")]
        public ActionResult Kontrole()
        {
            ViewBag.message = "Wykaz kontroli";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Incydenty()
        {
            ViewBag.Message = "Wykaz incydentów";
            return View();
        }

        [Authorize]
        public ActionResult GiveMeManager()
        {
            if (!User.IsInRole(UserRoles.Manager))
            {
                var userId = ClaimsPrincipal.Current.Identity.GetUserId();

                ApplicationUserManager.Current().AddToRole(userId, UserRoles.Manager);                
            }
            
            return View();
        }
    }
}
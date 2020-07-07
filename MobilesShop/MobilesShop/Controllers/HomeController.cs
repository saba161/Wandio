using System;
using Microsoft.AspNetCore.Mvc;
using MobilesShop.Services;

namespace MobilesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGeneralMethods general;

        public HomeController(IGeneralMethods general)
        {
            this.general = general;
        }

        public IActionResult Index()
        {
            var result = general.GetPhones();

            return View(result);
        }

        public IActionResult Details(int id)
        {
            try
            {
                var phone = general.GetPhoneById(id);

                if (phone == null)
                {
                    return NotFound();
                }

                return View(phone);
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("General ex");
            }
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;
using MobilesShop.Services;

namespace MobilesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhoneQuery _phoneQuery;

        public HomeController(IPhoneQuery phoneQuery)
        {
            _phoneQuery = phoneQuery;
        }

        public IActionResult Index()
        {
            try
            {
                var result = _phoneQuery.GetAllPhones();

                return View(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"General {ex}");
            }
        }

        public IActionResult PhoneDetails(int id)
        {
            try
            {
                var phone = _phoneQuery.GetPhoneById(id);

                if (phone == null)
                {
                    return NotFound();
                }

                return View(phone);
            }
            catch (Exception ex)
            {
                throw new Exception($"General {ex}");
            }
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;
using MobilesShop.Services;

namespace MobilesShop.Controllers
{
    public class FilterController : Controller
    {
        private readonly IFilter filter;

        public FilterController(IFilter filter)
        {
            this.filter = filter;
        }

        public IActionResult ByName(string phoneName)
        {
            try
            {
                var phones = filter.GetPhoneByName(phoneName);

                return View(phones);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"General {ex}");
            }
        }

        public IActionResult ByPrice(int from, int to)
        {
            try
            {
                var phones = filter.GetPhoneByPrice(from, to);

                return View(phones);

            }
            catch (Exception ex)
            {
                throw new ArgumentException($"General {ex}");
            }
        }

        public IActionResult ByManufacturer(string manufacturer)
        {
            try
            {
                var phones = filter.GetPhoneByManufacturer(manufacturer);

                return View(phones);

            }
            catch (Exception ex)
            {
                throw new ArgumentException($"General {ex}");
            }
        }
    }
}

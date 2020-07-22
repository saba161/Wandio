using System;
using Microsoft.AspNetCore.Mvc;
using MobilesShop.Data;
using MobilesShop.Services;

namespace MobilesShop.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhoneQuery _phoneQuery;

        public PhoneController(IPhoneQuery phoneQuery)
        {
            _phoneQuery = phoneQuery;
        }

        public IActionResult FilterPhoneByName(string phoneName)
        {
            try
            {
                var phones = _phoneQuery.GetPhoneByName(phoneName);

                return View(phones);
            }
            catch (Exception ex)
            {
                throw new Exception($"General {ex}");
            }
        }

        public IActionResult FilterPhoneByPrice(int from, int to)
        {
            try
            {
                var phones = _phoneQuery.GetPhoneByPrice(from, to);

                return View(phones);

            }
            catch (Exception ex)
            {
                throw new Exception($"General {ex}");
            }
        }

        public IActionResult FilterPhoneByManufacturer(string manufacturer)
        {
            try
            {
                var phones = _phoneQuery.GetPhoneByManufacturer(manufacturer);

                return View(phones);

            }
            catch (Exception ex)
            {
                throw new Exception($"General {ex}");
            }
        }
    }
}

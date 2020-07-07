using MobilesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilesShop.Services
{
    public interface IFilter
    {
        IEnumerable<PhoneFeatures> GetPhoneByName(string name);

        IEnumerable<PhoneFeatures> GetPhoneByPrice(int from, int to);

        IEnumerable<PhoneFeatures> GetPhoneByManufacturer(string manufacturer);
    }
}

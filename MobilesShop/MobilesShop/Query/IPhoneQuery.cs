using MobilesShop.Models;
using System.Collections.Generic;

namespace MobilesShop.Services
{
    public interface IPhoneQuery
    {
        PhoneFeatures GetPhoneById(int id);

        IEnumerable<PhoneFeatures> GetAllPhones();

        IEnumerable<PhoneFeatures> GetPhoneByName(string name);

        IEnumerable<PhoneFeatures> GetPhoneByPrice(int from, int to);

        IEnumerable<PhoneFeatures> GetPhoneByManufacturer(string manufacturer);
    }
}

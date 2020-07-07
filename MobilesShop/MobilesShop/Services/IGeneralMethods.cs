using MobilesShop.Models;
using System.Collections.Generic;

namespace MobilesShop.Services
{
    public interface IGeneralMethods
    {
        PhoneFeatures GetPhoneById(int id);

        IEnumerable<PhoneFeatures> GetPhones();
    }
}

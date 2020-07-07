using MobilesShop.Data;
using MobilesShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobilesShop.Services
{
    public class GeneralMethods : IGeneralMethods
    {
        private readonly ApplicationDbContext _context;

        public GeneralMethods(ApplicationDbContext context)
        {
            _context = context;
        }

        public PhoneFeatures GetPhoneById(int id)
        {
            var phone = _context.Phone
                .Where(x => x.ID == id)
                .FirstOrDefault();

            return phone;
        }

        public IEnumerable<PhoneFeatures> GetPhones()
        {
            return _context.Phone;
        }
    }
}

using MobilesShop.Data;
using MobilesShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobilesShop.Services
{
    public class PhoneQuery : IPhoneQuery
    {
        private readonly ApplicationDbContext _context;

        public PhoneQuery(ApplicationDbContext context)
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

        public IEnumerable<PhoneFeatures> GetAllPhones()
        {
            return _context.Phone;
        }

        public IEnumerable<PhoneFeatures> GetPhoneByManufacturer(string manufacturer)
        {
            var phones = _context.Phone
                .Where(s => s.Manufacturer.Contains(manufacturer));

            return phones;
        }

        public IEnumerable<PhoneFeatures> GetPhoneByName(string name)
        {
            var phones = _context.Phone
                .Where(s => s.Name.Contains(name));

            return phones;
        }

        public IEnumerable<PhoneFeatures> GetPhoneByPrice(int from, int to)
        {
            if (from == 0 && to == 0)
            {
                var notFilteredPhones = _context.Phone;

                return notFilteredPhones;
            }

            if (to == 0)
            {
                var phones = _context.Phone
                    .Where(x => x.Price >= from);

                return phones;
            }

            if (from == 0)
            {
                var phones = _context.Phone
                    .Where(x => x.Price <= to);

                return phones;
            }

            var filteredPhones = _context.Phone
                .Where(x => x.Price >= from && x.Price <= to);

            return filteredPhones;
        }
    }
}

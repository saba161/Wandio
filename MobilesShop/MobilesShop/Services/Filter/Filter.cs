using MobilesShop.Data;
using MobilesShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobilesShop.Services
{
    public class Filter : IFilter
    {
        private readonly ApplicationDbContext _context;

        public Filter(ApplicationDbContext context)
        {
            _context = context;
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
            var phones = _context.Phone
                .Where(x => x.Price >= from && x.Price <= to);

            return phones;
        }
    }
}

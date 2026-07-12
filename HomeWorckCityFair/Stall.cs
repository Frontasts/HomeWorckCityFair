using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckCityFair
{
    public class Stall
    {
        private string _location;
        private List<Vendor> _vendors;

        public Stall(string location)
        {
            _location = location;
            _vendors = new List<Vendor>();
        }

        public bool AssignVendor(Vendor vendor)
        {
            if (_vendors.Contains(vendor) && vendor == null)
            {
                return false;
            }

            _vendors.Add(vendor);
            return true;
        }

        public bool RemoveVendor(Vendor vendor)
        {
            return _vendors.Remove(vendor);
        }
    }
}

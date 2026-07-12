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
        private List<Vendor> _vendor;

        public Stall(string location)
        {
            _location = location;
            _vendor = new List<Vendor>();
        }
    }
}

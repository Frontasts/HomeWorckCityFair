using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckCityFair
{
    public class Vendor
    {
        private string _name;

        public Vendor(string Name)
        {
            _name = Name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}

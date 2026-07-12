using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckCityFair
{
    public class Fair
    {
        private List<Stall> _stalls;

        public Fair()
        {
            _stalls = new List<Stall>();
        }

        public Stall AddStall(string location)
        {
            Stall stall = new Stall(location);
            _stalls.Add(stall);
            return stall;
        }

        public Stall[] GetAllStalls()
        {
            int stallLenght = _stalls.Count();
            Stall[] stalls = new Stall[stallLenght];

            _stalls.CopyTo(stalls);
            return stalls;
        }
    }
}

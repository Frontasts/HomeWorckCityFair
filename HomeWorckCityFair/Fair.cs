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

        public bool AddStall(Stall stall)
        {
            if(stall == null)
            {
                return false;
            }

            _stalls.Add(stall);
            return true;
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

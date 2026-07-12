using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckCityFair
{
    public class Program
    {
        public static void Main()
        {
            Vendor vendor1 = new Vendor("Анна Смирнова");
            Vendor vendor2 = new Vendor("Борис Козлов");
            Vendor vendor3 = new Vendor("Виктория Новикова");

            Fair fair = new Fair();

            Stall stallCenter = fair.AddStall("Центральная площадь");
            Stall stallPark = fair.AddStall("Городской парк");
            Stall stallMarket = fair.AddStall("Рынок на востоке");

            Console.WriteLine(stallCenter.AssignVendor(vendor1));
            Console.WriteLine(stallCenter.AssignVendor(vendor2));

            Console.WriteLine(stallPark.AssignVendor(vendor2));
            Console.WriteLine(stallPark.AssignVendor(vendor3));

            Console.WriteLine(stallMarket.AssignVendor(vendor1));
            Console.WriteLine(stallMarket.AssignVendor(vendor3));
            Console.WriteLine();

            Stall[] stalls = fair.GetAllStalls();
            Console.WriteLine();

            foreach (Stall stall in stalls)
            {
                Console.WriteLine(stall.GetLocation());
                Vendor[] vendors = stall.GetAllVendor();
                foreach (Vendor vendor in vendors)
                {
                    Console.WriteLine(vendor.GetName());
                }
                Console.WriteLine();
            }

            Console.WriteLine("--- Борис покидает ярмарку ---");
            stallCenter.RemoveVendor(vendor2);
            stallPark.RemoveVendor(vendor2);

            stalls = fair.GetAllStalls();
            Console.WriteLine();

            foreach (Stall stall in stalls)
            {
                Console.WriteLine(stall.GetLocation());
                Vendor[] vendors = stall.GetAllVendor();
                foreach (Vendor vendor in vendors)
                {
                    Console.WriteLine(vendor.GetName());
                }
                Console.WriteLine();
            }
        }
    }
}

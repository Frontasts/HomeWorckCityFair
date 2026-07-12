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

            Stall stallCenter = new Stall("Центральная площадь");
            Stall stallPark = new Stall("Городской парк");
            Stall stallMarket = new Stall("Рынок на востоке");

            Console.WriteLine(stallCenter.AssignVendor(vendor1));
            Console.WriteLine(stallCenter.AssignVendor(vendor2));

            Console.WriteLine(stallPark.AssignVendor(vendor2));
            Console.WriteLine(stallPark.AssignVendor(vendor3));

            Console.WriteLine(stallMarket.AssignVendor(vendor1));
            Console.WriteLine(stallMarket.AssignVendor(vendor3));
            Console.WriteLine();

            Fair fair = new Fair();
            Console.WriteLine(fair.AddStall(stallCenter));
            Console.WriteLine(fair.AddStall(stallPark));
            Console.WriteLine(fair.AddStall(stallMarket));

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

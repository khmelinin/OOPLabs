using System;
using KursachLib;

namespace Kursach
{
    class Program
    {
        static void Find(TourClub tc)
        {
            int q = 0;
            Console.WriteLine("What do you want to choose? by country(1), by agency(2), by theme(3), by price(4), by date(5)");
            q =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
           
                if (q < 1 || q > 5)
                    Console.WriteLine("Write a number >=1 and <=5");
            if(q==1)
            {
                        Console.WriteLine("Enter the country you want:");
                string c;
                c= Console.ReadLine();
                        tc.FindByCountry(c);
            }
            else if(q==2)
            {
                        Console.WriteLine("Enter the agency you want:");
                        string a = Console.ReadLine();
                        tc.FindByAgency(a);
            }
            else if(q==3)
            {
                        Console.WriteLine("Enter a theme that you want:");
                        string th = Console.ReadLine();
                        tc.FindByTheme(th);
            }
            else if(q==4)
            {
                        Console.WriteLine("Enter a max price that you want:");
                        double p = Convert.ToDouble(Console.ReadLine());
                        tc.FindByPrice(p);
            }
            else if(q==5)
            {
                        Console.WriteLine("Enter the date you want:");
                        Console.WriteLine("year: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("month: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("day: ");
                        int d = Convert.ToInt32(Console.ReadLine());
                        tc.FindByDate(new DateTime(y, m, d));
            }
                    
           
        }
        static void Main(string[] args)
        {
            Tour[] tours = { new Tour("Egypt", "Pyramids", 900, new DateTime(2020, 03, 04)), new Tour("USA", "Shooting Range", 400, new DateTime(2019, 03, 04)) };
            Agency[] agencies = { new Agency("NEWLINE", tours) };
            TourClub tc = new TourClub(agencies);

            Tour[] tours1 = { new Tour("Italy", "History", 700, new DateTime(2020, 10, 10)) };
            tc.Add(new Agency("EuTour", tours1));
            tc.Agencies[1].Add(new Tour("Egypt", "Sea", -900, new DateTime(2020, 03, 04)));

            Find(tc);
            Console.ReadKey();
        }
    }
}

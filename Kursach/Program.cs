using System;
using KursachLib;

namespace Kursach
{
    class Program
    {
        static bool Finding(Customer tmp, TourClub tourclub)
        {
            //
            Console.WriteLine("Do you want to find a tour? (y / n))");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes")
            {
                //
                Console.WriteLine("Finding by: Price(1), Country(2), Tour agency(3), Date(4), Theme(5) :");
                string s = Console.ReadLine();
                while (s != "1" || s != "2" || s != "3" || s != "4" || s != "5")
                {
                    Console.WriteLine("you need to write a right number");
                    s = Console.ReadLine();
                }
                string str = "";
                switch (s)
                {

                    case "1":
                        Console.WriteLine("Enter max price you want: ");
                        str = Console.ReadLine();
                        tmp.AddTour(tourclub.FindByPrice(Convert.ToInt32(str)));
                        break;
                    case "2":
                        Console.WriteLine("Enter country you want: ");
                        str = Console.ReadLine();
                        tmp.AddTour(tourclub.FindByCountry(str));
                        break;
                    case "3":
                        Console.WriteLine("Enter agency you want: ");
                        str = Console.ReadLine();
                        tmp.AddTour(tourclub.FindByAgency(str));
                        break;
                    case "4":
                        Console.WriteLine("Enter date you want: ");
                        Console.Write("year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("month: ");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.Write("day: ");
                        int day = Convert.ToInt32(Console.ReadLine());
                        tmp.AddTour(tourclub.FindByDate(new DateTime(year, month, day)));
                        break;
                    case "5":
                        Console.WriteLine("Enter theme you want: ");
                        str = Console.ReadLine();
                        tmp.AddTour(tourclub.FindByTheme(str));
                        break;

                }
                return true;
            }
            else
                if (answer == "n" || answer == "N" || answer == "no" || answer == "No")
                return false;
            else
            {
                Console.WriteLine("Incorrect answer formar");
                return Finding(tmp, tourclub);
            }
        }
        static void Start()
        {
            Tour[] toursPack1 = { new Tour("Egypt", "Pyramids", 900, new DateTime(2020, 03, 04)), new Tour("USA", "Shooting Range", 400, new DateTime(2019, 03, 04)) };
            Tour[] toursPack2 = { new Tour("Italy", "History", 700, new DateTime(2020, 10, 10)), new Tour("Brazil", "Fun", 1200, new DateTime(2021, 1, 2))};
            Agency[] agencies = { new Agency("NewLine",toursPack1)};
            TourClub tourclub = new TourClub("Absolutely TourClub", agencies);
            tourclub.AddAgency(new Agency("SkyLine", toursPack2));

            bool tf = true;
            while(tf)
            {
                //
                Console.WriteLine("Do you want to create a user? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes")
                {
                    Console.WriteLine("Enter your name: ");
                    var tmp = new Customer(Console.ReadLine());
                    //
                    Console.WriteLine("Do you want to enter a tour club? (y/n)");
                    string answer1 = Console.ReadLine();
                    while (((answer1 != "y" && answer1 != "Y" && answer1 != "yes" && answer1 != "Yes") || (answer1 != "n" || answer1 != "No" || answer1 != "no" || answer1 != "No")))
                    {

                        if (answer1 == "y" || answer1 == "Y" || answer1 == "yes" || answer1 == "Yes")
                        {
                            tmp.AddMyselfClub(tourclub);
                            bool b = true;
                            do
                            {
                                b = Finding(tmp, tourclub);
                            }
                            while (b);
                            break;
                        }

                        else
                        if (answer1 == "n" || answer1 == "N" || answer1 == "no" || answer1 == "No")
                            break;
                        else
                        {
                            Console.WriteLine("Incorrect answer format");
                        }
                    }


                }

            }
        }
        static void Main(string[] args)
        {
            Start();

            Console.ReadKey();
        }
    }
}

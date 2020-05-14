using System;
using KursachLib;

namespace Kursach
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Vasya = new Customer("Vasya");
            Customer Petya = new Customer("Petya");
            Customer Ivan = new Customer("Ivan");

            Tour[] tours = { new Tour("Egypt", "Pyramids", 900, new DateTime(2020, 03, 04)), new Tour("USA", "Shooting Range", 400, new DateTime(2019, 03, 04)) };
            Tour[] tours1 = { new Tour("Italy", "History", 700, new DateTime(2020, 10, 10)) };
            Agency[] agencies = { new Agency("NEWLINE", tours) };
            TourClub superclub = new TourClub("SuperClub",agencies);

            superclub.AddAgency(new Agency("EuTour", tours1));
            superclub.Agencies[1].Add(new Tour("Egypt", "Sea", -900, new DateTime(2020, 03, 04)));

            superclub.AddCustomer(Vasya);
            superclub.AddCustomer(Petya);
            superclub.AddCustomer(Ivan);

            Vasya.AddTour(superclub.FindByCountry("Egypt"));
            Petya.AddTour(superclub.FindByAgency("NEWLINE"));
            Ivan.AddTour(superclub.FindByDate(new DateTime(2020, 03, 04)));
            Petya.AddTour(superclub.FindByPrice(700));
            Petya.RemoveTour(0);
            superclub.RemoveCustomer(Petya);

            Console.ReadKey();
        }
    }
}

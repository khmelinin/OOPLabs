using System;
using KursachLib;

namespace Kursach
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour[] tours = { new Tour("Egypt", "Pyramids", 900, new DateTime(2020, 03, 04)) };
            Agency[] agencies = { new Agency("NEWLINE", tours) };
            TourClub tc = new TourClub(agencies);

            Tour[] tours1 = { new Tour("Italy", "History", 700, new DateTime(2020, 10, 10)) };
            tc.Add(new Agency("EuTour", tours1));
            tc.Agencies[1].Add(new Tour("Egypt", "Sea", -900, new DateTime(2020, 03, 04)));

            tc.FindByCountry("Egypt");
        }
    }
}

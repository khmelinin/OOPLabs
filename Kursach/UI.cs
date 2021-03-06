﻿using System;
using System.Collections.Generic;
using System.Text;
using KursachLib;

namespace Kursach
{
    static class UI
    {
        static List<Tour> tours;
        static List<Agency> agencies;
        static List<Customer> customers;
        static List<TourClub> tourclubs;

        static UI()
        {
            tours = new List<Tour>();
            agencies = new List<Agency>();
            customers = new List<Customer>();
            tourclubs = new List<TourClub>();
        }
        static void WatchTours(Customer tmp)
        {
            string answer1 = "";
            Console.WriteLine("Do you want to see your tours cart?");
            answer1 = Console.ReadLine();
            while (((answer1 != "y" && answer1 != "Y" && answer1 != "yes" && answer1 != "Yes") || (answer1 != "n" || answer1 != "No" || answer1 != "no" || answer1 != "No")))
            {

                if (answer1 == "y" || answer1 == "Y" || answer1 == "yes" || answer1 == "Yes")
                {
                    tmp.Print();
                    break;
                }
                else if (answer1 == "n" || answer1 == "N" || answer1 == "no" || answer1 == "No")
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Incorrect answer format");
                    Console.ResetColor();
                }
            }
        }
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
                int t = 0;
                try
                {
                    t = Convert.ToInt32(s);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Not a number");
                    Console.ResetColor();
                }


                while (t != 1 && t != 2 && t != 3 && t != 4 && t != 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("you need to write a right number");
                    Console.ResetColor();
                    s = Console.ReadLine();
                    try
                    {
                        t = Convert.ToInt32(s);
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Not a number");
                        Console.ResetColor();
                    }
                }
                string str = "";

                switch (t)
                {
                    case 1:
                        Console.WriteLine("Enter max price you want: ");
                        double tt = 0;
                        try
                        {
                            tt = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("---Not a number, max prise set to 0---");
                            Console.ResetColor();
                        }
                        tmp.AddTour(tourclub.FindByPrice(tt));
                        break;
                    case 2:
                        Console.WriteLine("Enter country you want: ");
                        str = Console.ReadLine();
                        tmp.AddTour(tourclub.FindByCountry(str));
                        break;
                    case 3:
                        Console.WriteLine("Enter agency you want: ");
                        str = Console.ReadLine();
                        tmp.AddTour(tourclub.FindByAgency(str));
                        break;


                    case 4:
                        Console.WriteLine("Enter date you want: ");
                        Console.Write("year: ");
                        int year = DateTime.Now.Month, month = DateTime.Now.Month, day = DateTime.Now.Day;
                        try
                        {
                            year = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Not a number, year set to now");
                            Console.ResetColor();
                        }

                        Console.Write("month: ");
                        try
                        {
                            month = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Not a number, month set to now");
                            Console.ResetColor();
                        }

                        Console.Write("day: ");
                        try
                        {
                            day = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Not a number, day set to now");
                            Console.ResetColor();
                        }
                        tmp.AddTour(tourclub.FindByDate(new DateTime(year, month, day)));
                        break;


                    case 5:
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Incorrect answer format");
                Console.ResetColor();
                return Finding(tmp, tourclub);
            }
        }
        static void Leaving(Customer c, TourClub tc)
        {
            Console.WriteLine($"Do you want to leave a tour club {tc.Name}? (y/n)");
            string answer1 = Console.ReadLine();
            while (((answer1 != "y" && answer1 != "Y" && answer1 != "yes" && answer1 != "Yes") || (answer1 != "n" || answer1 != "No" || answer1 != "no" || answer1 != "No")))
                if (answer1 == "y" || answer1 == "Y" || answer1 == "yes" || answer1 == "Yes")
                {
                    c.LeaveClub(tc);
                    break;
                }
                else
                    if (answer1 == "n" || answer1 == "N" || answer1 == "no" || answer1 == "No")
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Incorrect answer format");
                    Console.ResetColor();
                }
        }

        static void DelTour(Customer c)
        {
            Console.WriteLine($"Do you want to remove a tour? (y/n)");
            string answer1 = Console.ReadLine();
            while (((answer1 != "y" && answer1 != "Y" && answer1 != "yes" && answer1 != "Yes") || (answer1 != "n" || answer1 != "No" || answer1 != "no" || answer1 != "No")))
                if (answer1 == "y" || answer1 == "Y" || answer1 == "yes" || answer1 == "Yes")
                {
                    Console.WriteLine("Enter number of tour you want to remove from list: ");

                    try
                    {
                        int tt = Convert.ToInt32(Console.ReadLine());
                        if (tt < 0 || tt > c.TourCounts)
                            throw new Exception($"you haven't any tour in list with number {tt}");
                        else
                        {
                            c.RemoveTour(tt);
                            Console.WriteLine("Succes.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Not a number");
                        Console.ResetColor();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    DelTour(c);
                    break;

                }
                else
                    if (answer1 == "n" || answer1 == "N" || answer1 == "no" || answer1 == "No")
                    break;
                else
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Incorrect answer format");
                    Console.ResetColor();
                    DelTour(c);
                    break;
                }
        }

        public static void StartDefault()
        {
            string txt_logo = @"                                   /d.                                                              
                                  sMMN:                                                             
                                `hMMMMM+                                                            
                               .mMMMMMMMy                                                           
                              /NMMMMMMMMMd`                                                         
                             oMMMMMMMMMMMMN-                                                        
                           `hMMMMMMMMMMMMMMM+                                                       
                          .mMMMMMMMMMMMMMMMMMs                 `                                    
                         :NMMMMMMMMMMMMMMMMMMMd`              :Ny                                   
                        oMMMMMMMMMMMMMMMMMMMMMMm-            oMMMd`                                 
                      `yMMMMMMMMMMMMMMMMMMMMMMMMM/         `hMMMMMN-                                
                     .mMMMMMMMMMMMMMMMMMMMMMMMMMMMs       .mMMMMMMMM+                               
                    :NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh`    :NMMMMMMMMMMs                              
                   +MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh`   oMMMMMMMMMMMMMd`                            
                 `yMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMs   `yMMMMMMMMMMMMMMMm-                           
                .dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN/   .dMMMMMMMMMMMMMMMMMM/                          
               -NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm-   :NMMMMMMMMMMMMMMMMMMMMs                         
              +MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh`   +MMMMMMMMMMMMMMMMMMMMMMMh`                       
             yMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMs    yMMMMMMMMMMMMMMMMMMMMMMMMMm-                      
           `dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM/   .dMMMMMMMMMMMMMMMMMMMMMMMMMMMN/                     
          -NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN-   -NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMo                    
         /MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd`   +MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh`                  
        sMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMs    sMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm.                 
      `dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM+   `dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN:                
     -mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN-   -mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMo               
    /MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd.   /MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMh`             
   sMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy    sMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMm.            
 `hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM+   `hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN:           
-mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN:   -mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMo          
-:::::::::::::::::::::::::::::::`   /NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy`        
                                   oMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd.       
                                 `hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN:      
                                .mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM+     
                               :NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy    
                              oMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd.  
                            `hMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN- 
                           .mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM+

";
            Console.WriteLine(txt_logo);
            Console.WriteLine("\nTourClubPrograms inc.");
            Console.WriteLine("\nLoading...");
            Tour[] toursPack1 = {
                new Tour("Egypt", "Pyramids", 900, new DateTime(2020, 03, 04)),
                new Tour("USA", "Shooting Range", 400, new DateTime(2019, 03, 04)),
                new Tour("China", "Food", -400, new DateTime(2019, 03, 04)) };
            Tour[] toursPack2 = {
                new Tour("Italy", "History", 700,
                new DateTime(2020, 10, 10)),
                new Tour("Brazil", "Fun", 1200,
                new DateTime(2021, 1, 2))};
            tours.AddRange(toursPack1);
            tours.AddRange(toursPack2);
            agencies.Add(new Agency("NewLine", toursPack1));
            tourclubs.Add(new TourClub("Absolutely TourClub", agencies.ToArray()));
            agencies.Add(new Agency("SkyLine", toursPack2));
            tourclubs[0].AddAgency(agencies[1]);

            bool tf = true;
            while (tf)
            {
                //
                Console.WriteLine("Do you want to create a user? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes")
                {
                    Console.WriteLine("Enter your name: ");
                    var tmp = new Customer(Console.ReadLine());
                    customers.Add(tmp);
                    //
                    Console.WriteLine("Do you want to enter a tour club? (y/n)");
                    string answer1 = Console.ReadLine();
                    while (((answer1 != "y" && answer1 != "Y" && answer1 != "yes" && answer1 != "Yes") || (answer1 != "n" || answer1 != "No" || answer1 != "no" || answer1 != "No")))
                    {

                        if (answer1 == "y" || answer1 == "Y" || answer1 == "yes" || answer1 == "Yes")
                        {
                            tmp.AddMyselfClub(tourclubs[0]);
                            bool b = true;
                            do
                            {
                                b = Finding(tmp, tourclubs[0]);
                            }
                            while (b);
                            break;
                        }

                        else
                        if (answer1 == "n" || answer1 == "N" || answer1 == "no" || answer1 == "No")
                            break;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Incorrect answer format");
                            Console.ResetColor();
                            answer1 = Console.ReadLine();
                        }
                    }
                    WatchTours(tmp);
                    DelTour(tmp);
                    Leaving(tmp, tourclubs[0]);
                }
                else
                    if (answer == "n" || answer == "N" || answer == "no" || answer == "No")
                    tf = false;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Incorrect answer format");
                    Console.ResetColor();
                }

            }
        }
    }
}

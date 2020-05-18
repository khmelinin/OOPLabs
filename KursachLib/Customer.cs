using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KursachLib
{
    public class Customer:AbstractCustomer
    {
        delegate void EventDelegate(string msg);
        event EventDelegate Notify = (msg) => {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(msg);
            Console.ResetColor();
        };

        public Customer(string name, Tour[] tours) : base(name, tours) { }
        public Customer(string name) : base(name) { }

        public override void AddTour(Tour t)
        {
            tours.Add(t);
        }
        public override void AddTour(List<Tour> t)
        {
            tours.AddRange(t);
        }

        public int TourCounts
        {
            get { return tours.Count(); }
        }
        public void AddMyselfClub(TourClub t)
        {
            t.AddCustomer(this);
        }
        public void LeaveClub(TourClub t)
        {
            Notify?.Invoke($"Leaving from " + t.Name+" ...");
            t.RemoveCustomer(this);
        }

        public override void NotifyAdding(TourClub t)
        {
            tourclubs.Add(t);
            Notify?.Invoke($"You added to "+t.Name);
        }
        public override void RemoveClub(TourClub t)
        {
            tourclubs.Remove(t);
            Notify?.Invoke($"You has been removed from "+ t.Name);
        }
        public override void RemoveTour(int n)
        {

            Console.WriteLine($"________________\nTry to remove tour number {n} ...");
            
            tours.Remove(tours[n]);

            Console.WriteLine("________________");
        }
        public override void Print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.ResetColor();
            Console.WriteLine();
            
            for (int i = 0; i < tours.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" {i}. ");
                Console.ResetColor();
                tours[i].Print();
            }
            
        }
    }
}
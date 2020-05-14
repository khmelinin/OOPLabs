using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public class Customer:AbstractCustomer
    {
        delegate void EventDelegate(string msg);
        event EventDelegate Notify = (msg) => {
            Console.ForegroundColor = ConsoleColor.Yellow;
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


        public override void AddClub(TourClub t)
        {
            tourclubs.Add(t);
            Notify?.Invoke($"Customer "+ name + " added to "+t.Name);
        }
        public override void RemoveClub(TourClub t)
        {
            tourclubs.Remove(t);
            Notify?.Invoke($"Customer " + name + " has been removed from "+ t.Name);
        }
        public override void RemoveTour(int n)
        {
            tours.Remove(tours[n]);
        }
        public override void Print()
        {
            Console.WriteLine(name);
            for (int i = 0; i < tours.Capacity; i++)
            {
                tours[i].Print();
            }
        }
    }
}
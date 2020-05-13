using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace KursachLib
{
    public class Agency : AbstractAgency
    {
        public Agency(string company, Tour[] tours) : base(company, tours) { }
        public string Company { get => company; set => company = value; }
        public Tour[] Tours { get => tours; }
        public override void Print()
        {
            Console.WriteLine(company + " : ");
            for (int i = 0; i < tours.Length; i++)
            {
                tours[i].Print();
            }
        }
        delegate void EventDelegate(string msg);
        event EventDelegate Notify = (msg)=>{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
        };
        public override void Add(Tour tour)
        {

            Tour []tmp= new Tour[tours.Length+1];
            for (int i = 0; i < tours.Length; i++)
            {
                tmp[i] = tours[i];
            }
            tmp[tours.Length] = tour;
            tours = tmp;

            Notify?.Invoke($"Added new tour in " + company);
        }
        public void FindByDate(DateTime d)
        {
            for (int i = 0; i < tours.Length; i++)
            {
                if(tours[i].Date.Year==d.Year && tours[i].Date.Month==d.Month && tours[i].Date.Day==d.Day)
                {
                    Console.WriteLine(company);
                    tours[i].Print();
                }
            }
        }

        public void FindByPrice(double p)
        {
            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].Price <= p)
                {
                    Console.WriteLine(company);
                    tours[i].Print();
                }
            }
        }

        public void FindByCountry(string c)
        {
            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].Destination == c)
                {
                    Console.WriteLine(company);
                    tours[i].Print();
                }
            }
        }

        public void FindByTheme(string t)
        {
            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].Theme == t)
                {
                    Console.WriteLine(company);
                    tours[i].Print();
                }
            }
        }
        public void Cleaning()
        {
            int count = 0;
            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].Date.Year <= DateTime.Now.Year && tours[i].Date.Month<DateTime.Now.Month)
                {
                    count++;
                }
            }
            
            Tour[] tmp = new Tour[tours.Length - count];
            int j = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tours[i].Date.Year >= DateTime.Now.Year && tours[i].Date.Month >= DateTime.Now.Month)
                {
                    tmp[j] = tours[i];
                    j++;
                }
            }
            tours = tmp;
        }
    }
}
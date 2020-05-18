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
        public List<Tour> Tours { get => tours; }
        public override void Print()
        {
            Console.WriteLine(company + " : ");
            for (int i = 0; i < tours.Capacity; i++)
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

            tours.Add(tour);

            Notify?.Invoke($"Added new tour in " + company);
        }
        public List<Tour> FindByDate(DateTime d)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < tours.Capacity; i++)
            {
                if(tours[i].Date.Year==d.Year && tours[i].Date.Month==d.Month && tours[i].Date.Day==d.Day)
                {
                    //Console.WriteLine(company);
                    //tours[i].Print();
                    tmp.Add(tours[i]);
                    
                }
            }
            return tmp;
        }

        public List<Tour> FindByPrice(double p)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < tours.Count; i++)
            {
                if (tours[i].Price <= p)
                {
                    //Console.WriteLine(company);
                    //tours[i].Print();
                    tmp.Add(tours[i]);
                    
                }
            }
            return tmp;
        }

        public List<Tour> FindByCountry(string c)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < tours.Capacity; i++)
            {
                if (tours[i].Destination == c)
                {
                    //Console.WriteLine(company);
                    //tours[i].Print();
                    tmp.Add(tours[i]);
                    
                }
            }
            return tmp;
        }

        public List<Tour> FindByTheme(string t)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < tours.Capacity; i++)
            {
                if (tours[i].Theme == t)
                {
                    //Console.WriteLine(company);
                    //tours[i].Print();
                    tmp.Add(tours[i]);
                    
                }
            }
            return tmp;
        }
        public void Cleaning()
        {
            for (int i = 0; i < tours.Capacity; i++)
            {
                if (tours[i].Date.Year <= DateTime.Now.Year && tours[i].Date.Month<DateTime.Now.Month)
                {
                    tours.Remove(tours[i]);
                }
            }
        }
    }
}
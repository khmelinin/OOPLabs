using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public class Tour: AbstractTour
    {
        
        public string Destination { get => destination; set => destination = value; }
        public string Theme { get => theme; set => theme = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Date { get => date; set => date = value; }

        public Tour(string destination, string theme, double price, DateTime date) : base(destination, theme, price, date) { }
        public Tour(string destination, string theme, double price, DateTime date, string addition):base(destination, theme, price, date) { this.addition = addition; }
        
        public override void Print()
        {
            Console.WriteLine(destination + "\n" + theme + "\n" + price.ToString() + "\n");
        }
    }
}

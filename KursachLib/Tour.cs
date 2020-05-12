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
        public string Date { get => date; set => date = value; }
        public Tour(string destination, string theme, double price, string date) : base(destination, theme, price, date, "") { }
        public Tour(string destination, string theme, double price, string date, string addition):base(destination, theme, price, date, addition) { }
        public override void Print()
        {
            Console.WriteLine(destination + "\n" + theme + "\n" + price.ToString() + "\n" + addition + "\n");
        }
    }
}

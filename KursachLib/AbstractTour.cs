using System;

namespace KursachLib
{
    public abstract class AbstractTour:IPrint
    {
        protected string destination;
        protected string theme;
        protected double price;
        protected string date;
        protected string addition;

        protected AbstractTour(string destination, string theme, double price, string date, string addition)
        {
            this.destination = destination;
            this.theme = theme;
            this.price = price;
            this.date = date;
            this.addition = addition;
        }

        public abstract void Print();
    }
}

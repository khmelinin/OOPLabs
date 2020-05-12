using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KursachLib
{
    public abstract class AbstractAgency:IPrint
    {
        protected string company;
        protected Tour[] tours;

        protected AbstractAgency(string company, Tour[] tours)
        {
            this.company = company;
            this.tours = tours;
        }


        public abstract void Print();
        public abstract void Add(Tour tour);
    }
}

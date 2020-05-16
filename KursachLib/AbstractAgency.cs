using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KursachLib
{
    public abstract class AbstractAgency:IPrint
    {
        protected string company;
        protected List<Tour> tours;

        protected AbstractAgency(string company, Tour[] tours)
        {
            this.company = company;
            this.tours = new List<Tour>(tours);

            
            
        }


        public abstract void Print();
        public abstract void Add(Tour tour);
    }
}

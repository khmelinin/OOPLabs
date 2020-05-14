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

            /*
            for (int i = 0; i < tours.Length; i++)
            {
                this.tours.Add(tours[i]);
            }
            */
            
        }


        public abstract void Print();
        public abstract void Add(Tour tour);
    }
}

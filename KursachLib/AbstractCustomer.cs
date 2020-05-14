using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public abstract class AbstractCustomer:IPrint
    {
        protected string name;
        protected List<Tour> tours;
        protected List<TourClub> tourclubs;

        protected AbstractCustomer(string name, Tour[] tours)
        {
            this.name = name;
            this.tours = new List<Tour>(tours);
            tourclubs = new List<TourClub>();
        }
        protected AbstractCustomer(string name)
        {
            this.name = name;
            tours = new List<Tour>();
            tourclubs = new List<TourClub>();
        }
        public abstract void AddTour(Tour t);
        public abstract void AddTour(List<Tour> t);
        public abstract void AddClub(TourClub t);
        public abstract void RemoveClub(TourClub t);
        public abstract void RemoveTour(int n);
        public abstract void Print();
    }
}

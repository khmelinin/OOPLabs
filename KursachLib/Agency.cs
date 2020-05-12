using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public class Agency : AbstractAgency
    {
        public Agency(string company, Tour[] tours) : base(company, tours) { }
        public Tour[] Tours { get => tours;}
        public override void Print()
        {
            Console.WriteLine(company+" : ");
            for (int i = 0; i < tours.Length; i++)
            {
                tours[i].Print();
            }
        }
        public override void Add(Tour tour)
        {
            Tour[] tmp;
            for (int i = 0; i < tours.Length+1; i++)
            {
                tmp[i] = tours[i];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public class TourClub : AbstractTourClub
    {
        public TourClub(Agency[] agencies) : base(agencies) { }
        public Agency[] Agencies{get=>agencies;}
        public override void Add(Agency a)
        {
            Agency[] tmp = new Agency[agencies.Length+1];
            for (int i = 0; i < agencies.Length; i++)
            {
                tmp[i] = agencies[i];
            }
            tmp[agencies.Length] = a;
            agencies = tmp;
        }
        public override void FindByAgency(string co)
        {
            for (int i = 0; i < agencies.Length; i++)
            {
                if(agencies[i].Company==co)
                {
                    agencies[i].Print();
                }
            }
        }
        public void FindByCountry(string c)
        {
            for (int i = 0; i < agencies.Length; i++)
            {
                agencies[i].FindByCountry(c);
            }
        }
        public void FindByTheme(string t)
        {
            for (int i = 0; i < agencies.Length; i++)
            {
                agencies[i].FindByTheme(t);
            }
        }
        public void FindByPrice(double p)
        {
            for (int i = 0; i < agencies.Length; i++)
            {
                agencies[i].FindByPrice(p);
            }
        }
        public void FindByDate(DateTime d)
        {
            for (int i = 0; i < agencies.Length; i++)
            {
                agencies[i].FindByDate(d);
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public class TourClub : AbstractTourClub
    {
        public TourClub(string name, Agency[] agencies, Customer[]customers) : base(name, agencies, customers) {
            for (int i = 0; i < this.customers.Capacity; i++)
            {
                this.customers[i].AddClub(this);
            }
        }
        public TourClub(string name, Agency[] agencies) : base(name, agencies){}
        public List<Agency> Agencies{get=>agencies;}
        public string Name { get => name; }
        public override void AddAgency(Agency a)
        {
            agencies.Add(a);
        }
        public override void RemoveAgency(Agency a)
        {
            agencies.Add(a);
        }
        public override void AddCustomer(Customer a)
        {
            customers.Add(a);
            customers[customers.IndexOf(a)].AddClub(this);
        }
        public override void RemoveCustomer(Customer a)
        {
            
            customers[customers.IndexOf(a)].RemoveClub(this);
            customers.Remove(a);
        }
        public override List<Tour> FindByAgency(string co)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < agencies.Capacity; i++)
            {
                if(agencies[i].Company==co)
                {
                    //agencies[i].Print();
                    tmp.AddRange(agencies[i].Tours);
                }
            }
            return tmp;
        }
        public List<Tour> FindByCountry(string c)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < agencies.Capacity; i++)
            {
                tmp.AddRange(agencies[i].FindByCountry(c));
            }
            return tmp;
        }
        public List<Tour> FindByTheme(string t)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < agencies.Capacity; i++)
            {
                tmp.AddRange(agencies[i].FindByTheme(t));
            }
            return tmp;
        }
        public List<Tour> FindByPrice(double p)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < agencies.Capacity; i++)
            {
                tmp.AddRange(agencies[i].FindByPrice(p));
            }
            return tmp;
        }
        public List<Tour> FindByDate(DateTime d)
        {
            List<Tour> tmp = new List<Tour>();
            for (int i = 0; i < agencies.Capacity; i++)
            {
                tmp.AddRange(agencies[i].FindByDate(d));
            }
            return tmp;
        }
    }
}
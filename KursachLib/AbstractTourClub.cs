using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public abstract class AbstractTourClub
    {
        protected string name;
        protected List<Agency> agencies;
        protected List<Customer> customers;

        protected AbstractTourClub(string name, Agency[] agencies, Customer[] customers)
        {
            this.name = name;
            this.agencies=new List<Agency>(agencies);
            this.customers = new List<Customer>(customers);
            
        }
        protected AbstractTourClub(string name, Agency[] agencies)
        {
            this.name = name;
            this.agencies = new List<Agency>(agencies);
            customers = new List<Customer>();
        }

        public abstract void AddAgency(Agency a);
        public abstract void RemoveAgency(Agency a);
        public abstract void AddCustomer(Customer a);
        public abstract void RemoveCustomer(Customer a);
        public abstract List<Tour> FindByAgency(string co);

        
    }
}

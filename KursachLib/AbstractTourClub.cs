using System;
using System.Collections.Generic;
using System.Text;

namespace KursachLib
{
    public abstract class AbstractTourClub
    {
        protected Agency[] agencies;

        protected AbstractTourClub(Agency[] agencies)
        {
            this.agencies = agencies;
        }

        public abstract void Add(Agency a);
        public abstract void FindByAgency(string co);

        
    }
}

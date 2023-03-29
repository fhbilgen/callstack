using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callstackDOTNET
{
    internal class Kisi
    {
        private DateTime DT;
        private Boolean SigaraIcen;
        
        public Kisi(DateTime dt, bool sigara )
        {
            DT = dt;
            SigaraIcen = sigara;
        }

        public string GetName()
        {
            return "Kisi Adi";
        }
    }
}

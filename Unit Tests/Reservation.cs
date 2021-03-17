using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests
{
    class Reservation
    {
        public string MadeBy { get; set; }
        public bool CanBeCancelledBy(string name)
        {
            if(name=="chanuka")
            {
                return true;
            }
            if(name=="dinuwan")
            {
                return true;
            }
            return false;
        }
    }
}

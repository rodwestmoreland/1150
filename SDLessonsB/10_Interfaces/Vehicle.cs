using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    class Vehicle : IVehicleChallenge
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }


        public bool Drive()
        {
            throw new NotImplementedException();
        }

        public bool Off()
        {
            throw new NotImplementedException();
        }

        public bool Start()
        {
            throw new NotImplementedException();
        }
    }
}

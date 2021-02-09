using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    public interface IVehicleChallenge
    {
        string Make { get; set; }
        string Model { get; set; }
        string Color { get; set; }

        bool Start();
        bool Off();
        bool Drive();

    }
}

// vehicle types (sedans, SUV, motorcycle, etc)  
// -- methods start, turn off, drive, 
// -- props make, model, and color.
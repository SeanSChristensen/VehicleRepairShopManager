using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRepairShop.Classes
{
    public class TechnicalSpec
    {
        public string EngineType { get; private set; }
        public string Transmission { get; private set; }
        public int Mileage { get; private set; }
        public string Colour { get; private set; }

        public TechnicalSpec(string engineType, string transmission, int mileage, string colour)
        {
            EngineType = engineType;
            Transmission = transmission;
            Mileage = mileage;
            Colour = colour;
        }

        public TechnicalSpec()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VehicleRepairShop.Classes
{
    public class TechnicalSpec
    {
        [JsonProperty]
        public string EngineType { get; private set; }
        [JsonProperty]
        public string Transmission { get; private set; }
        [JsonProperty]
        public int Mileage { get; private set; }
        [JsonProperty]
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

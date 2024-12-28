using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using VehicleRepairShop.Classes.Abstracts;
using VehicleRepairShop.Classes;

namespace VehicleRepairShop.Logic
{
    public class JsonDeserialization
    {
        public static Car ImportCarFromJson(string filePath)
        {
            string jsonText = File.ReadAllText(filePath);
            Car vehicle = JsonConvert.DeserializeObject<Car>(jsonText);
            return vehicle;
        }
    }
}

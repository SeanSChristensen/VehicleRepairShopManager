using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser.Model;
using IniParser;

namespace VehicleRepairShop.Logic
{
    public class IniReader
    {
        public static string GetValue(string section, string key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("DBSettings.ini");
            return data[section][key];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.UI
{
    public class City
    {
        public string Name { get; set; }
    }

    public static class CityList
    {
        public static List<string> List { get; set; } = new List<string>()
        {
            "Jerusalem",
            "Tel Aviv",
            "Kiryat Motzkin"
        };
    }
}

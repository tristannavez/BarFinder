using System;
using System.Collections.Generic;
using System.Text;
using POIN.Shared;

namespace POIN.Shared
{
    public static class Helper
    {
        public static Location reformData(string input)
        {
            char[] separator = { '|' };
            string[] data = input.Split(separator);

            double lat = Convert.ToDouble(data[0]);
            double lng = Convert.ToDouble(data[1]);

            Location loc = new Location(lat, lng);
            return loc;
        }
    }
}

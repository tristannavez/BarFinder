using System;
using System.Collections.Generic;
using System.Text;

namespace POIN.Shared
{
    public class Location
    {
        public double Lng { get; set; }
        public double Lat { get; set; }

        public Location(double Lat, double Lng)
        {
            this.Lat = Lat;
            this.Lng = Lng;
        }
    }
}

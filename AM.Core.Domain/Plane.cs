using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    { Boing, Airbus }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Planeid { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }
        public Plane()
        {

        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {

            MyPlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;

        }
        public override string ToString()
        {
            return "Capacity:" + Capacity
                + "ManufactureDate:" + ManufactureDate
                + "Planeid:" + Planeid
                + "PlaneType:" + MyPlaneType;
        }
    }
}

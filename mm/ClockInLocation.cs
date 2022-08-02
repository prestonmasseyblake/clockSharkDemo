using System;
using CoreLocation;
using MapKit;
namespace mm
{
    public class ClockInLocation : MKAnnotation
    {
        string title;
        CLLocationCoordinate2D coord;
        public ClockInLocation(string title,
        CLLocationCoordinate2D coord)
        {
            this.title = title;
            this.coord = coord;
        }
        public override string Title
        {
            get
            {
                return title;
            }
        }

        public override CLLocationCoordinate2D Coordinate
        {
            get
            {
                return coord;
            }
        }
    }
}


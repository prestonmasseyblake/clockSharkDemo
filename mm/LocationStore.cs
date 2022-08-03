using System;
namespace mm
{
    public  class LocationStore : Application
    {
        public static double Latitude= 2;
        public static double Longitude = 2;
        public double ReturnLongitude {
        get { return Longitude;}
        set { Longitude = value;}
        }
    }
}


//public class HelloApplication : Application
//{
//    private int globalVariable = 1;

//    public int GlobalVariable
//    {
//        get { return globalVariable; };
//        set { globalVariable = value };
//    }
//}
using Foundation;
using UIKit;

namespace mm
{
    public class Application
    {
        

        public static double Latitudee = 2;
        //public double Longitude = 2;
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}

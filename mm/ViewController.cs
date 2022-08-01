using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using Xamarin.Essentials;

namespace mm
{
    public partial class ViewController : UIViewController
    {
        public void StartTimer(TimeSpan interval, Func<bool> callback)
        {
            NSTimer timer = NSTimer.CreateRepeatingTimer(interval, t =>
            {
                if (!callback())
                    t.Invalidate();
            });
            NSRunLoop.Main.AddTimer(timer, NSRunLoopMode.Common);
        }

        int counter = 0;
        int totalTime = 0;
        bool started = false;
        int secondCounter = 0;
        int singleMinPlace = 0;
        int tensMinPlace = 0;
        int hoursPlace = 0;
        int tensHoursplace = 0;
        List<Info> infos;
        //create a global array of dictionaries
        string[] times = new string[4];
        int i = 0;
     

        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();


            // location based stuff
           



            //end location based stuff





            UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
            DateTimeLabel.Text = DateTime.Now.ToString("dd MMMM, yyyy").ToUpper();

            infos = new List<Info>
            {
                new Info()
                {
                    ClockIn = "10:06:13PM", ClockOut = "10:06:19PM", Date="7/29/2022", Time=6
                },

            };
            InfoTableView.Source = new InfoTVS(infos);
            //InfoTableView.RowHeight = UITableView.AutomaticDimension;
            //InfoTableView.EstimatedRowHeight = 100f;
            InfoTableView.ReloadData();
          




           
            nexterButton.TouchUpInside += NexterButton_TouchUpInside;
            // Perform any additional setup after loading the view, typically from a nib.
        }
        // function for setting the label time 
        private string SetLabel ()
        {
            secondCounter++;
            string second_string = "";
            if (secondCounter < 10)
            {
                second_string = "0" + secondCounter.ToString();
            }
            else
            {
                second_string = secondCounter.ToString();
            }
            
            if (counter % 60 == 0)
            {
                secondCounter = 0;
                Console.WriteLine("trigging mod");
                if (singleMinPlace == 9)
                {
                    singleMinPlace = 0;
                    tensMinPlace++;
                }
                else
                {
                    secondCounter = 0;
                    singleMinPlace++;
                }
                
            }
           
            string time_string = ($"{tensHoursplace}{hoursPlace}:{tensMinPlace}{singleMinPlace}:{second_string}");
            return time_string;
        }
        //function for saving the amount of time clocked in
        public string formatTime(int t)
        {
            string return_string = "";
            int mins = 0;
            int val = 60;
            while (t > val)
            {
                t = t - val;
                mins++;
            }
            if (mins > 0)
            {
                return_string += mins.ToString() + "m ";
            }
            return_string += t.ToString() + "s";

            return return_string;
        } 
        private void NexterButton_TouchUpInside(object sender, EventArgs e)
        {
            // variables to save clock in and clock out
            string clockInTemp = DateTime.Now.ToString("h:mm:ss tt");
            DateTime thisDay = DateTime.Today;
            started = !started;
            if (started)
            {
                
                StartTimer(TimeSpan.FromSeconds(1), () =>
                 {
                    counter++;
                     TimeLabel.Text = SetLabel();
                     if (started) { 
                     return true; 
                     }
                     else
                     {
                         string clockOutTemp = DateTime.Now.ToString("h:mm:ss tt");
                         infos.Add(
                         new Info { ClockIn = clockInTemp, ClockOut = clockOutTemp, Date= thisDay.ToString("d"), Time = counter }
                         );
                         InfoTableView.Source = new InfoTVS(infos);
                         //InfoTableView.RowHeight = UITableView.AutomaticDimension;
                         //InfoTableView.EstimatedRowHeight = 100f;
                         InfoTableView.ReloadData();
                         totalTime += counter;
                         secondCounter = 0;
                         singleMinPlace = 0;
                         tensMinPlace = 0;
                         hoursPlace = 0;
                         tensHoursplace = 0;
                         counter = 0;
                         TimeLabel.Text = "00:00:00";
                         string temp_string = infos.Count.ToString();
                         EntriesLabel.Text = temp_string;
                         TotalTimeLabel.Text = formatTime(totalTime);
                         return false;
                     }
                 });

            }

        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace mm
{
	public partial class InfoCell : UITableViewCell
	{
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
        public InfoCell (IntPtr handle) : base (handle)
		{
		}
		internal void UpdateCell(Info info)
        {
			ClockInLabel.Text = info.ClockIn;
			ClockOutLabel.Text = info.ClockOut;
			DateLabel.Text = info.Date;
			TimeLabel.Text = formatTime(info.Time);
        }
	}
}

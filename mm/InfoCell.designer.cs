// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace mm
{
	[Register ("InfoCell")]
	partial class InfoCell
	{
		[Outlet]
		UIKit.UILabel ClockInLabel { get; set; }

		[Outlet]
		UIKit.UILabel ClockOutLabel { get; set; }

		[Outlet]
		UIKit.UILabel DateLabel { get; set; }

		[Outlet]
		UIKit.UILabel TimeLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ClockInLabel != null) {
				ClockInLabel.Dispose ();
				ClockInLabel = null;
			}

			if (DateLabel != null) {
				DateLabel.Dispose ();
				DateLabel = null;
			}

			if (TimeLabel != null) {
				TimeLabel.Dispose ();
				TimeLabel = null;
			}

			if (ClockOutLabel != null) {
				ClockOutLabel.Dispose ();
				ClockOutLabel = null;
			}
		}
	}
}

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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel DateTimeLabel { get; set; }

		[Outlet]
		UIKit.UILabel EntriesLabel { get; set; }

		[Outlet]
		UIKit.UITableView InfoTableView { get; set; }

		[Outlet]
		UIKit.UIButton nexterButton { get; set; }

		[Outlet]
		UIKit.UIButton nxtBtn { get; set; }

		[Outlet]
		UIKit.UILabel TimeLabel { get; set; }

		[Outlet]
		UIKit.UILabel TotalTimeLabel { get; set; }

		[Action ("nextButton:")]
		partial void nextButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InfoTableView != null) {
				InfoTableView.Dispose ();
				InfoTableView = null;
			}

			if (nexterButton != null) {
				nexterButton.Dispose ();
				nexterButton = null;
			}

			if (nxtBtn != null) {
				nxtBtn.Dispose ();
				nxtBtn = null;
			}

			if (TimeLabel != null) {
				TimeLabel.Dispose ();
				TimeLabel = null;
			}

			if (EntriesLabel != null) {
				EntriesLabel.Dispose ();
				EntriesLabel = null;
			}

			if (TotalTimeLabel != null) {
				TotalTimeLabel.Dispose ();
				TotalTimeLabel = null;
			}

			if (DateTimeLabel != null) {
				DateTimeLabel.Dispose ();
				DateTimeLabel = null;
			}
		}
	}
}

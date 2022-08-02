// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ViewController : UIViewController {
	UILabel *_DateTimeLabel;
	UILabel *_EntriesLabel;
	UITableView *_InfoTableView;
	UIButton *_nexterButton;
	UIButton *_nxtBtn;
	UILabel *_TimeLabel;
	UILabel *_TotalTimeLabel;
}

@property (nonatomic, retain) IBOutlet UILabel *DateTimeLabel;

@property (nonatomic, retain) IBOutlet UILabel *EntriesLabel;

@property (nonatomic, retain) IBOutlet UITableView *InfoTableView;

@property (nonatomic, retain) IBOutlet UIButton *nexterButton;

@property (nonatomic, retain) IBOutlet UIButton *nxtBtn;

@property (nonatomic, retain) IBOutlet UILabel *TimeLabel;

@property (nonatomic, retain) IBOutlet UILabel *TotalTimeLabel;

- (IBAction)nextButton:(id)sender;

@end

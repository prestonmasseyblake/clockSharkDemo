#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <CoreGraphics/CoreGraphics.h>

@class SceneDelegate;
@class AppDelegate;
@class InfoCell;
@class UITableViewSource;
@class mm_InfoTVS;
@class ViewController;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class __Xamarin_NSTimerActionDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class UIKit_UIControlEventProxy;
@class __NSObject_Disposer;
@class UIKit_UIScrollView__UIScrollViewDelegate;

@interface SceneDelegate : UIResponder<UIWindowSceneDelegate> {
}
	@property (nonatomic, assign) UIWindow * window;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(void) scene:(UIScene *)p0 willConnectToSession:(UISceneSession *)p1 options:(UISceneConnectionOptions *)p2;
	-(void) sceneDidDisconnect:(UIScene *)p0;
	-(void) sceneDidBecomeActive:(UIScene *)p0;
	-(void) sceneWillResignActive:(UIScene *)p0;
	-(void) sceneWillEnterForeground:(UIScene *)p0;
	-(void) sceneDidEnterBackground:(UIScene *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface AppDelegate : UIResponder<UIApplicationDelegate> {
}
	@property (nonatomic, assign) UIWindow * window;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(UISceneConfiguration *) application:(UIApplication *)p0 configurationForConnectingSceneSession:(UISceneSession *)p1 options:(UISceneConnectionOptions *)p2;
	-(void) application:(UIApplication *)p0 didDiscardSceneSessions:(NSSet <UISceneSession *>*)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface InfoCell : UITableViewCell {
}
	@property (nonatomic, assign) UILabel * ClockInLabel;
	@property (nonatomic, assign) UILabel * ClockOutLabel;
	@property (nonatomic, assign) UILabel * DateLabel;
	@property (nonatomic, assign) UILabel * TimeLabel;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UILabel *) ClockInLabel;
	-(void) setClockInLabel:(UILabel *)p0;
	-(UILabel *) ClockOutLabel;
	-(void) setClockOutLabel:(UILabel *)p0;
	-(UILabel *) DateLabel;
	-(void) setDateLabel:(UILabel *)p0;
	-(UILabel *) TimeLabel;
	-(void) setTimeLabel:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UITableViewSource : NSObject<UIScrollViewDelegate, UIScrollViewDelegate> {
}
	-(id) init;
@end

@interface ViewController : UIViewController {
}
	@property (nonatomic, assign) UILabel * DateTimeLabel;
	@property (nonatomic, assign) UILabel * EntriesLabel;
	@property (nonatomic, assign) UITableView * InfoTableView;
	@property (nonatomic, assign) UIButton * nexterButton;
	@property (nonatomic, assign) UIButton * nxtBtn;
	@property (nonatomic, assign) UILabel * TimeLabel;
	@property (nonatomic, assign) UILabel * TotalTimeLabel;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UILabel *) DateTimeLabel;
	-(void) setDateTimeLabel:(UILabel *)p0;
	-(UILabel *) EntriesLabel;
	-(void) setEntriesLabel:(UILabel *)p0;
	-(UITableView *) InfoTableView;
	-(void) setInfoTableView:(UITableView *)p0;
	-(UIButton *) nexterButton;
	-(void) setNexterButton:(UIButton *)p0;
	-(UIButton *) nxtBtn;
	-(void) setNxtBtn:(UIButton *)p0;
	-(UILabel *) TimeLabel;
	-(void) setTimeLabel:(UILabel *)p0;
	-(UILabel *) TotalTimeLabel;
	-(void) setTotalTimeLabel:(UILabel *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(BOOL) conformsToProtocol:(void *)p0;
@end



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foundation;
using SegmentedControl.FormsPlugin.iOS;
using UIKit;

namespace EPServices.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            SegmentedControlRenderer.Init();
           
            LoadApplication(new App());
            UITabBar.Appearance.BarTintColor = UIColor.White;
            UITabBar.Appearance.SelectedImageTintColor = UIColor.White;// UIColor.FromRGB(118, 53, 235);

            UITabBar.Appearance.TintColor = UIColor.Red;
            UITabBarItem.Appearance.SetTitleTextAttributes(
            new UITextAttributes()
            {
                TextColor = UIColor.White,
                Font= UIFont.BoldSystemFontOfSize(20)
            },
            UIControlState.Selected);

            // Color of the unselected tab icon & text:
            UITabBarItem.Appearance.SetTitleTextAttributes(
                new UITextAttributes()
                {
                    TextColor = UIColor.White,
                    Font = UIFont.BoldSystemFontOfSize(20)
                },
                UIControlState.Normal);
            return base.FinishedLaunching(app, options);
        }
    }
}

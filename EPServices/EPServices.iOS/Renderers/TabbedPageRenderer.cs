using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using EPServices.iOS.Renderers;

//[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageRenderer))]
namespace EPServices.iOS.Renderers
{
    //public class TabbedPageRenderer : TabbedRenderer
    //{
    //    public override void ViewWillAppear(bool animated)
    //    {

    //        if (TabBar?.Items == null)
    //            return;

    //        var tabs = Element as TabbedPage;
    //        if (tabs != null)
    //        {
    //            for (int i = 0; i < TabBar.Items.Length; i++)
    //            {
    //                UpdateItem(TabBar.Items[i], tabs.Children[i].Icon);
    //            }
    //        }

    //        base.ViewWillAppear(animated);
    //    }

    //    void UpdateItem(UITabBarItem item, string icon)
    //    {
    //        if (item == null)
    //            return;
    //        try
    //        {
    //            icon = icon.Replace(".png", "_selected.png");
    //            if (item?.SelectedImage?.AccessibilityIdentifier == icon)
    //                return;
    //            item.SelectedImage = UIImage.FromBundle(icon);
    //            item.SelectedImage.AccessibilityIdentifier = icon;
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Unable to set selected icon: " + ex);
    //        }

    //    }
    //    public TabbedPageRenderer() { TabBar.TintColor = UIColor.White; TabBar.BarTintColor = UIColor.FromRGB(231, 91, 51); TabBar.BackgroundColor = UIColor.White; }
    //}
    
}

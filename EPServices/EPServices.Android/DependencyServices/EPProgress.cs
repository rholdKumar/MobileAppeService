using System;
using AndroidHUD;
using EPServices.DependencyServices;
using EPServices.Droid.DependencyServices;
using Xamarin.Forms;


[assembly: Dependency(typeof(EPProgress))]
namespace EPServices.Droid.DependencyServices
{
    public class EPProgress : IEPProgress
    {
        public EPProgress()
        {
        }

        public void Dismiss()
        {
            AndHUD.Shared.Dismiss(MainActivity.myActivity);
        }

        public void Show()
        {
            AndHUD.Shared.Show(MainActivity.myActivity, "Please Wait", 1);
        }

        public void Show(string message)
        {
            AndHUD.Shared.Show(MainActivity.myActivity, message, 1);
        }
    }
}

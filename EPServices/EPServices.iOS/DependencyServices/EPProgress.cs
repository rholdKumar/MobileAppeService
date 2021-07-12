using System;
using BigTed;
using EPServices.DependencyServices;
using EPServices.iOS.DependencyServices;
using Xamarin.Forms;
using static BigTed.ProgressHUD;

[assembly: Dependency(typeof(EPProgress))]

namespace EPServices.iOS.DependencyServices
{
    public class EPProgress: IEPProgress
    {
        public EPProgress()
        {
        }

        public void Dismiss()
        {
            BTProgressHUD.Dismiss();
        }

        public void Show()
        {
            BTProgressHUD.Show("Please",1, MaskType.Gradient);
        }

        public void Show(string message)
        {
            BTProgressHUD.Show(message);
        }
    }
}

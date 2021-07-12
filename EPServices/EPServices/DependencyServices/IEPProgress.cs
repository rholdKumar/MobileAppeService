using System;


namespace EPServices.DependencyServices
{
    public interface IEPProgress
    {
        void Show();
        void Show(string message);
        void Dismiss();
    }
}

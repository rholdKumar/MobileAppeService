using System;
namespace EPServices.Hepler
{
    public static class ServiceEndPoints
    {
        public static Uri StagingServerUri => new Uri("http://192.168.1.60/epServicesApi/");
        public static Uri LiveServerUri => new Uri("https://crm.epgroup.ae/apiServices/");

        //http://192.168.1.60/epServicesApi/authuser?UserName=Deepak@gmail.com&Password=Ao5ZnFYo344iWqv/Jr9euw==&grant_type=password
        public static Uri ServerBaseUri { get { return LiveServerUri; } }

        public static Uri ServerImageUri { get { return StagingServerUri; } }

        public static string Login => "authuser?UserName={0}&Password={1}==&grant_type=password";

        // public static string sample = string.Format(Login, "kumar@gmail.com","password");

        public static string UserDashBoardUri => "V1/Owner/UserDashBoard?wid={0}";

        public static string DueBillsUri => "V1/Owner/DueBills?wid={0}";
        public static string ReviewPaymentUri => "V1/Owner/ReviewPayment?nid={0}&uid={1}&NGID={2}";

        public static string NoticeLineItemsUri => "V1/Owner/NoticeLineItems?nid={0}&uid={1}&NGID={2}";

        public static string PaidInvoiceHistoryUri => "V1/Owner/PaidInvoiceHistory?pId={0}&year={1}&wid={2}";

        public static string InvoiceHistoryUri => "V1/Owner/InvoiceHistory?pId={0}&year={1}&wid={2}";

        public static string PaymentRequestUri => "V1/Owner/PaymentRequest";
    }
}

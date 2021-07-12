using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPServices.DataServices;
using EPServices.Hepler;
using EPServices.Models;

namespace EPServices.ServiceLayer
{
    public class ServicesManagementSL
    {
        public async Task<ReceiveContext<List<NoticeInfoModel>>> GetDueBills(int wid)
        {
            return await WebServiceUtils<ReceiveContext<List<NoticeInfoModel>>>.GetData(string.Format(ServiceEndPoints.DueBillsUri, wid));
        }
        public async Task<ReceiveContext<ServiceChargesDetails>> GetReviewPayment(int wid)
        {
            return await WebServiceUtils<ReceiveContext<ServiceChargesDetails>>.GetData(string.Format(ServiceEndPoints.ReviewPaymentUri, wid));
        }

        public async Task<ReceiveContext<ServiceChargesDetails>> GetNoticeLineItems(int nid, int uid, string NGID)
        {
            return await WebServiceUtils<ReceiveContext<ServiceChargesDetails>>.GetData(string.Format(ServiceEndPoints.NoticeLineItemsUri, nid, uid, NGID));
        }
        public async Task<ReceiveContext<List<Invoices>>> GetPaidInvoiceHistory(int nid, int uid, string NGID)
        {
            return await WebServiceUtils<ReceiveContext<List<Invoices>>>.GetData(string.Format(ServiceEndPoints.PaidInvoiceHistoryUri, nid, uid, NGID));
        }
        public async Task<ReceiveContext<List<Invoices>>> InvoiceHistory(int pId, int year, int wid)
        {
            return await WebServiceUtils<ReceiveContext<List<Invoices>>>.GetData(string.Format(ServiceEndPoints.InvoiceHistoryUri, pId, year, wid));
        }
        public async Task<ReceiveContext<string>> PostPaymentRequest(PaymentRequestModel RequestModel)
        {
            return await WebServiceUtils<ReceiveContext<string>>.PostData(ServiceEndPoints.PaymentRequestUri, RequestModel);
        }
    }
}

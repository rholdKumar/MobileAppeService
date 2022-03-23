using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPServices.DataServices;
using EPServices.Hepler;
using EPServices.Models;

namespace EPServices.ServiceLayer
{
    public class UtilityManagementSL
    {
        public async Task<ReceiveContext<List<UtilityModel>>> PendingUtilityBills()
        {
            return await WebServiceUtils<ReceiveContext<List<UtilityModel>>>.GetData(ServiceEndPoints.PendingUtilityBills);
        }
        public async Task<ReceiveContext<string>> UtilityUtilityPay(int inid,string OSType,string DeviceId)
        {
            return await WebServiceUtils<ReceiveContext<string>>.GetData(string.Format(ServiceEndPoints.UtilityUtilityPay, inid, OSType, DeviceId));
        }
        public async Task<ReceiveContext<List<UtilityModel>>> UtilityPaidHistory()
        {
            return await WebServiceUtils<ReceiveContext<List<UtilityModel>>>.GetData(ServiceEndPoints.UtilityPaidHistory);
        }
        public async Task<ReceiveContext<UtilityModel>> UtilityDetails(int inid)
        {
            return await WebServiceUtils<ReceiveContext<UtilityModel>>.GetData(ServiceEndPoints.UtilityDetails+inid);
        }
    }
}

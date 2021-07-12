using System;
using System.Threading.Tasks;
using EPServices.DataServices;
using EPServices.Hepler;
using EPServices.Models;

namespace EPServices.ServiceLayer
{
    public class UserManagementSL
    {
        public async Task<ReceiveContext<mOwnerData>> ValidateUser(string UaserName, string encryptedPassword)
        {
            return await WebServiceUtils<ReceiveContext<mOwnerData>>.PostData(string.Format(ServiceEndPoints.Login, UaserName, encryptedPassword),null);
        }
        public async Task<ReceiveContext<mUserDashBoadModel>> GetOwnerDashBoard(int wid)
        {
            return await WebServiceUtils<ReceiveContext<mUserDashBoadModel>>.GetData(string.Format(ServiceEndPoints.UserDashBoardUri, wid));
        }
        public async Task<ReceiveContext<mUserDashBoadModel>> GetUserDashBoard(int wid)
        {
            return await WebServiceUtils<ReceiveContext<mUserDashBoadModel>>.GetData(string.Format(ServiceEndPoints.UserDashBoardUri, wid));
        }

    }
}

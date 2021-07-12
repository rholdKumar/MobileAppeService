using System;
using EPServices.Models;

namespace EPServices.Hepler
{
    public class CommonAttribute
    {
        public CommonAttribute()
        {
        }
        public static string AccessToken { get; set; }

        public static mOwnerData mOwnerData { get; set; }
    }
}

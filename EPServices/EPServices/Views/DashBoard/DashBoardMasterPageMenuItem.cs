using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServices.Views.DashBoard
{
    public class DashBoardMasterPageMenuItem
    {
        public DashBoardMasterPageMenuItem()
        {
            TargetType = typeof(DashBoardMasterPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public string imgName { get; set; }
        public Type TargetType { get; set; }
    }
}

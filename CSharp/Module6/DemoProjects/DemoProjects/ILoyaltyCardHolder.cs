using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjects
{
    interface ILoyaltyCardHolder
    {
        int TotalPoint { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}

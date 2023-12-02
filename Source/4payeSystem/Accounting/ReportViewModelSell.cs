using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4payeSystem.Accounting
{
    class ReportViewModelSell
    {
        public long SellAll { get; set; }
        public long SellCash { get; set; }
        public long SellInstallment { get; set; }
        public long AllSellCommodity { get; set; }
    }
}

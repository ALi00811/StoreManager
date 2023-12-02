using _4payeSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4payeSystem.Accounting
{
    class WarehouseAuditSell
    {
        public static int Number { get; set; }
        public static long Price { get; set; }
        public static long Prepayment { get; set; } = 0;
        static long PriceAll = 0;
        static int Numbers = 0;
        public static ReportViewModelSell ReportForMain()
        {
            ReportViewModelSell rp = new ReportViewModelSell();
            using (Entities3 db = new Entities3())
            {
                var SellAll = db.TblBuyKalas.ToList();
                foreach (var item in SellAll)
                {
                    Number = item.Number;
                    Price = item.Price;
                    PriceAll += Number * Price;
                    
                }
                rp.SellAll = PriceAll;
                PriceAll = 0;

                var sellChash = db.TblBuys.Where(s => s.Installments == 0);
                foreach (var item in sellChash)
                {
                    PriceAll += Price;
                }
                rp.SellAll = PriceAll;
                PriceAll = 0;

                var sellInstallment = db.TblBuys.Where(s => s.Installments != 0);
                foreach (var item in sellInstallment)
                {
                    if (item.Prepayment == null)
                    {
                        item.Prepayment = 0;
                    }
                    Prepayment = (Int64)item.Prepayment;
                    Price = item.Price;
                    PriceAll += Price + Prepayment;
                }
                rp.SellAll = PriceAll;
                PriceAll = 0;

                var AllSellCommodity = db.TblBuyKalas;
                foreach (var item in AllSellCommodity)
                {
                    Numbers += item.Number;
                }
                rp.AllSellCommodity = Numbers;
                Numbers = 0;

            }
            return rp;
        }
    }
}

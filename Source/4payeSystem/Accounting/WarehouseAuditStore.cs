using _4payeSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4payeSystem.Accounting
{
    public class WarehouseAuditStore
    {
        public static int Number  { get; set; }
        public static long Price { get; set; }
        static long PriceAll = 0;
        static int Numbers = 0;
        public static ReportViewModelWarehouse ReportForMain()
        {
            ReportViewModelWarehouse rp = new ReportViewModelWarehouse();
            using (Entities3 db = new Entities3())
            {
                var AllBalance = db.StorePTblurchases.Where(a => a.Number != 0);
                foreach (var item in AllBalance)
                {
                    Number = item.Number;
                    Price = item.PriceBuy;
                    PriceAll = (Number * (Int64)Price);
                    Numbers += item.Number;
                }
                rp.AllBalance = PriceAll;
                rp.AllCommodity = Numbers;
                PriceAll = 0;

                var Sell = db.TblBuyKalas;
                foreach (var item in Sell)
                {
                    Number = item.Number;
                    Price = item.Price;
                    PriceAll = (Number * Price);
                }
                rp.Sell = PriceAll;
                PriceAll = 0;

                var CurentValueStore =  db.StorePTblurchases.Where(a => a.Number != 0);
                foreach (var item in CurentValueStore)
                {
                    Number = item.Number;
                    Price = item.PriceSell;
                    PriceAll = (Number * (Int64)Price);
                }
                rp.CurentValueStore = PriceAll;
                PriceAll = 0;


                var CorbetStore = db.StorePTblurchases.Where(a => a.installment != 0);
                foreach (var item in CorbetStore)
                {
                    Number = item.Number;
                    Price = item.PriceSell;
                    PriceAll = (Number * (Int64)Price);
                }
                rp.CorbetStore = PriceAll;
                PriceAll = 0;


            }
            return rp;
        }
    }
}

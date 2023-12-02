using _4payeSystem.Customer;
using _4payeSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4payeSystem
{

    public class SubmitBuyUserToDb
    {
        public int InstallmentMonth { get; set; }
        
        public SubmitBuyUserToDb(List<TblBuy> ListBuyToDb,int IDCustomer, Entities3 DataBase, String NameCustomer, int Price,string SerialBuy,string TypeBuy, int PriceSend)
        {
            DateTime dt = DateTime.Now;
            if (ListBuyToDb.Count == 0)
            {
                ListBuyToDb.Add(new Model.TblBuy() { Name = NameCustomer, ID = IDCustomer, DateTime_Buy = dt, Type_Buy = TypeBuy });
            }
            else
            {
                ListBuyToDb[0].Name = NameCustomer;
                ListBuyToDb[0].ID = IDCustomer;
                ListBuyToDb[0].DateTime_Buy = dt;
                ListBuyToDb[0].Type_Buy = TypeBuy;
            }

            if (ListBuyToDb[0].Price == 0)
            {
                ListBuyToDb[0].Price = PriceSend;
            }
            var Insert = new TblBuy()
            {
                ID = ListBuyToDb[0].ID,
                Name = ListBuyToDb[0].Name,
                SerialBuy = SerialBuy,
                
                Price = ListBuyToDb[0].Price,
                DateTime_Buy = ListBuyToDb[0].DateTime_Buy,
                Installments = ListBuyToDb[0].Installments,
                Type_Buy = ListBuyToDb[0].Type_Buy,
                Prepayment = ListBuyToDb[0].Prepayment,
                Check_number1 = ListBuyToDb[0].Check_number1,
                Date_Check1 = ListBuyToDb[0].Date_Check1,
                Check_number2 = ListBuyToDb[0].Check_number2,
                Date_Check2 = ListBuyToDb[0].Date_Check2,
                Check_number3 = ListBuyToDb[0].Check_number3,
                Date_Check3 = ListBuyToDb[0].Date_Check3,
                Check_number4 = ListBuyToDb[0].Check_number4,
                Date_Check4 = ListBuyToDb[0].Date_Check4,
                Check_number5 = ListBuyToDb[0].Check_number5,
                Date_Check5 = ListBuyToDb[0].Date_Check5,
                Check_number6 = ListBuyToDb[0].Check_number6,
                Date_Check6 = ListBuyToDb[0].Date_Check6,
            };
            
            DataBase.TblBuys.Add(Insert);
            DataBase.SaveChanges();
            
            
        }
        public SubmitBuyUserToDb(int InstallmentMonth)
        {
            this.InstallmentMonth = InstallmentMonth;
        }
    }
}

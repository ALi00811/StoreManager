using _4payeSystem.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4payeSystem
{
    public class SubmitCheckNumberToDb
    {

        public SubmitCheckNumberToDb(List<string> CheckNumber, List<Atf.UI.DateTimeSelector> DateTime, int InstallmentMonth)
        {
            frmSetCustomer SetCustomer = Application.OpenForms.OfType<frmSetCustomer>().FirstOrDefault();
            SetCustomer.ListBuyToDb.Add(new Model.TblBuy{
            Check_number1 = CheckNumber[0].ToString(),
            Check_number2 = CheckNumber[1].ToString(),
            Check_number3 = CheckNumber[2].ToString(),
            Check_number4 = CheckNumber[3].ToString(),
            Check_number5 = CheckNumber[4].ToString(),
            Check_number6 = CheckNumber[5].ToString(),

            Date_Check1 = DateTime[0].Value,
            Date_Check2 = DateTime[1].Value,
            Date_Check3 = DateTime[2].Value,
            Date_Check4 = DateTime[3].Value,
            Date_Check5 = DateTime[4].Value,
            Date_Check6 = DateTime[5].Value,
            Installments = InstallmentMonth



            });
            
        }
    }
}

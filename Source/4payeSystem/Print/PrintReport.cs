using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using Stimulsoft.Report;
using _4payeSystem.Model;
using System.Globalization;
using _4payeSystem.Convertor;

namespace _4payeSystem.Print
{
    public class PrintReport
    {
        
        public PrintReport()
        {
            
        }
        public void PrintRepoertCash(StiReport stiprint, List<TblBuy> UserSerial,List<TblBuyKala> kalas, string type)
        {
            
            DataTable dtprint = new DataTable();
            dtprint.Columns.Add("Name");//
            dtprint.Columns.Add("Pricess");//
            dtprint.Columns.Add("Date");//
            dtprint.Columns.Add("TypeBuy");//
            dtprint.Columns.Add("Numberss");//
            dtprint.Columns.Add("Today");//
            
            string date = ToShamsi();
            foreach (var item in UserSerial)
            {
                string today = Convertor.Convertor.ToShamsi(item.DateTime_Buy);
                dtprint.Rows.Add(
                    item.Name, item.Price, today, type,item.ID,date
                    );
            }
            DataTable dtprint2 = new DataTable();

            dtprint2.Columns.Add("Name_kala");//
            dtprint2.Columns.Add("Number");//
            dtprint2.Columns.Add("Price");//
            foreach (var item in kalas)
            {
                dtprint2.Rows.Add(
                    item.Name_kala, item.Number, item.Price.ToString("0,#")
                    );
            }
            

            stiprint.Load(Application.StartupPath + "/ReportCash.mrt");

            stiprint.RegData("Kala", dtprint2);

            stiprint.RegData("DT", dtprint);
            stiprint.Show();

        }

        public void PrintReportInstallment(StiReport stiprint, List<TblBuy> UserSerial, List<TblBuyKala> kalas, string type)
        {
            DataTable dtprint = new DataTable();
            dtprint.Columns.Add("Name");
            dtprint.Columns.Add("Pricess");
            dtprint.Columns.Add("Date");
            dtprint.Columns.Add("TypeBuy");
            dtprint.Columns.Add("Numberss");
            dtprint.Columns.Add("Today");
            dtprint.Columns.Add("Prepayment");



            string date = ToShamsi();
            foreach (var item in UserSerial)
            {
                string today = Convertor.Convertor.ToShamsi(item.DateTime_Buy);
                dtprint.Rows.Add(
                    item.Name, item.Price, today, type, item.ID, date,item.Prepayment
                    );
            }
            DataTable dtprint2 = new DataTable();

            dtprint2.Columns.Add("Name_kala");//
            dtprint2.Columns.Add("Number");//
            dtprint2.Columns.Add("Price");//
            foreach (var item in kalas)
            {
                dtprint2.Rows.Add(
                    item.Name_kala, item.Number, item.Price.ToString("0,#")
                    );
            }


            stiprint.Load(Application.StartupPath + "/ReportInstallment.mrt");


            stiprint.RegData("DT", dtprint);
            stiprint.RegData("Kala", dtprint2);
            stiprint.Show();
        }
        static string ToShamsi()
        {
            PersianCalendar pc = new PersianCalendar();
            int day = pc.GetDayOfMonth(DateTime.Now);
            int month = pc.GetMonth(DateTime.Now);
            int year = pc.GetYear(DateTime.Now);
            return $"{year}/{month}/{day}";
        }
    }
}

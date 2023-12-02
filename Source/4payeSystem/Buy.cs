using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4payeSystem
{
    public class Buy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public System.DateTime DateTime_Buy { get; set; }
        public int Installments { get; set; }
        public string Type_Buy { get; set; }
        public Nullable<long> Prepayment { get; set; } = null;
        public string Check_number1 { get; set; } = null;
        public Nullable<System.DateTime> Date_Check1 { get; set; } = null;
        public string Check_number2 { get; set; } = null;
        public Nullable<System.DateTime> Date_Check2 { get; set; } = null;
        public string Check_number3 { get; set; } = null;
        public Nullable<System.DateTime> Date_Check3 { get; set; } = null;
        public string Check_number4 { get; set; } = null;
        public Nullable<System.DateTime> Date_Check4 { get; set; } = null;
        public string Check_number5 { get; set; } = null;
        public Nullable<System.DateTime> Date_Check5 { get; set; } = null;
        public string Check_number6 { get; set; } = null;
        public Nullable<System.DateTime> Date_Check6 { get; set; } = null;
    }
}

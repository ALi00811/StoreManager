using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4payeSystem
{
    public class CalculateThePrice
    {
        
        public long FinallyPrice(long price, long? prepayment)
        {
            price = price - Convert.ToInt64(prepayment);
           
            return price ;
        }
    }
}

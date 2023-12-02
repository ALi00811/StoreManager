using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4payeSystem
{
    public class InterestPercentageInterview
    {
        public int Computing(int Installments, int Price)
        {
            if (Installments == 1)
            {
                Price = Convert.ToInt32( Price + (Price * 0.3));
            }
            else if (Installments == 3)
            {
                Price = Convert.ToInt32(Price + (Price * 0.6));

            }
            else if (Installments == 6)
            {
                Price = Convert.ToInt32(Price + (Price * 0.10));

            }
            else if (Installments == 12)
            {
                Price = Convert.ToInt32(Price + (Price * 0.25));

            }
            return Price;
        }
    }
    
}

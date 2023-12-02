using _4payeSystem.Model;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4payeSystem
{
    public class SubmitKalaToDb
    {
        public SubmitKalaToDb(Entities3 Database, List<BuyKala> dgv, int ID,int mojoodi,string SerialBuy)
        {

            TblBuyKala kala = new TblBuyKala();
            
            foreach (var item in dgv)
            {
                kala.ID = ID;
                kala.Name_kala = item.Name_kala;
                kala.Number = item.Number;
                kala.Price = item.Price;
                kala.SerialBuy = SerialBuy;
                Database.TblBuyKalas.Add(kala);
                Database.SaveChanges();
                SetMojoodiKala set = new SetMojoodiKala(item.Name_kala, item.Number, mojoodi);
            }
            
        }
    }
}

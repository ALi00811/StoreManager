using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4payeSystem.Model;

namespace _4payeSystem
{
    public class SetMojoodiKala
    {
        public int Old { get; set; }
        public int news { get; set; }
        public SetMojoodiKala(string name , int NumberBuy , int mojoodi)
        {
            int id = 0;
            using (Entities3 db = new Entities3())
            {
                var data = db.StorePTblurchases.Where(d => d.Name_kala == name).ToList();
                foreach (var item in data)
                {
                    Old = Convert.ToInt16(item.Number);
                    id = item.ID;
                }

                news = Old - NumberBuy;
                
                var datanew = (from d in db.StorePTblurchases where d.ID == id select d).SingleOrDefault();
                datanew.Number = news;

                db.SaveChanges();
            }
        }
    }
}
